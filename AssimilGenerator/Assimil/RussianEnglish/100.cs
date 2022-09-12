using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_100 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Это наш сотый урок. Если вы уделили, включая повторения, в среднем около получаса",@"This is our hundredth lesson.  If you have spent* an average of half an hour, revision included,"),
            (@"каждому из предыдущих уроков, то в сумме [это дает] (занимались) почти пятьдесят часов.",@"on each of the preceding ones, it makes* a total   of nearly fifty hours."),
            (@"Довольны ли вы результатами своей работы?",@"Are you pleased with the result of your work?"),
            (@"Конечно же, вы не знаете на память каждое слово и каждое выражение, которые нам  встречались: это было бы верхом совершенства [слишком совершенно].",@"Obviously, you do not know* by heart  every  word and every expression we have seen: that would be too perfect."),
            (@"Изучение иностранного языка-это вопрос терпения, регулярного ежедневного повторения - и оптимизма.", @"Learning* a foreign language is a matter of patience, regular daily repetition - and optimism."),
            (@"Кто-то когда-то сказал, что английский язык как Гора Эверест:",@"Somebody once said that English was  like Mount Everest:"),
            (@"поскольку подход легок, а вершину покорить невозможно.",@"because access is easy, but the summit is impossible to reach."),
            (@"Мы считаем, что это не так, потому что никто не владеет [говорит] своим собственным языком в совершенстве.",@"We think* this is wrong because nobody speaks* his own language perfectly."),
            (@"Вы должны пробовать - посредством регулярных упражнений - взобраться так высоко, как хотите, пока не почувствуете себя хорошо.",@"You must try, by regular practice, to climb as high as you want, until you feel comfortable"),
            (@"Но будьте осторожны! Для того, чтобы не упасть, вы должны упражняться так часто, как это (только) возможно.",@"But be careful. In order not to fall* , you must practise as often as possible."),
            (@"Вы будете учить новые слова и выражения и забывать их, учить их снова и забывать еще раз.",@"You will learn new words and expressions and forget* them, and learn them again and forget them once more."),
            (@"A вы (ведь) делаете успехи. Сравните то, что вы знаете сейчас, с тем, что знали три месяца назад.",@"But you are making* progress. Compare what you know* now with what you knew* three months ago."),
            (@"Самая тяжелая и скучная часть вашей работы уже сделана, скоро вы будете говорить бегло.",@"The hardest and most tedious part of your work is done; before long , you will speak* fluently."),
            (@"Но помните: для того, чтобы удержаться на высоте [остаться на горе], вы нуждаетесь в ежедневных занятиях.",@"But remember: in order to stay on the mountain, you need daily practice."),
        };

        public override string[] Notes => new[]
        {
            (@"[It makes а total of] - это дает в сумме [total] - целый, полный, общая квота, сумма. "),
            (@"[To know by heart] - знать на память. "),
            (@"[Every] - каждый, всякий; [each] - каждый (отдельно). "),
            (@"[Matter] - материя, вещество; [to be а matter of] - здесь: это вопрос. [It's matter of time] - Это вопрос времени, это требует времени. Знаем также обороты: [what's the matter?] - в чем дело? и [it doesn't matter] - не имеет значения. "),
            (@"Припомним последовательность времен, которые выступают в этом предложении - см. урок 88 (з). Несмотря на то, что во второй части предложения используется прошедшее время, в последовательности времен оно выражает действие настоящее, и таковым должно быть представлено в переводе. "),
            (@"[Comfortable] - удобный, комфортабельный, приятный. [То  feel comfortable] - чувствовать себя хорошо. "),
            (@"[In order to] - для того, чтобы; [in order not to] - для того, чтобы не; [аn order] - приказ, команда, указание, порядок;  [to order] - приказывать. "),
            (@"[Before long] - скоро. "),
            (@"[Too many cooks spoil the broth] дословно значит ""слишком много кухарок портят суп"", русская же версия этой пословицы это: У семи нянек дитя без глазу."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Нельзя выучить всех слов на память.",@"You cannot learn all the vocabulary by heart."),
            (@"Никто здесь не говорит по-китайски.",@"Nobody here speaks Chinese."),
            (@"Сядь на диван. Тебе удобно?",@"Sit down on the sofa. Are you comfortable?"),
            (@"Ты должен работать для того, чтобы зарабатывать деньги.",@"You must work in order to earn money."),
            (@"Будь осторожным, чтобы не упасть.  Эта стена очень высока.",@"Be careful not to fall. That wall is very high."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Пока не сможешь бегло говорить по-английски, читай понемногу каждый день,", "[Until ] you [can ] speak English [fluently ], read [some every] day."),
            ( "Ешь так много, сколько хочешь [как хочешь]; есть больше.", "Eat [as much as ] you want; [there is more]."),
            ( "Ты должен быть очень осторожным, чтобы не упасть.", "You [must ] be very [careful ] in [order not to] fall."),
            ( "Я очень доволен работой моего сына. ", "I am very [pleased with ] my [son's work]."),
            ( "Он, может быть, не прав, но я так не думаю. ", "Не [might be wrong ], but I [don't think] so."),
        };
    }
}
