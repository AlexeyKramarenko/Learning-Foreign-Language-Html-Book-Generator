using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianGerman
{
    public class Lesson_1 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Официант! (Господин официант)",@"Herr Ober! "),
            (@"Чай холодный!",@"Der Tee ist kalt!"),
            (@"Какой чай?",@"Wie ist der Tee? "),
            (@"Он холодный!",@"Er ist kalt!"),
            (@"О, простите!",@"Oh, Verzeihung! "),
            (@"Официант, чай ceйuac  хорош,",@"Heгr Obeг, der Tee ist jetzt gut;"),
            (@"но чашка ...",@"aber die Tasse..."),
            (@"Да, (а что) чашка?",@"Ја, die Tasse?"),
            (@"Она слишком маленькая!",@"Sie ist zu klein! "),
        };

        public override string[] Notes => new[]
        {
            (@"В немецком языке все существительные пишутся с большой буквы."),
            (@"При обозначении определенного предмета в немецком языке используются определенные артикли: der - для существительных мужского рода, die - для женского."),
            (@"Глагол ""быть"" по-немецки в инфинитиве sein, в третьем лице единств, числа ist е пемецком языке используется и в настоящем времени. Сравните: Der Tee ist kalt. ""Чай холодный"""),
            (@"Буквальный перевод: ""Кaк чай?"""),
            (@"Буквально: ""О, прощение!"" В русском языке в этой ситуации тоже иногда обходятся без гпагола: ""Тысяча извинений!"""),
            (@"В немецком языке местоимения ""он"" и ""она"", er и sie так	же,	как	и		в	русском,		могут	заменять существительные		мужского	и	женского		рода орушевленные и неодушевленные."),
            (@"Можно перевести и так: ""Она слишком мала!"" В немецком языке нет кратких форм прилагателвных."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Какая чашка?",@"Wie ist die Tasse?"),
            (@"Она маленькая.",@"Sie ist klein."),
            (@"Какой  чай?",@"Wie ist der Tee?"),
            (@"Он слишком холодный.",@"Er ist zu kalt."),
            (@"Петер маленький, но (а) Клayc большой.",@"Peter ist klein, aber Klaus ist groß."),
        }; 

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            (@"Как чай? (Каков чай? Какой чай?",@"[Wie] ist der Tee?"),
            (@"Он хорош (он хороший).",@"[Er] ist gut."),
            (@"Простите, господин официант!",@"[Verzeihung], Herr Ober!"),
            (@"Чашка слишком маленькая (мала).",@"Die Tasse ist [zu] klein."),
            (@"Она маленькая (Она мала).", @"[Sie] ist klein."),
            (@"Анне маленькая, а (но) Клаус большой.",@"Anne ist	[klein], aber Klaus ist [groß]."),
        };
    }
}
