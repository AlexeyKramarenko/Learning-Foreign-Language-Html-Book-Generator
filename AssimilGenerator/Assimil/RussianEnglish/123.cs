using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_123 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вы обратили внимание, что ежедневно [каждый день] вы заучиваете новые слова и выражения?",@"Have you noticed that every day you are learning new words and expressions?"),
            (@"Вы теперь можете вести беседу, читать сообщения, спрашивать дорогу, - даже спорить с кем-нибудь!",@"You can now hold* conversations, read* notices, ask your way - even argue with someone!"),
            (@"Мы должны продолжать ежедневное изучение [добавление] нового материала",@"We must continue to add new material every day,"),
            (@"так, чтобы в конце курса вы могли понимать английский язык таким, как тот на каком разговаривают (сами) англичане.",@"so that, at the end of the course, you will be able to understand* English as it is spoken* by the English."),
            (@"Мы надеемся, что вы находите время для повторения предыдущих уроков и, прежде всего, делаете это вслух.", @"We hope that you find* time to revise the past lessons, and that, above alJ, you do it aloud."),
            (@"Это обязательно, так как помогает вам запоминать и улучшает ваше произношение.",@"This is vital, because it helps you to remember and to improve your pronunciation."),
            (@"У вас всегда будет незначительный акцент,",@"You will always have a slight accent,"),
            (@"но не беспокойтесь, люди смогут вас понять, что самое важное.",@"but don't worry: people will be able to understand you, which is most important."),
            (@"Кроме того, незначительный иностранный акцент очарователен.",@"And, besides, a slight foreign accent is charming."),
            (@"Существуют определенные выражения, которые нельзя перевести,",@"There are certain expressions which you cannot really translate,"),
            (@"поэтому вы можете произнести их на своем собственном языке, и люди скажут: «Как очаровательно!»", @"so you can say them in your own language and people will say: ""How charmingl"""), (@"Поэтому повторяйте и читайте вслух каждый день как можно больше [так много, как вы можете].",@"So revise and read* aloud every day as much as you can."),
            (@"Вы убедитесь [найдете], что ваш английский становится все более естественным.",@"You will find* that your English is becoming* more and more natural."),
        };

        public override string[] Notes => new[]
        {
            (@"[То get on] - продвигаться вперед, иметь/делать успехи.  [How are you getting on?] - Как дела?/Как успехи? "),
            (@"[То hold conversations] - вести разговор, разговаривать. "),
            (@"[Aloud] - вслух; [loud] - громкий; [speak louder] - говори  громче; [loudspeaker] - динамик, колонка. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Могу ли я помочь тебе в твоей домашней работе. Нет, спасибо.",@"Let me help you with your homework.  - No thank you."),
            (@"Знание английского [говорить по-английски] становится все более необходимым.",@"It is becoming more and more vital to speak English."),
            (@"Позволь мне представить Дэвида Хайда. Рад с Вами познакомиться.",@"Let me introduce David Hide.  - Pleased to meet you."),
            (@"Прежде всего, не забудь забрать свой зонтик.",@"Above all, don't forget to take your umbrella."),
            (@"Ты обратил внимание на ее новое платье?",@"Did you notice her new dress?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Его английский становится все более естественным. Скоро он сможет свободно разговаривать.", "His English is [becoming more ] and [more ] natural. Soon he [will be able to] speak fluently."),
            ( "У тебя незначительный акцент, но не беспокойся. Тебя поймут.", "You have а [slight ] accent, but [don't worry ]. You will [be understood]."),
            ( "Люди в Англии редко пожимают друг другу руку. Это делается только один раз.", "People rarely [shake hands ] in England. It is done [once] only."),
            ( "Читай как можно больше. Чтение очень важно. ", "Read as [much as you ] can. [Reading] is extremely important."),
            ( "Прежде всего, говори как можно чаще. ", "[Above all ] speak [as ] often [as ] possible."),
        };
    }
}
