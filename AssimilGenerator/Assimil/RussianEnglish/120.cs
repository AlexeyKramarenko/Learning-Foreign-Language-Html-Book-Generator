using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_120 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Часто говорится, что англичане консервативны.",@"It is often said that the English are conservative."),
            (@"Я предпочитаю слышать, когда о них говорят, что они традиционны.",@"I prefer to hear* it said that they are traditionalist."),
            (@"В Великобритании существует много традиций и обычаев, и некоторые (из них) могут показаться иностранцам странными.",@"There are many traditions and customs in Britain and some may appear strange to foreigners."),
            (@"Например, тридцать первого октября можно увидеть детей, делающих маски из тыкв",@"For example, on October the thirty-first, one can see   children making masks from pumpkins"),
            (@"и вкладывающих внутрь свечки, чтобы испугать ведьм.",@"and putting* candles inside to frighten witches."),
            (@"Называется это Хеллоуин и (празднуется) днем раньше праздника Всех Святых.",@"This is called Hallowe'en   and is the day before All Saints' Day."),
            (@"Непосредство перед Пасхой, в Великую Пятницу, можно купить ""Хот Кросс Бане"".",@"Just before Easter, on Good Friday, you can buy* Hot Cross Buns."),
            (@"Это восхитительные пряные булочки с (изображенным на них крестом, напоминающим нам о распятии.",@"These are delicious spicy cakes, with a cross on them, to remind us of the Crucifixion."),
            (@"День после Рождества называется ""Боксинг Дэй"".",@"The day after Christmas is called Boxing Day."),
            (@"Он называется так потому, что хозяева домов имели обычай давать маленькие подарки или ""коробки"" продавцам, которые их обслуживали.",@"This is because householders used to give little presents or ""boxes"" to the tradesmen who had served them."),
            (@"В нынешние времена принято давать деньги.",@"Nowadays, it is usual to  give* money."),
            (@"Наверное, наиболее зрелищной традицией является ""Ночь костров"" или ""Ночь Гая Фоукеса"".",@"Perhaps the most spectacular tradition is ""Bonfire Night"" or ""Guy Fawkes Night""."),
            (@"Она имеет место пятого ноября и отмечает (дату) ареста в тысяча шестисот пятом году",@"This takes place on the fifth of November and celebrates the arrest, in sixteen-oh- five (1605),"),
            (@"Гая Фоукеса, который собирался взорвать здание Парламента.",@"of Guy Fawkes, who attempted to blow up the Houses of Parliament."),
            (@"Сегодня люди празднуют это (событие), разжигая костры, запуская фейерверки и сжигая куклы, называемые ""guys"".",@"Today, people celebrate by lighting bonfires, setting off fireworks and burning* effigies called ""guys""."),
        };

        public override string[] Notes => new[]
        {
            (@"[It is said] - переводим как говорится, говорят. [Не is said] - говорят о нем."),
            (@"[One can see] - можно увидеть. One равно как и you выражает безличную форму."),
            (@"[То hallow] - святить, посвящать, поднимать тревогу. "),
            (@"[Bun] - сладкая булочка с изюмом. "),
            (@"[It is usual to] - существует такой обычай, что...; так принято."),
            (@"[То celebrate] - праздновать, отмечать. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Можно по-прежнему видеть этот обычай в некоторых частях страны.",@"One can still see this custom in certain parts of the country."),
            (@"Он делает это, чтобы испугать свою сестру.",@"He does that to frighten his sister."),
            (@"Эта картина напомнила мне Тернера. ",@"This painting reminds me of Turner."),
            (@"Он разжигал огонь, когда его арестовали.",@"He was lighting a fire when he was arrested."),
            (@"Сколько мы должны заплатить, чтобы войти?",@"How much must we pay to get in?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "в давние времена люди делали подарки, но сейчас дают деньги.", "А long time [ago ], people [gave ] presents but [nowadays they] give money."),
            ( "Oн встал, закрыл окно и продолжал чтение. ", "Не [stood up], [closed/shut ] the window and continued [reading ]."),
            ( "Говорят, что англичане консервативны, но я так не думаю.", "It [is said ] that the English are [conservative ], but I [don't think] so."),
            ( "Существует много обычаев которые могут казаться иностранцам странными.", "[There are ] many customs which [may ] appear [strange to foreigners]."),
            ( "Он начал с поедения сладостей, а закончил питьем супа.", "Не [began/started ] by [eating ] the sweet and finished [by drinking] the soup."),
        };
    }
}
