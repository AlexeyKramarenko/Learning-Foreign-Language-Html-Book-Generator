using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_74 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Выучим несколько полезных выражений.",@"Let's learn some useful expressions."),
            (@"Когда англичане встречаются в первый раз, [они] говорят: ""Здравствуйте"".",@"When English people ® meet* for the first time, they say*: ""How do you do?"""),
            (@"В ответ звучит: ""Здравствуйте"".",@"The answer is: ""How do you do?"""),
            (@"После этой первой встречи можно сказать: ""Как дела?"" или просто: ""Привет"".",@"After this first meeting, you may say ""How are you?"", or simply ""Hello."""),
            (@"Молодежь считает, что это формулы слишком формальны и пытается их избегать.",@"Younger people find* these formulas too formal and try to avoid them."),
            (@"Люди редко пожимают друг другу руки в Англии.",@"People rarely shake* hands in England."),
            (@"Вот типичный ""вежливый"" разговор:",@"Here is a typical ""polite"" conversation:"),
            (@"Привет, Дэвид, как дела?",@"Hello, David, how are you?"),
            (@"Прекрасно, спасибо. A у тебя?",@"Fine, thank you. And you?"),
            (@"У меня (все) хорошо. Позволь мне представить (тебе - это) Эндрю Вильямса.",@"I’m very well. Let* me introduce Andrew Williams."),
            (@"Здравствуйте. - Приятно с Вами познакомиться.",@"How do you do? - Pleased to meet* you"),
            (@"Очень плохая погода, не правда ли? - Да, но сейчас становится теплее.",@"Terrible weather, isn't it?  - Yes, but it's getting* warmer now."),
            (@"[Я] надеюсь, мы вскоре увидим [будем иметь] немного солнца.",@"I hope we will have some sun soon."),
            (@"Да, я уже должен идти, иначе опоздаю. Передавай [мои] привет[ы] своей жене. До свиданья.",@"Well, I must be off® or I'll be late. Give* my regards ® to your wife. Good-bye."),
            (@"(Передам) [я буду]. Береги себя. До свиданья.",@"I will. Take* care of yourself. Good-bye."),
        };

        public override string[] Notes => new[]
        {
            (@"[The English] - англичане, [English people] - тоже англичане,  но более обобщенно, может быть, английский народ. Так же и [younger people] - молодые люди, молодежь. "),
            (@"[Let me introduce] - стоит запомнить этот оборот - Разрешите мне представить(ся). "),
            (@"[Pleased to meet you] - также оборот вежливости, переводимый Приятно познакомиться/встретиться с тобой/вами, синонимичный [Nice to meet you.]"),
            (@"[To be off] - выйти, [I must be off or...] - в этом предложении or переводим как иначе, в противном случае. "),
            (@"[Give my regards to ...] - передай привет ... [Best/kindnest regards] - сердечные приветы. [То regard] - yважать (кого- либо). [I regard him highly] - Я очень его уважаю. "),
            (@"[Take care (of yourself)] - береги/те себя - это очень часто используемый оборот."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мы редко представляем Эндрю наших друзей.",@"We rarely introduce our friends to Andrew."),
            (@"Приятно с Вами познакомиться. <br> Как Вас зовут?",@"Pleased to meet you. <br> What is your name?"),
            (@"Надеюсь, что он примет наше предложение.",@"I hope he will accept our offer."),
            (@"Он сделал это, не подумав.",@"He did it without thinking."),
            (@"Эти газеты бесплатны. Пожалуйста, возьмите одну.",@"These papers are free. Please take one."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Позволь мне (предложить) [дать] тебе напиток. ", "[Let ] mе [offer you] а drink."),
            ( "Позволь мне пригласить тебя на обед. ", "[Allow ] mе [to invite you] to dinner. "),
            ( "Я должен идти иначе опоздаю. Передавай приветы своей жене.", "I [must ] be [off] or I [will be late ]. Give [my regards ] to [your] wife."),
            ( "Попробуй миновать автостраду, там слишком большое движение.", "[Try ] to [avoid ] the motorway, there [is too much traffic]."),
            ( "Он всегда позволяет мне пользоваться своей машиной, если она ему не нужна.", "Не always [lets ] me [take his ] car if [he does ] not [need it]."),
        };
    }
}
