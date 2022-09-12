using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_6 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Привет, как дела [как [-] ты]? - Очень хорошо, спасибо. А у тебя? [А ты?]",@"Hello, how are you? - Very well, thanks. And you?"),
            (@"И у меня все в порядке. - А в чем дело?",@"Oh, I'm alright @. - What's the matter? "),
            (@"(Сегодня) понедельник, первый день недели. Мои дела никогда не идут [Я никогда не] хорошо в понедельник.",@"It's Monday, the first day of the week; I'm never well on Monday."),
            (@"Где (находится) улица Высокая? - Это (и) есть улица Высокая. - На самом деле, большое спасибо.",@"Where's High Street please?  - This is High Street. - Of course:  thanks very much."),
            (@"Это ваша машина? - Нет, мой шеф еще (находится) за границей. Это его машина.",@"Is that your car? - No, my boss is still abroad. It's his car."),
            (@"Что это? - Это магнитофон, а это зажигалка.",@"What's that? That is the cassette player and this is the cigarette lighter."),
            (@"Очень хорошие. (А) твой шеф часто бывает за границей?",@"Very nice. Is your boss often abroad?"),
            (@"Недостаточно часто.",@"Not often enough."),
            (@"Его брат уже дома? - [Нет], еще нет.",@"Is his brother in yet? - No, not yet."),
            (@"Я в порядке; мы устали [мы уставшие]; снова понедельник.",@"I'm well, we're tired, it's Monday again."),
            (@"Сахар? - Нет, спасибо, этого достаточно.",@"Sugar? - No thank you, this is enough."),
            (@"Как дела у твоей сестры? - Не очень хорошо.",@"How is your sister? - Not very well."),
        };


        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Как себя чувствуют твои родители? - Не очень хорошо.",@"How are your parents? - Not very well."),
            (@"Моих друзей нет.", @"My friends aren't in."),
            (@"Это твоя машина?",@"Is that your car?"),
            (@"Нет, это моя машина.",@"No this is my car."),
            (@"Что это?",@"What's that?"),
            (@"Это моя зажигалка.",@"That's my cigarette lighter."),
            (@"Они (находятся) дома.",@"They're in the house."),
        };

    };
}
