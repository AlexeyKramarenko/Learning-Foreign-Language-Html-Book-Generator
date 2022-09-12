using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_2 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Где вы?",@"Where are you?"),
            (@"Мы здесь, дома.",@"We're here, in the house."),
            (@"А где Джон?",@"But Where's John?"),
            (@"Он там, возле деревьев.",@"He's there, near the trees."),
            (@"Они дома, а Джона (там) нет. Он возле деревьев.",@"They're in the house, but John isn't. He's near the trees."),
            (@"Где мои сигареты? Они на столе?",@"Where are my cigarettes? Are they on the table?"),
            (@"Да, они (там). - А моя газета, где [есть] она?",@"Yes they are. - And my paper , where is it?"),
            (@"Она там, на стуле.",@"It's there, on the chair."),
            (@"Где моя газета? - Твоя газета там.",@"Where's my paper? - Your paper is there."),
            (@"Она около телевизора. Спасибо, вы очень любезны.",@"It's near the television. - Thank you. You're very kind."),
            (@"Где Джон? Где мои сигатеры?",@"Where's John? Where are my cigarettes?"),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он возле лома.",@"He's near the house."),
            (@"Где твои газеты?",@"Where are your papers?"),
            (@"Они на стуле.",@"They're on the chair."),
            (@"Это мои сигареты?",@"Are they my cigarettes?"),
            (@"Питер дома, а Джона нет.",@"Peter is in the house but John isn't."),
        };

    }
}
