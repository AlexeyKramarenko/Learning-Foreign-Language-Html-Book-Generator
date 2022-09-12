using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_41 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Питер и Дэвид удят рыбу: ",@"Peter and Dave are fishing:"),
            (@"Питер - У меня клюет (буквально у меня есть укус)!",@"Pete. - I've got a bite !"),
            (@"Дэвид - Это форель?",@"Dave, - Is it a trout?"),
            (@"Питер - Нет! Это оса.",@"Pete, - Ow, no! It's a wasp!"),
            (@"Невинность",@"Innocence"),
            (@"Маленькая девочка, <br> - Пейте чай, пожалуйста, господин Вильяме. Я хочу на вас посмотреть.",@"Little girl. <br> - Please drink your tea, Mr Williams. I want to watch  you."),
            (@"Господин Вильяме, - Конечно, моя дорогая. Но почему?",@"Mr Williams. - Of course my dear. But why?"),
            (@"Маленькая девочка - Потому, что мама говорит, что вы пьете как сапожник.",@"Little girl, - Because Mummy says you drink like a fish ®!"),
            (@"Шотландская молитва",@"A Scottish prayer"),
            (@"Отец небесный, благослови нас и сохрани нас всех в живых. ",@"Heavenly Father, bless us and keep ® us all alive."),
            (@"Нас восемь (человек) за обедом, ",@"There are eight of us for dinner"),
            (@"а хватит только на пятерых.",@"and there's only enough for five."),
            (@"Какое самое длинное слово в английском языке? - Не знаю.",@"What is the longest word in English? - I don't know."),
            (@"""Улыбки"", так как [расстояние] между первой и последней буквой одна миля.",@"""Smiles"", because there is a mile between the first and the last letter."), (@"Веди себя [будь] тихо в библиотеке. Люди читают.",@"Keep quiet in the library. People are reading."),
            (@"Я не хочу этого старого свитера. Можешь его оставить [себе].",@"I don't want this old pullover. You can keep it."),
        };

        public override string[] Notes => new[]
        {
            (@"[Bite] - укус, хватка. "),
            (@"[То watch] - смотреть, наблюдать за кем. [То watch television] - смотреть телевизор. [А watch] - наручные "),
            (@"[То drink like а fish] - идиома - пить как сапожник, напиваться в стельку. "),
            (@"[То keep] - смотри урок 17."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Прошу тебя, веди себя тихо, а то слишком много шума.",@"Please keep quiet, there is too much noise."),
            (@"Стабс, знаменитый художник, еще жив.",@"Stubbs, the famous painter, is still alive."),
            (@"Нет достаточного количества еды для нас всех.",@"There isn't enough food for all of us."),
            (@"Сколько километров в миле?",@"How many kilometers are there in a mile?"),
            (@"Она работает в библиотеке за Лондоном.",@"She works in a library outside London."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Сходи в книжный магазин и купи мне новый роман Грина.", "Go to the [bookshop] and buy [me ] the new [novel] by Greene"),
            ( "Какое самое длинное слово в английском языке? Я знаю самое короткое.", "[What ] is the [longest ] word [in ] English? I [know, the shortest]."),
            ( "Дай мне пять. Можешь оставить [себе] остальное.", "[Give] mе five. You can [keep] the rest."),
            ( "Когда ведешь машину в Англии помни: едь по левую сторону.", "[When] you [drive] in England, you must remember: [Keep left]."),
            ( "Oh не может этого продать. Ничего [не важно].", "Не саn't [sell it]. Never [mind]."),
        };
    }
}
