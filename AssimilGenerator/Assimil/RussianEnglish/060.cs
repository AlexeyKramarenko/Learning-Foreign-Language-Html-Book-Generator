using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_60 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Рассмотрим некоторые обороты с глаголом to get – достать, получить.",@"Let's look at some expressions with the verb ""to get"".*"),
            (@"Эти обороты повседневны, и некоторые из них вы уже знаете.",@"These expressions are very common, and you already know* a few."),
            (@"Здесь (приведем) их немного больше. Попробуйте их запомнить.",@"Here are some more. Try and learn them."),
            (@"Он встает в полвосьмого каждое утро.",@"He gets* up at half-past seven every morning."),
            (@"Поезд приезджает в одиннадцать тридцать.",@"The train gets* in at eleven thirty."),
            (@"Ему потребовалось [это отняло у него] много времени для преодоления своей болезни.", @"It took* him a long time to get* over his illness."),
            (@"Пойдем домой. Темнеет [делается темно],",@"Let's go* home. It's getting* dark."),
            (@"Говори громче. Она становится совсем глухой.", @"Speak* louder. She's getting* very deaf."),
            (@"Эти пластинки дешевле тех, но (и) они все еще очень дорогие.", @"These records are cheaper than those, but they are still quite expensive."),
            (@"Пожалуйста, пойди и принеси мне газету, я слишком занят, чтобы пойти самомую", @"Please, go* and get* me a paper, I'm too busy to go* myself."),
            (@"Грабитель влез в квартиру через маленькое окно.",@"The burglar got* into the house through a small window."),
            (@"(Hyжно) сесть [взять] в автобус номер тридцать семь и выйти на Черинг Кросс.",@" Take* a number thirty-seven bus and get* off at Charing Cross."),
            (@"Каждый пробовал сесть в автобус сразу же.", @"Everyone was trying to get* on the bus at once."),
            (@"Что случилось? - У меня болит голова, зуб, горло и я простужена",@"What's the matter? - I've got* a headache, a toothache, a sore throat and a cold,"),
            (@"и никто не интересуется [не спрашивает меня], как я себя чувствую.", @"and nobody asks me how I feel* !"),
        };

        public override string[] Notes => new[]
        {
            (@"[Common] - обычный, повседневный; [common people] обычные люди."),
            (@"[Illness] - болезнь. [She's ill] - она больна. To же самое значит предложение [she's sick]. [Sick] чаще используется в американском варианте английского. "),
            (@"[At once = immediately] - сразу же. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Те книги мои, эти - его.",@"Those books are mine; these are his."),
            (@"Как ты себя сегодня чувствуешь? - Очень хорошо, спасибо.",@"How do you feel today? - Very well, thanks."),
            (@"Не говорите все сразу, не могу понять (ни) слова.",@"Don't all speak at once, I саn’t understand a word."),
            (@"У меня болит зуб, и нет зубного врача в моей деревне.",@"I have a toothache and there is no dentist in my village."),
            (@"У меня нет больше сигарет. <br> - Вот немного больше <br> (Здесь несколько штук осталось).",@"I have no more cigarettes. <br> - Here are some more."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "В котором часу он обычно встает? ", "[What time ] does he [usually ] get [up]?"),
            ( "Когда поезд приедет, позвони мне с вокзала. ", "When the train [gets in ] phone me [from the station]."),
            ( "Каждый пробовал сесть в автобус сразу же. ", "[Everyone ] was trying to [get on ] the bus [at once]."),
            ( "Следует поторопиться. Темнеет.", "[Let's ] hurry up. It's [getting dark]."),
            ( "Сойди у почти. - Как далеко это? ", "[Get off] at the post office. - How [far is it]?"),
        };
    }
}
