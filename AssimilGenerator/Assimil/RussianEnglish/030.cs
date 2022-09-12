using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_30 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Здравствуй, Джоэн, Дэвид дома [в (доме)]?",@"Hello, Joan, is David in?"),
            (@"Нет, боюсь, что нет. Его еще нет дома.",@"No, I'm afraid not. He isn't home yet."),
            (@"Он все еще работает?",@"Is he still working ?"),
            (@"Да. Иногда работает до девяти.",@"Yes; Sometimes he works until nine."),
            (@"Ну, что ж [хорошо]. Я не могу ждать.",@"Oh well, I can't wait."),
            (@"Скажи (передай) ему, что вечером в пабе состоится игра [матч] в ""дротики"".",@"Tell him there's a darts match ® at the pub tonight."),
            (@"Во сколько? - Около половины девятого.",@"What time? - About half-past eight."),
            (@"Если он вернётся вовремя, я передам ему.",@"If he's back in time, I'll tell him."),
            (@"Спасибо. Пока, Джоэн. - Пока, Пит.",@"Thanks. Bye Joan. - Good-bye Pete."),
            (@"Поторопись! Я еще не готова.",@"Hurry up! I'm not ready yet."),
            (@"Ты все еще ждешь замужества с миллионером?",@"Are you still waiting to marry a millionaire?"),
            (@"Он всегда просит деньги, а у меня никогда их нет [я никогда не имею никаких],",@"He always asks for money and I never have any."),
            (@"Я все еще помню несколько слов по-немецки.", @"I can still remember a few words of German."),
            (@"Скажи ему о матче, когда он придет.",@"Tell him about the match when he comes in."),
        };

        public override string[] Notes => new[]
        {
            (@"[А darts match] - игра [матч] в дротики - малопопулярная в России игра: бросание дротиков в пдит. "),
            (@"[In time] - вовремя; [on time] - пунктуально. "),
            (@"[I'll tell him] - предложение в будущем времени -Я скажу ему. [I'll] - сокращенная форма [will], после которой глагол ^ ставится без частицы [to]. [Will] употребляется во всех лицах и выступает без окончаний- "),
            (@"[То remember] значит помнить, [to remind] - напомнить, напоминать. "),
            (@"Хотя после [when] глагольная форма будущего времени здесь не фигурирует, на русский язык это предложение переводим: [when he comes] - когда он придет.")
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Ваш муж дома, миссис Вильсон?",@"Is your husband in, Mrs Wilson?"),
            (@"Она все еще ждет тебя на вокзале.",@"She is still waiting for you at the station,"),
            (@"Он всегда возвращается в девять (часов).",@"He is always back at nine o'clock."),
            (@"Когда он возвращается, он часто (бывает) уставший.",@"When he comes in he is often tired."),
            (@"Иди до конца улицы и поверни налево.",@"Walk to the end of the road and turn left."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн всегда очень занят и у него никогда нет свободного времени.", "Не is [always ] very [busy ] and [never ] has [any] free time. "),
            ( "Вы не можете войти, он еще разговаривает по телефону.", "You can't [go in ] sir, he is [still on] the phone."),
            ( "Она еще не вернулась. ", "She isn't [back yet]."),
            ( "Когда он возвратите я, спрошу его. ", "When he [comes back (in)]. I will ask him."),
            ( "Focпoжa еще не готова. Можете подождать ее здесь.", "Madam is not [ready yet ]. You can [waft for] her here. "),
        };
    }
}
