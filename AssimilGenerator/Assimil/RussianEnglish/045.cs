using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_45 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид и Джоэн разговаривают о своих планах.",@"David and Joan are discussing their plans."),
            (@" Я думаю, что мы поедем в Брайтон на следующий уикэнд.",@"I think we'll go to Brighton next week-end."),
            (@"А почему? Там нечего делать в такое время года.",@"But why? There's nothing to do at this time of the year."),
            (@"Я знаю, но смотри, - если будет хорошая погода, мы можем поехать влолъ берега.",@"I know, but look - if the weather is fine, we can drive along the coast"),
            (@"и посмотреть все эти маленькие деревушки.",@"and visit all those little villages."),
            (@"Да, но Дэвид, а... Моя мать приезжает в следующий уикэнд.",@"Yes, but David, er... My mother's coming next weekend."),
            (@"Проклятие! <br/> - Но ведь она приезжает только раз в год!",@"Damn! <br/> - But she only comes once a year!"),
            (@"Да, и всегда тогда, когда мы хотим уехать.",@"Yes, and it's always when we want to go away."),
            (@"Ты имеешь в виду: когда ты хочешь уехать.",@"You mean: when you want to go away."),
            (@"Извини. - Она приезжает в пятницу.",@"I'm sorry. - She's arriving on Friday."),
            (@"Тогда давай возьмем ее с собой и посмотрим [посетим] все магазины антиквариата.",@"Then we'll take her with us and visit the antique shops"),
            (@"Она будет чувствовать себя как дома среди этих старых предметов.",@"She'll feel at home among all those old things."),
            (@"Дэвид! Не будь таким вредным!",@"David! Don't be nasty!"),
            (@"Я встречу ее на станции, тогда мы сможем вместе что-нибудь запланировать.",@"I'll meet her at the station, then we'll be able to make our plans together."),
        };

        public override string[] Notes => new[]
        {
            (@"[At this time of the year] - имеет значение в такое [это] время года. "),
            (@"[To mean] - означать. [You mean] - имеешь в виду. "),
            (@"[Antique shops] - это одновременно магазин антиквариата и букинистический магазин."),
            (@"В будущем времени вместо глагола сап употребляется выражение [to be able to] - быть в состоянии, мочь. [I саn help you] - могу тебе помочь. [I'll be able to help you] - Я смогу тебе помочь. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[] 
        {
            (@"Если ты придешь завтра, сможешь нам помочь.",@"If you come tomorrow, you will be able to help us."),
            (@"Джон в Лондоне чувствует себя как дома.",@"John feels at home in London."),
            (@"Ты сможешь одолжить мне 5 фунтов?",@"Will you be able to lend me five pounds?"),
            (@"Все эти люди - мои друзья.",@"All those people are friends of mine."),
            (@"Я у него спрошу в следующий раз, когда его увижу.",@"I will ask him the next time I see him."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[] 
        {
            ( "Джоэн, не будь вредной! Она на самом деле очень симпатичная.", "Joan, don't [be nasty ]! She is [realy ] very [nice]."), 
            ( "Проклятие! Она приезэюает в семь, а машина все еще в авторемонтной мастерской.", "Damn! She [is aniving at] seven and the car [is still at ] the [garage]."), 
            ( "Она будет чувствовать себя как дома со всем этим антиквариатом.", "Не [will feel ] at [home ] with [all ] those [antiques]."), 
            ( "В это время года мы всегда на каникулах. ", "At [this time of the year ], we are [always] on holiday."), 
            ( "Она приезэюает только раз в год. Мне вдвойне жаль. ", "She [only ] comes [once a] year. I'm [sorry], [twice]. "), 
        };
    }
}
