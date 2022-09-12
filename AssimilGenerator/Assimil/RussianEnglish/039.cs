using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_39 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Лондон больше, чем Париж, но меньше, чем Нью-Йорк.",@"London is larger than Paris but smaller than New York."),
            (@"В большом Лондоне (Greater London) свыше восьми миллионов жителей,",@"There are more than eight million inhabitants in Greater London,"),
            (@"больше чем население Шотландии и Уэльса вместе [взятых].",@"more than the populations of Scotland and Wales together."),
            (@"Внутренний Лондон меньше. Здесь находится ""Вэст энд"" [западный конец] со своими театрами",@"Inner London is smaller. Here you find the ""West End"" with its theatres"),
            (@"и Сити [город], - финансовый центр Англии.",@"and the City, which is the financial centre of England."),
            (@"Это также древнейшая часть Лондона и еще имеет [сохранила] старые традиции.",@"It is also the oldest part of London and still has some ancient traditions."),
            (@"Например Мэр Лондона является Мэром только Сити.",@"For example, the Lord Mayor of London is mayor of the City only."),
            (@"Самая важная часть Сити - это биржа,",@"The most important part of the City is the Stock Excliange"),
            (@"которая так же важна, как и биржа в Париже,",@"which is as important as the Bourse in Paris."),
            (@"Почти на каждой улице находится прекрасный костел, как правило, [часто] спроектированный Вреном.",@"In almost every street, there is a beautiful church, often designed by Wren"),
            (@"Среди достопримечательностей [интересных для осмотра мест] - Трафалгарская площадь",@"Among the places of interest to see are Trafalgar Square,"),
            (@"со своими стаями голубей и четырьмя бронзовыми львами;",@"with its colony of pigeons and four bronze lions;"),
            (@"и здания парламента и Биг Бен.",@"and the Houses of Parliament and Big Ben."),
            (@"На самом деле, колокол, а не часы называется Биг Бен.",@"In fact, h is the bell and not the clock which is called Big Ben."),
        };

        public override string[] Notes => new[]
        {
            (@"<b>Inhabitants</b> - жители inhabited - заселенный!-ая, -ое, uninhabited - незаселенный. "),
            (@"<b>Greater London</b> - Лондон и его пригороды. "),
            (@"Центр Лондона делится на Вэст энд и Сити."),
            (@"<b>Which ... </b> или <b>that...</b>, который!-ая!-ое; которого!-ой относится к неодушевленным существительным, who... или <b>whom</b> который!-ая1-ое\ которого!-ой относится к людям. "),
            (@"<b>Sir Christopher Wren</b> - один из самых знаменитых английских архитекторов XVII века. Среди прочего оп восстановил после пожара Лондона в 1966 году кафедральный собор <b>Saint Paul's</b> (Святого Павла)."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Твой шурин (зять) и его друг приезжают вместе.",@"Your brother-in-law and his friend are arriving together."),
            (@"Это самое сложное предложение [Это то предложение, которое самое сложное].",@"It is this sentence which is the most difficult."),
            (@"У нас есть кофе или чай. Что ты хочешь?",@"We have coffee or tea. Which do you want?"),
            (@"Какой костел в Лондоне самый красивый?",@"Which is the most beautiful church in London?"),
            (@"Она библиотекарь, а не секретарша.",@"She is a librarian, not a secretary."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мужчина, с которым ты разговариваешь - бывший министр.", "The man [to whom] you are [talking] is an ex-minister."),
            ( "У нас есть друг, который великолепно играет на пианино.", "We have а [friend who] plays [the piano] marvelously."),
            ( "Кто хочет поехать с нами в Лондон.", "[Who] wants [to come] to London with [us]?"),
            ( "Что интереснее Лондон или Эдинбург?", "[Which is more] interesting, London [or Edinburhg]?"),
            ( "Нам лучше уйти теперь. Уже поздно.", "We [had better leave] now. It's [already late]."),
        };
    }
}
