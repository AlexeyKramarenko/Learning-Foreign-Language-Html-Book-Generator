using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_52 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вот немного больше примеров правильных глаголов в настоящем и прошедшем времени, а также в форме действительного причастия.",@"Here are a few more examples of regular verbs in the present, in the past and with the past participle"),
            (@"Я надеюсь, я надеялся, я надеялся. Он снсивет, он лсил, он жил. Мы заканчиваем, мы закончили, мы закончили.",@"I hope, I hoped, I have hoped. He lives, he lived, he has lived. We finish, we finished, we have finished."),
            (@"Они разговаривают, они разговаривали, они разговаривали. Она меняет, она поменяла, она поменяла. Ты играешь, ты играл, ты играл.",@"They talk, they talked, they have talked. She changes, she changed, she has changed. You play, you played, you have played."),
            (@"Отработаем на практике прошедшее время глагола do. ",@"Let's practise Did the past of ""do"":"),
            (@"Он курит? Он курил? Мы не задаем никаких вопросов. Мы не задавали никаких вопросов.",@"Does he smoke? Did he smoke? We don't ask questions; we didn't ask questions."),
            (@"Что ты делаешь? Что ты делал?",@"What do you do? What did you do?"),
            (@"(Разве) он ждет? Ждал ли он? Она не отвечает. Она не отвечала.",@"Does he wait? Did he wait? She doesn't answer. She didn't answer."),
            (@"Саn - мочь, уметь и will являются неправильными глаголами с формами could и would в прошедшем времени. Эти глаголы не образуют действительного причастия.",@"""Can"" and ""will"" are irregular and become ""could"" and ""would"" in the past. They have no past participle."),
            (@"Я могу начать сейчас. Я не могла начать вчера.",@"I can begin now. I couldn't begin yesterday."),
            (@"Он не хотел работать [этим] утром, но будет (работать) сейчас.",@"He wouldn't work this morning, but he will now."),
            (@"У меня есть/ я имею, у меня была/ я имела.",@"I have (I've), I had."),
            (@"Я [есть], мы [есть], я была, мы были, я была.",@"I am (I'm), we are (we're), I was, we were, I have been."),
        };

        public override string[] Notes => new[]
        {
            (@"Форма действительного причастия [the past participle] - образует в связке с глаголом [to have] время [The Present Perfect Tense], которое выражает действие в прошлом, законченное или незаконченное в настоящем. "),
            (@"[I have hoped] - это предложение во времени [Present Perfect]. На русский язык переводится как действие в прошлом. Если, однако, мы говорим [I hoped] - Я имела надежду, то точно знаем, когда ее имела; если же говорим [I have hoped] - Я имела надежду, не знаем, когда это было и сохранилась ли эта надежда сейчас (имеем ли ее в настоящее время). Следует это только из контекста, в который данное предложение включено. "),
            (@"[То practise] - упраэюняться, [practice] - упражнение, практика. "),
            (@"Как видим, глагол [do] выполняет в предложении две  функции: вспомогательного глагола, с помощью которого образуется вопрос либо отрицание, и основного глагола, значащего делать, выполнять. "),
            (@"Т.е. не может употребляться во времени Present Perfect. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я надеялась, что он меня спросит, но он не спросил.",@"I hoped he would ask me, but he didn't."),
            (@"Ты летела самолетом или плыла на корабле?",@"Did you take the plane or the boat?"),
            (@"У нее были некоторые проблемы с [со своим] отцом.",@"She had a few problems with her father."),
            (@"Он извинялся (за то), что не мог мне помочь.",@"He was sorry he couldn't help me."),
            (@"Она подошла к окну и открыла его.",@"She walked over to the window and opened it."),
        }; 

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Они сменили свою машину на более маленькую / меньшую.", "They [changed ] their car for а [smaller] one. "),
            ( "Мы не могли купить билетов, потому что агенство было закрыто.", "We [couldn't buy ] the tickets, the agency [was closed]. "),
            ( "Bom несколько новых идей для твоей следующей книги.", "[Here are ] а few ideas for [your next] book. "),
            ( "Разве они играли хорошо? Да, но недостаточно хорошо.", "[Did ] they [play ] well? - Yes but [not ] well [enough]."),
            ( "Он курил I выкуривал восемнадцать сигарет за час. Это слишком много!", "Не [smoked eighteen ] cigarettes [in ] an hour. That's too [many]."),
        };
    }
}
