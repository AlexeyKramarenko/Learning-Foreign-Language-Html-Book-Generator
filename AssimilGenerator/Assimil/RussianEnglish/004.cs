using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_4 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Это [-] моя сестра. - Сколько ей лет?",@"This is my sister. - How old is she?"),
            (@"[Ей] тринадцать.",@"She's thirteen."),
            (@"Это [-] наш сад. - Он большой? - Не очень.",@"This is our garden. - Is it big? - Not really."),
            (@"Это Г-] мои родители. - [-] Они старые?  - Я [-] не уверен (Я бы так не сказал).",@"These are my parents. - Are they old? - I'm not sure!"),
            (@"Это [-] наша новая машина. Это большая красная машина.",@"This is our new car. It's a big red car ."),
            (@"Это [-] наша библиотека. Это  маленькая библиотека.",@"That is our library. It's a small library."),
            (@"[-] Это Вокзальная улица? - Нет, Вы [-, находитесь] на улице Мостовой.",@"Is this Station Street? - No, you're in Bridge Street."), (@"Вокзальная улица [-, находится] там. - Где? - Возле тех магазинов.",@"Station Street is over there.   - Where? - Near those shops."),
            (@"Старая машина, но новый велосипед.",@"An old car but a new bike."),
            (@"Наши родители [-] в автомобиле.",@"Our parents are in the car."),
            (@"Маленький дом с большим садом.	",@"A small house with a big garden."),
            (@"Привет, Джон. Где [-] твои родители? - Я точно не знаю [Я не вполне уверен].",@"Hello, John. Where are your parents? - I'm not really sure."),
            (@"Может, они [-] в магазинах. Ах, они здесь.", @"Perhaps they are at the shops. Ah, here they are!"),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Сколько тебе лет?",@"How old are you?"),
            (@"Где твоя новая машина? - Там.",@"Where is your new car? - Over there."),
            (@"Это твоя библиотека?",@"Is this your library?"),
            (@"Сколько им лет?",@"How old are they?"),
            (@"Я не уверен.",@"I'm not sure."),
            (@"Это большая красная машина.",@"This is a big red car."),
            (@"Это твои родители?",@"Are these your parents?"),
        };

    }
}
