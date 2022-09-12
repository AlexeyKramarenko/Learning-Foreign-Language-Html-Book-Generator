using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_90 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Шотландец, который однажды ночью ехал домой, столкнулся с машиной, которую вел англичанин.",@"A Scotsman who was driving* home one night ran* into a car driven* by an Englishman."),
            (@"Шотландец вылез из автомобиля, чтобы попросить извинения и предложил англичанину [напиток] (выпить) из бутылки виски.",@"The Scot got* out of the car to apologise and offered the Englishman a drink from a bottle of whisky."), (@"Англичанин обрадовался возможности выпить.",@"The Englishman was glad to have a drink."),
            (@"(Давай еще) [продолжай], - сказал шотландец, - выпей еще один глоток.",@" - Go on, said the Scot, have another drink."),
            (@"Англичанин с благодарностью выпил, - А ты разве не хочешь разок (глотнуть)? - спросил он шотландца.",@"The Englishman drank* gratefully .— But don't you want one? he asked the Scot."),
            (@"Может быть, - ответил тот, - когда уедет полиция.",@"Perhaps, the other replied, when the police have gone. "),
            (@"Сторож парка наткнулся на бездомного, который спал на лавке в Грин-парке.",@"The park keeper walked up to a tramp who was sleeping* on a bench in Green Park."),
            (@"Эй, ты! - крикнул он, - я собираюсь закрыть ворота парка.",@" - Hey! You! he shouted, I'm going to shut* the park gates!"),
            (@"Хорошо [все в порядке], - ответил бездомный, - постарайся ими не хлопать.",@"- All right, replied the tramp, try not to slam them. "),
            (@"Когда миссис Дэвис сказала своему мужу, что этим вечером гости приходят на ужин,",@"When Mrs Davis told* her husband that guests were coming* to dinner that night,"),
            (@"он пошел в коридор и спрятал все зонты.",@"he went* out into the hall and hid* all the umbrellas."),
            (@"Что случилось? - спросила жена, ты боишься, что их кто-то украдет?",@" - What's the matter? asked his wife, are you afraid someone will steal* them?"),
            (@"Нет [это не так], - ответил муж, - но я опасаюсь, что кто-нибудь их опознает.",@"- It's not that, replied her husband, but I'm afraid someone might recognise them. "),
            (@"Нет, но постарайтесь не хлопать им.",@"No, but try not to slam it."),
            (@"(Тут) не хватит виски для нас обоих.",@"There isn't enough whisky for both of us."),
            (@"Он был очень рад снова меня видеть после такого (долгого перерыва) [времени].",@"He was very glad to see me again after all this time."),
            (@"Он берег эту бутылку виски целый год, прежде чем открыть ее.",@"He kept that bottle of whisky for a year before opening it."),
        };

        public override string[] Notes => new[]
        {
            (@"[То run, ran, run] - бежать, бегать. [То run into] -  налетать, наталкиваться; [to run out of] - истощить  запас, закончиться: [We've run out of petrol] - У нас закончился бензин. "),
            (@"[То be glad] - радоваться, быть довольным. [Glad to see you] - Я рад вас видеть. "),
            (@"[Gratefully] - с благодарностью. [То be grateful] - быть   благодарным. "),
            (@"[Try not to ...] - попробуй не ...""I told him not to use my car"" - Я сказала ему, чтобы не брал моего автомобиля [не пользовался (им)]. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Вы не будете возражать, если я закрою окно? Мне холодно. ", @"Do you mind if I shut the window? I'm cold. "),
            (@"Нет, но постарайтесь не хлопать им. ",@"No, but try not to slam it. "),
            (@"(Тут) не хватит виски для нас обоих. ",@"There isn't enough whisky for both of us. "),
            (@"Он был очень рад снова меня видеть после такого (долгого перерыва) [времени]. ",@"He was very glad to see me again after all this time. "),
            (@"Он берег эту бутылку виски целый год, прежде чем открыть ее. ",@"He kept that bottle of whisky for a year before opening it. "),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Это (вполне) возможно, что он работает в книжном магазине, но я не (в этом) не уверен.", "Не [might work ] in а [book ]-[ shop] but [I'm not sure]."),
            ( "Moжeт пойти дождь, лучше возьмем [наши] зонты. ", "[It might ] rain, we [had better ] take [our umbrellas]."),
            ( "Он пытается не делать никаких ошибок, но для него это слишком трудно.", "Не tries [not to make ] any [mistakes ] but [it's ] too difficult [for him]."),
            ( "Она была очень благодарна ему за [его] помошь, (оказанную ей тогда,) когда у нее были [она имела] проблемы.", "[She was ] very [grateful ] for [his (her) ] help when [she had] problems."),
            ( "Так трудно не смеяться, она такая смешная. ", "[It is so ] difficult [not to ] laugh, [she is so] funny."),
        };
    }
}
