using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_40 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Могу ли я вам чем-то помочь? -Да, я ищу...", @"Can I help you? - Yes, I'm looking for..,"),
            (@"Пожалуйста, присаживайся. Ты выглядишь уставшей/им.",@"Please sit down. You looked (i) tired."),
            (@"(Хочешь пить/выпить?) Что ты будешь пить?",@"Have a drink. What will you have?"),
            (@"Можете ли указать мне дорогу в центр города?",@"Can you tell me the way to the town centre?"),
            (@"Лондон больше Парижа, но меньше Нью- Йорка.  ",@"London is larger than Paris but smaller than New York."),
            (@"Войдите, пожалуйста. Чувствуйте себя как дома.",@"Please come in. Make yourself at home."),
            (@"Извините, повторите [скажите] это еще раз.",@"Sorry, say that again."),
            (@"Я не люблю свеклы. - Нет, я тоже (не люблю).",@"I don't like beetroot. - No, neither do I."),
            (@"Можешь ли сделать (это) лучше, чем то?",@"Can't you do better than that?"),
            (@"Этот урок более интересный, чем первый.",@"This lesson is more interesting than the first one."),
            (@"Не могу еще бегло говорить по-английски, но понимаю вполне хорошо.",@"I can't speak English fluently yet, but I can understand quite well."),
            (@"Пожалуйста, говори немного медленнее. Спасибо.",@"Please speak a little slower. Thanks."),
            (@"Как далеко от Лондона до Эдинбурга?",@"How far is it from London to Edinburgh?"),
            (@"Он не будет разговаривать с тобой, он в плохом настроении.", @"He won't speak to you, he's in a bad mood."),
        };

        public override string[] Notes => new[]
        {
            (@"<b>То look</b> - по/смотреть, <b>to look at</b> - смотреть на что-либо, <b>to look for</b> - искать. "),
            (@"<b>Neither... nor</b> - ни.., ни. <b>Neither John nor Peter speaks English</b> -Ни Джон, ни Питер не говорят по-английски. Neither do I - ни (также) л; <b>neither does she/he</b> - ни (также) она/он. Сравни either... or - урок 31, объяснение (з). "),
            (@"<b>Won't</b> является сокращенной формой <b>will not</b>. При отрицании в предложениях будущего времени <b>not</b> ставится после <b>will. Не won't come</b> - он не придет. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Нет, сэр, боюсь, что его нет.", @"No, sir, I'm afraid he's not in. Can you come back tomorrow?"),
            (@"Вы можете вернуться завтра?",@"Can you come back tomorrow?"),
            (@"Я не люблю кофе по-турецки. - Я тоже.",@"I like Turkish coffee. - So do I."),
            (@"К сожалению, нет билетов на субботу.",@"Unfortunately, there are no tickets for Saturday."),
            (@"Мы собираемся встретиться с Питом. Как далеко отсюда он живет?",@"We're going to see Pete. How far from here does he live?"),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я не хочу ехать в Грецию в сентябре. -Я тоже. ", "I [don't want to] to go Greece [in] September. - [Neither] do I."),
            ( "Она говорит бегло по-английски, но не по-немецки. ", "She speaks English [fluently] but [no German]."),
            ( "Обычно он ездит на работу на машине.", "[Usually], he [drives] to work."),
            ( "К сожалению, мы идем к моей матери на обед.", "[Unfortunately], we are [going] to my [mother's] for dinner."),
        };
    }
}
