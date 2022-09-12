using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_3 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вот [здесь есть] книга. Она [-] интересная?",@"Here's the book.   - Is it interesting?"),
            (@"Да, она [-] очень интересная.",@"Yes, it's very interesting."),
            (@"Здесь есть газеты. - Где [-] они?",@"There are the papers. - Where are they?"),
            (@"Там, на стеллаже. - Спасибо.",@"There, on the bookcase. - Thank you."),
            (@"Вот [здесь есть] твой чай, Джеймс. Сахару? - Нет, спасибо.",@"Here's your tea, James. Sugar? - No, thank you."),
            (@"Молока? - Да, пожалуйста.",@"Milk? - Yes please."),
            (@"Ой! Он [-] очень горячий. Извини. [Мне очень жаль.]",@"Owl It's very hot. - I'm sorry."),
            (@"Где [-] пепельница? Здесь, с моими сигаретами.",@"Where's the ashtray? - Here, with my cigarettes."),
            (@"Где [-] спички? Там, возле [недалеко от] твоей руки. - Спасибо большое.",@"Where are the matches? - There, near your hand. - Thanks ® very much."),
            (@"Вот [здесь есть] твой чай. Вот [здесь есть] мои сигареты.",@"Here's your tea. Here are my cigarettes."),
            (@"Есть радио. Есть спички.",@"There's the radio. There are the matches."),
            (@"[Это-] Горячо. Это не [-] очень интересно.",@"It's hot. It isn't very interesting."),
            (@"Рука; стеллаж; спички.",@"Hand; bookcase; matches."),
            (@"Да, пожалуйста. Нет, спасибо.",@"Yes please. No, thank you."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Молока к чаю?",@"Milk in your tea?"),
            (@"Да, пожалуйста, он [-] очень горячий.",@"Yes please, it's very hot."),
            (@"Сахар возле твоей руки.",@"The sugar is near your hand."),
            (@"Где? - Здесь [-].",@"Where? - Here it is."),
            (@"Спички [-] на стеллаже.  ",@"The matches are on the bookcase."),
            (@"Там [-] пепельница, а здесь [-] сигареты.",@"There's the ashtray and here are the cigarettes."),
        };

    }
}
