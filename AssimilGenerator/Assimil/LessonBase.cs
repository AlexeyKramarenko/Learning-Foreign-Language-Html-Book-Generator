using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assimil
{
    public class LessonBase
    {

        public virtual string[] Notes { get; } = new string[] { };
        public virtual ValueTuple<string, string>[] TranslationExample { get; } = new (string, string)[] { };
        public virtual ValueTuple<string, string>[] TranslationExercise { get; } = new (string, string)[] { };
        public virtual ValueTuple<string, string>[] ExerciseOnSentenceCompletion { get; } = new (string, string)[] { };

        public void AddHtmlFileToFolder(string folderName)
        {
            var lessonNumber = GetType().Name.Replace("Lesson_", "");
            int index = int.Parse(lessonNumber);
            Directory.CreateDirectory(folderName);
            using (var fs = new FileStream($@"{folderName}\{index}.html", FileMode.Create))
            using (var w = new StreamWriter(fs, Encoding.UTF8))
            {
                string htmlText = CreateHtmlText(index, this);
                w.WriteLine(htmlText);
            }
        }

        #region Private Methods

        private static string CreateHtmlText(int index, LessonBase lesson) =>
             $@"<!DOCTYPE html>
            <html>
            <head>
                <meta charset='utf-8' />
                <title></title>
                <link rel='stylesheet' href='./content/styles.css'>
            </head>  
            <body>                   
                <H2> Lesson {index}</H2>                              
                {(ConvertToExplanation(lesson.Notes).Length > 10 ? $"<h3>Notes:</h3>{ConvertToExplanation(lesson.Notes)}" : string.Empty)}                 
            <button onclick = 'showOrHide()'>Display/Hide answers</button>               
                {ConvertToDialogExample(GetFirstHalf(lesson.TranslationExample), 1)}                                
            <audio controls>
              <source src = './content/audio/{index}.mp3' type='audio/mpeg'>
            </audio>                 
                {ConvertToDialogExample(GetSecondHalf(lesson.TranslationExample), FirstHalfAmount(lesson.TranslationExample) + 1)}
            <img src='./content/images/{index}.png' alt=''>
            <br />
            <button onclick = 'showOrHide()'>Display/Hide answers</button>
            <h3>Translate</h3>                                
                {ConvertToDialogExample(lesson.TranslationExercise)}                               
                {(ConvertToDialogWithDots(lesson.ExerciseOnSentenceCompletion).Length > 10
                         ? $"<h3>Fill in missing words</h3>{ConvertToDialogWithDots(lesson.ExerciseOnSentenceCompletion)}"
                         : string.Empty)}               
            <script src='./content/scripts.js'></script>
            </body>
            </html>";


        private static string ConvertToDialogWithDots(IEnumerable<ValueTuple<string, string>> sentences) =>
                "<ol>" + string.Join("", sentences.Select(v => string.IsNullOrEmpty(v.Item1) && string.IsNullOrEmpty(v.Item2) ? string.Empty :
                           $@"<li> {v.Item1} <br/> {v.Item2.Replace("[", "<span>...</span><i>").Replace("]", "</i>")} </li>")) + "</ol>";


        private static string ConvertToDialogExample(IEnumerable<ValueTuple<string, string>> sentences, int startIndex = 0) =>
            "<table class='center'>" + string.Join("", sentences.Select((d, i) => string.IsNullOrEmpty(d.Item2) && string.IsNullOrEmpty(d.Item1) ? string.Empty :
                      $@"<tr> 
                        <td>{i + startIndex}</td>
                        <td> - </td>
                        <td class='rus'>{d.Item1}</td>
                        <td class='eng'>{d.Item2}</td>        
                    </tr>")) + "</table>";


        private static string ConvertToExplanation(string[] sentences) =>
             "<ol>" + string.Join("",
                 sentences.Select(d =>
                       string.IsNullOrEmpty(d)
                             ? string.Empty
                             : $@"<li>{d.Replace("[", "<b>").Replace("]", "</b>")}</li>")) + "</ol>";


        private static int FirstHalfAmount(ValueTuple<string, string>[] sequense) =>
            sequense.Count() / 2;


        private static IEnumerable<ValueTuple<string, string>> GetFirstHalf(ValueTuple<string, string>[] sequense) =>
            sequense.Take(FirstHalfAmount(sequense));


        private static IEnumerable<ValueTuple<string, string>> GetSecondHalf(ValueTuple<string, string>[] sequense) =>
            sequense.Skip(FirstHalfAmount(sequense));

        #endregion

    }
}