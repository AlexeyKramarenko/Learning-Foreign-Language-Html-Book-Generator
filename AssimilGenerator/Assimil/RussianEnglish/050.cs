using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_50 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Мы вчера хорошо [тяжело] поработали, а сегодня должны познакомиться с чем-то новым [посмотреть на что-то новое].",@"We worked hard   yesterday, and today we must @ look at something new."),
            (@"Вы видели материал урока и слышали компакт-дисковые либо магнитофонные записи, и сейчас (уже) готовы (к тому, чтобы) научиться прошедшему времени.",@"You looked at the lesson and listened to the records (or tapes), so now you are ready to learn the past tense."),
            (@"Это очень просто. Вы прибавляете ""ed"" к инфинитиву, если он заканчивается на согласную букву; ",@"It is very simple. You add ""ed"" to the infinitive if it ends in a consonant; "),
            (@"и просто ""d"" к инфинитиву, заканчивающемуся на гласную букву.",@"and simply   ""-d"" to the infinitive ending in “e”"),
            (@"Например: смотреть, я смотрел; работать, я работал.",@"For example: to look, I looked; to work, he worked;"),
            (@"любить, он любил\ улыбаться, мы улыбались,",@"To like, they liked; to smile, we smiled"),
            (@"Конечно же, существует небольшое количество неправильных глаголов, но и они не слишком сложны.",@"There are, of course, some irregular verbs, but they are not too complicated."),
            (@"Посмотрим на наших старых знакомых быть и иметь,",@"Let's look at our old friends '4o be'' and ""to have"","),
            (@"Глагол иметь - чрезвычайно прост. (В прошедшем времени) он используется в форме had- имел/а, ты имел/вы имели, он имел,",@"""To have"" is extremely simple. It becomes ""had"": you had, he had."),
            (@"Быть имеет две формы: я был/а, он был и ты был/вы были, они были,",@"""To be"" has two forms: I was, he was; and; you were, they were."),
            (@"Вы видите, как это просто!",@"You see how simple it is!"),
            (@"Мы ели ужин в семь часов, Джон и Питер там были.",@"We had dinner at eight o'clock, John and Peter were there."),
            (@"Я простудился на прошлой неделе и сильно заболел [был совершенно больным].",@"I had a cold last week and I was quite ill"),
            (@"Мы надеялись ее увидеть, но она была занята.",@"We hoped to see her but she was busy."),
        };

        public override string[] Notes => new[]
        {
            (@"[Hard] - твердый, крепкий, сильный, трудный, тяжелый. Предложение [Не worked hard] можно перевести Он тяжело работал. "),
            (@"[We must] - мы должны. Глагол [must] относится к числу модальных, таких как [сап, may, need]. "),
            (@"[Simply] - просто, легко. "),
            (@"Окончания [-ed, -d] произносятся как [t], если прибавляем их к глаголу, заканчивающемуся на глухую согласную за исключением [t]; как [d], если прибавляем к глаголу, заканчивающемуся на гласную или звонкую согласную за исключением [d], и, наконец, как [id], если прибавляем к глаголу, заканчивающемуся на [d] или [t]. "),
            (@"Вспомним, что [to have dinner] значит есть ужин, а [to have а cold] (предложение 13) - быть простуженным. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он должен научиться быть более вежливым,",@"He must learn to be more polite."),
            (@"Мы оба были готовы в семь часов,",@"We were both ready at seven o'clock."),
            (@"но никого не было дома, когда мы позвонили.",@"but nobody was at home when we called."),
            (@"Они закончили с едой [принятие пищи] и пошли спать.",@"They finished their meal and went to bed."),
            (@"Видишь, как это просто!",@"You see how simple it is!"),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Когда он закончил, он закрыл книгу и закурил трубку.", "When he had finished, he [closed ] the book and [smoked] a pipe."),
            ( "Было четыре часа, когда он приехал. Он опоздал. ", "It [was ] four [o'clock ] when he [arrived ]. He [was late]."),
            ( "Она простыла и была очень больна. ", "She [had ] а cold and [was quite] ill."),
            ( "Каждый раз когда я хотел работать, он мне мешал. ", "Every time I [wanted ] to [work ], he disturbed [me]."),
            ( "Когда мы были молодыми, у нас бьию больше времени. ", "When we [were ] young, we [had more] time."),
        };
    }
}
