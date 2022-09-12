using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_138 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Я поменял деньги в Англии и получил хорошую цену за мои франки.",@"I had changed my money in England and had got a good rate   for my francs."),
            (@"Я сделал покупки и купил все традиционные вещи, которые покупают туристы.",@"I did some shopping and bought* all the traditional things that tourists buy*:"),
            (@"Шетландские свитера, твидовый пиджак. Собирался даже купить смокинг,",@"Shetland pullovers, a tweed jacket. I was even going to buy* a dinner jacket,"),
            (@"Hо это было бы слишком экстравагантно [немного расточительно].",@"but it would have been a little too extravagant."),
            (@"Вечером перед отъездом пошел посмотреть мюзикл.",@"The night before I left*, I went to see a musical."),
            (@"Как знаешь, у нас в Париже (мюзиклов) немного, поэтому ждал этого с большим нетерпением.", @"As you know*, we don't have many in Paris, so I was looking forward to it very much."),
            (@"Я целиком был доволен им. Игра актеров, пение и костюмы были такие профессиональные!",@"I thoroughly enjoyed it. The acting, the singing and the costumes were all so professional!"),
            (@"Покидание театра было похоже на (попадание) в другой мир.",@"Leaving* the theater was like coming* out into another world."),
            (@"Я съел поздний ужин, на этот раз в превосходном китайском ресторане.",@"I had a late supper, this time in an excellent Chinese restaurant."),
            (@"На следующий день я собрал свои сумки и [свои] сувениры,",@"The next day, I packed my bags and my souvenirs,"),
            (@"сказал всем ""До свиданья"" и поехал на вокзал.", @"said goodbye to everybody and strolled to the station."),
            (@"Обратная дорога была менее приятной. Я был несчастлив, (поскольку) выезжал,", @"The journey back was less pleasant. I was unhappy to leave"),
            (@"и канал (воды канала) в этот день был неспокойным.",@"and the Channel was very rough   that day,"),
            (@"Если ты находишься на (обычном) корабле на неспокойном море, тебя укачивает,", @"If you are in a boat on a rough sea, you roll;"),
            (@"а на корабле на воздушной подушке летаешь вверх и вниз как в лифте.",@"but in a hovercraft you go up and down as   in a lift."),
            (@"Многие люди были больны, поэтому я выпил (большую порцию) бренди, чтобы подбодриться.",@"Several people were sick, so I had a large brandy to strengthen myself."),
        };

        public override string[] Notes => new[]
        {
            (@"[Rate] - ставка, цена, курс (валюты). [The rate of exchange] - обменный курс."),
            (@"[Rough] - неровный, шершавый, неотделанный, необработанный. [А rough copy] - черновик. "),
            (@"Сравнивая действия, используем слово [as] - как. [Не  changes cars as I change my socks] - Он сменяет машины (так часто), как я сменяю носки. Сравнивая вещи,  используем слово [like] - как. [This meat is like rubber] - Это мясо как резина. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я была в плохом настроении, потому что должна была уезжать.", @"I was in a bad mood because I had to leave."),
            (@"Эти сувениры напоминают мне о моем пребывании в Европе.",@"These souvenirs remind me of my stay in Europe."),
            (@"Это был такой неспокойный день, что корабль качало.",@"It was such a rough day that the ship was rolling."),
            (@"Это было бы забавно - купить шляпу-котелок.",@"It would have been amusing to buy a bowler hat."),
            (@"На протяжении всего мюзикла была прекрасная игра.",@"Throughout the musical, the action was superb."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Она не любит плавать на корабле во время плохой погоды.", "She doesn't [like taking ] the boat [in bad/rough] weather. "),
            ( "3a день до отъезда я был в плохом настроении. ", "They day [before ] I [left ], I was in a very [bad mood]."),
            ( "Обратная дорога всегда более грустная. Вы согласны?", "The [journey back ] is always [sadder ]. Do you [agree]?"),
            ( "Ты плыл на корабле на воздушной подушке! Как это выглядит?", "You've [taken ] the hovercraft! What's [it like]?"),
            ( "Я не переношу мюзиклов. - Я тоже [ни я]. ", "I can't [stand musicals]. - Neither [can I]."),
        };
    }
}
