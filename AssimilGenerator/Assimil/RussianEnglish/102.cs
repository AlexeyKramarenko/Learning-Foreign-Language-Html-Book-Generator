using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_102 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Снаружи художественной галереи: - Мне очень понравилась эта выставка,", @"Outside the art gallery: -I liked that exhibition very much,"),
            (@"особенно современная картина (изображающая) человека на коне.", @"especially the modem painting of a man on a horse."),
            (@"Откуда ты знаешь, что это был человек на коне?",@"How do you know* it was a man on a horse?"),
            (@"Ну, это (ведь) было очевидно, разве нет?",@"Well, it was obvious, wasn't it?"),
            (@"В таком случае это не могла быть современная картина.",@"In that case, it couldn't have been a modem painting."),
            (@"Мать только что отругала своего сына и он начал плакать.",@"A mother had just scolded her son and he started crying."),
            (@"В этот момент вошел отец.",@"At that moment, his father came* in."),
            (@"Что с тобой [происходит]? - спросил он.",@" - What's the matter with you?  he asked."),
            (@"Ребенок отвернулся и ничего не сказал.",@"The child turned his back and said nothing."),
            (@"Иди (сюда), - сказал [его] отец, - расскажи папе.",@"""Come on!"" said his father, ""tell Daddy."""),
            (@"Ребенок обернулся:", @"The son turned round:"),
            (@"- Если ты так уже хочешь знать, то я только что поругался с твоей женой.",@"""If you must know, I've just had an argument  with your wife!"""),
            (@"Работодатель: - Мы ищем кого-то, кто привык управлять людьми.",@"Employer, - We're looking for someone who is used to ordering men."),
            (@"Мужчина: - В таком случае вам нужна [вы хотите] моя жена.",@"Man. - In that case, you want my wife."),
            (@"Не забывайте время от времени изучать неправильные глаголы [несколько неправильных глаголов].",@"Do not forget* to learn a few irregular verbs from time to time."),
        };

        public override string[] Notes => new[]
        {
            (@"[It couldn't have been] переводим как [Этого] не могло быть. "),
            (@"[То scold] - бранить, ругать, распекать. "),
            (@"[То have an argument] - ругаться, ссориться; [an argument] - брань, ругань у ссора. "),
            (@"[То be used to] - быть привычным к чему-л., иметь привычку. [He's used to working hard] - Он привык к тялсеяой работе. В этой конструкции выступает глагол с окончанием -ing, как и в обороте [to look forward to]. "),
            (@"Пословица [One man's meat is another man's poison] - Мясо одного человека является отравой для другого имеет значение: То, что хорошо одному, плохо другому. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Это мог бы быть Дэвид, но я не уверен.",@"It could have been David, but I'm not sure."),
            (@"Я только что позавтракал [закончил завтрак], поэтому не голоден.",@"I've just finished breakfast so I'm not hungry."),
            (@"Сколько eй было [исполнилось] лет на последнем дне рожденья? Я не люблю спрашивать.",@"How old was she on her last birthday ?  I don't like to ask."),
            (@"Я слышал симфонию Моцарта по радио.",@"I heard a symphony by Mozart on the radio."),
            (@"Что с тобой [происходит]?  Боюсь, что я простыл.",@"What's the matter with you ? - I'm afraid I've got a cold."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Она как раз закончила разговаривать, когда зазвонил телефон.", "She [had just finished ] speaking [when ] the phone [rang]."),
            ( "He переживай, я привык ездить по правой стороне. ", "Don't [worry ], I [am used to ] driving [on the right]."),
            ( "Он делал снимки для книги, которую (сам) [он] написал.", "Не [was taking ] photos [for ] а book he [had written]."),
            ( "Я думала, что он писатель-романист. - (Это) совсем не так. Он фотограф.", "I [thought ] he was, [ a ] novelist. - [Not at ] all, [he's a  ] photographer."),
            ( "Это не могло бы ничего изменить. ", "That [could not have ] changed [anything]."),
        };
    }
}
