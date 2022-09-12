using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_47 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Англичанин и француз разговаривают о своих странах.",@"An Englishman and a Frenchman are discussing their respective © countries."),
            (@"Конечно, говорит англичанин, вы, французы, не джентльмены.",@"Of course, says the Englihshman, you Frenchmen are not gentlemen."),
            (@"А почему нет? отвечает его друг, немножко рассерженный.",@"And why not? replies his friend, slightly annoyed"),
            (@"Итак, если, например, вы по ошибке войдете в ванную комнату,",@"Well, for example, if you enter a bathroom by mistake"),
            (@"и увидите молодую моющуюся даму, что вы cкажете?",@"and you see a young lady washing, what do you say?"),
            (@"Мы говорим: ""Извините, госпожа"".",@"We say ""Excuse me, madam""."),
            (@"Вот именно, говорит англичанин, джентльмен скажет: ""Извините, господин"".",@"Exactly, says the Englishman, but a gentleman says: ""Excuse me, sir."""),
            (@"Джентльмен - это человек способный на две вещи:",@"A gentleman is a person capable of two things:"),
            (@"Он может описать красивую девушку без жестов",@"He can describe a pretty girl without using gestures,"),
            (@"и всегда слышит смешную историю впервые.",@"and he always hears a funny story for the first time."),
            (@"Два английских джентльмена едят [блюдо] в своем клубе.",@"Two English gentlemen are eating a meal in their club."),
            (@"Они пробуют суп с большим интересом, и один говорит другому:",@"They taste the soup with great interest, and one says to the other:"),
            (@"Это интересный суп, но не замечательный [суп].",@"It's an interesting soup, but not a great soup."),
        };

        public override string[] Notes => new[]
        {
            (@"[Respective] - индивидуальный, отдельный; здесь: свой "),
            (@"[Light] - легкий, свет; [slight] - мелкий, маленький; [slightly] - легко, незначительно; [slightly annoyed] - немножко раздраженный, рассерженный. "),
            (@"[By mistake] - по ошибке, не нарочно; [On purpose] - нарочно. "),
            (@"[То be capable of] - быть способным на что-либо. "),
            (@"[То taste] - пробовать. [Taste] - вкус. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Вы, англичане, плохо питаетесь.",@"You Englishmen eat badly."),
            (@"Он не хочет прийти. Почему?",@"He doesn't want to come. Why not?"),
            (@"Эта машина способна на многое [на многие вещи].",@"This machine is capable of many things."),
            (@"Он говорит по-английски без ошибок.", @"He speaks English without making mistakes."),
            (@"Я всегда беру его сумку по ошибке.",@"I always take his bag by mistake."),
            (@"Его друг критикует его и он немножко сердится [обеспокоен].",@"His friend is criticising him and he is slightly annoyed."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Они разговаривают о своих странах с большим интересом.", "[They are ] discussing [their ] respective countries with [great] interest."),
            ( "Когда ты no ошибке входишь на кухню, что ты говоришь?", "If you [enter ] the [kitchen ] by [mistake ], what [do you say]?"),
            ( "Oh может описать красивую девушку без употребления жестикуляции.", "Не [can describe ] а [pretty ] girl without [using gestures]."),
            ( "Я виснсу двух дэюентлъменов, которые едят свой суп. ", "I [can see ] two gentlemen [eating their] soup."),
            ( "Пожалуйста, попробуй это вино и скажи мне, что ты об этом думаешь?", "[Please ] taste [this] wine and [tell me] what you [think] of it."),
        };
    }
}
