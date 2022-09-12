using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_81 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вы когда-нибудь раньше видели карту Англии?",@"Have you seen* a map of England before?"),
            (@"Вы, наверное, заметили количество больших городов и метрополий.",@"You must have noticed the number of large towns and cities."),
            (@"Англия менее централизована чем Франция. Такие города как Манчестер и Бристоль",@"England is less centralised than France. Cities like Manchester and Bristol"),
            (@"имеют свою собственную значительную культурную жизнь.",@"have an important cultural life of their own."),
            (@"Метрополия больше города и, как правило, имеет свой кафедральный собор.",@"A city is larger than a town and usually has a cathedral."),
            (@"Бирмингем, Ноттингем, Лестер, Саутгемптон - это метрополии,",@"Birmingham, Nottingham, Leicester and Southampton are all cities;"),
            (@"а Гильфорд, Уэртинг, Глостер - это города.",@"and Guildford, Warwick and Gloucester are towns."),
            (@"Между севером и югом страны - большая и значительная разница:",@"There is a large and important difference between the North and the South of the country:"),
            (@"разница в людях и разница в акценте.",@"a difference in the people and a difference in the accent."),
            (@"Учитесь говорить с южным акцентом,",@"You are learning to speak* with a southern accent."),
            (@"Англия разделена на графства, которых около сорока.",@"England is divided into ""counties"", of which there are about forty."),
            (@"Корнуолл, южный конец Англии, очень дикий и красивый.",@"Cornwall, the southern tip of England, is very wild and beautiful."),
            (@"На севере, Йоркшир - это самое большое графство.",@"In the North, Yorkshire is the largest county."),
            (@"Кент называют ""Садом Англии"".",@"Kent is called ""The Garden of England""."),
        };

        public override string[] Notes => new[]
        {
            (@"[You must have noticed] - вы, наверное, заметили. Мы уже встречались с похожей конструкцией в уроке 72 (5), только с глаголом [ would]. Так же как и в том уроке, давайте пока запомним только ее значение. "),
            (@"[Tip] - конец, кончик, пик, чаевой. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Какова разница между севером и югом?",@"What is the difference between the North and the South?"),
            (@"Ты не должен читать в кровати, это нехорошо для твоих глаз.",@"You shouldn't read in bed, it's bad for your eyes."),
            (@"Господии Марсден - очень важный человек.",@"Mr. Marsden is a very important man."),
            (@"Она работает в крупной газете.",@"He works for a large newspaper."),
            (@"У него есть свой собственный велосипед.",@"He has a bicycle of his own."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн пришел бы, если б ты его попросил. ", "Не [would come ] if you [asked him ]."),
            ( "Она не должна занимать денег у своего брата. ", "She [shouldn't borrow ] money [from her] brother."),
            ( "У нее есть четыре велосипеда, три из которых не работают.", "Не has four bikes, [of which ] three [don't work]!"),
            ( "Они были дваж:ды в Шотландии и один раз в Ирландии.", "They [have been ] to Scotland [twice ] and [to ] Ireland [once]."),
            ( "Они, посисалуйу ушли, я не виэюу света в их квартире. ", "They [must have ] left, I [can't ] see [a (any) - ] light [in the flat]."),
        };
    }
}
