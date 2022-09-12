using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_87 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@" Я должен тебе рассказать о своем отпуске!",@"I  must tell* you about my holiday!"),
            (@"В конце концов, мы должны были поехать во Францию. Нигде в Испании мы не могли найти гостиницу.",@"Eventually, we had to go* to France. We couldn't get* a hotel   anywhere in Spain."),
            (@"Ты был когда-нибудь во Франции? Нет? Ты должен поехать туда когда-нибудь, она очень привлекательна,",@"Have you ever been to France? No? You should go* there some day, it's fascinating."),
            (@"Мы не могли купить билеты на чартерный рейс, пришлось полететь нормальным рейсом, который дороже [дорогой],",@"We couldn't get* a charter, so we had to take* a normal flight, which was expensive,"),
            (@"но это того стоило [стоило той цены]: было намного удобнее.",@"but it was worth   it, it was much more comfortable."),
            (@"Мне скоро нужно будет начать планировать свой отпуск. Мы говорим об этом испокон веков.",@"I should start planning my holidays soon. We have been talking about them for ages."),
            (@"Во всяком случае, мы полетели в Ниццу и провели десять дней на юге Франции.",@"Anyway, we flew* to Nice and spent ten days in the South of France."),
            (@"Когда мы не могли найти гостиницу, мы жили в чем-то таком, что они называют «пансионатами».",@"When we couldn't find* a hotel, we stayed in what they call ""pensions""."),
            (@"Это то же, что «ночлег с завтраком» в Лондоне, но дороже.",@"They're like Bed and Breakfasts in London, but dearer."),
            (@"Потом мы полетели в Париж. Ты, наверное, знаешь Париж?",@"Then we flew* up to Paris. You must know* Paris?"),
            (@"Да, конечно, был там несколько раз.", @"Yes, actually I've been there a few times..."),
            (@"Стало быть, ты должен туда вернуться. Это привлекательный город и...", @"Well, you should go* back. It's an exciting city and it..."),
            (@"Я в самом деле должен сейчас идти. Джоэн будет меня ждать. Спасибо за беседу.",@"I really must go now, Joan will be waiting for me. Thanks for the chat."),
        };

        public override string[] Notes => new[]
        {
            (@"[Eventually] - в конце концов, окончательно. "),
            (@"[То get а hotel] - найти гостиницу, хотя буквальный перевод это получить гостиницу. "),
            (@"[То be worth] - быть стоящим, стоить чего-нибудь. "),
            (@"[Actually] - фактически, в самом деле, действительно, конечно. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Фактически, я его вообще не знаю.",@"Actually, I don't know him at all."),
            (@"Но я бы хотел с ним встретиться когда-нибудь.",@"But I'd love to meet him one day."),
            (@"Это было бы возможно?",@"Would that be possible?"),
            (@"Что мы бы могли сделать, чтобы решить этот вопрос?",@"What could we do to arrange it?"),
            (@"Как жаль! Он не смог прийти.",@"What a pity! He wasn’t able to come."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мы полетели в Ниццу, где взяли напрокат машину. ", "We [flew ] to Nice [where ] we [hired] a car."),
            ( "Она не могла себе позволить (купить) стиральную машину в прошлом году.", "She [couldn't afford] а washing machine [last] year."),
            ( "Когда я вернусь домой, она будет готовить. ", "When I [get back (go home)], she [will be] cooking."),
            ( "Ты должен меня послушать, это очень важнo. ", "You [must listen to me], it's very important."),
            ( "Даже если бы у нас было время, мы бы не смогли себе позволить пойти.", "[Even ] if we [had ] the time, we [couldn't afford] to go."),
        };
    }
}
