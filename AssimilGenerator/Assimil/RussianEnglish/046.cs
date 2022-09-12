using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_46 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Прочитайте этот урок как обычно и ответьте на вопросы, касающиеся предыдущего урока.", @"Read this lesson as usual, then answer the questions about the preceding one."),
            (@"Что делают Дэвид и Джоэн?", @"What are David and Joan doing?"),
            (@"Куда Дэвид хочет поехать на следующие выходные / уикэнд?", @"Where does David want to go next week-end?"),
            (@"Он хочет поехать в Бирмингем?", @"Does he want to go to Birmingham?"),
            (@"Он хочет поехать на машине в Брайтон?", @"Does he want to drive to Brighton?"),
            (@"Кто приезжает на следующих выходных?", @"Who is arriving next week-end?"),
            (@"Как часто она приезжает?", @"How often does she come?"),
            (@"Что они будут делать?", @"What will they do?"),
            (@"Думаешь, они поедут поездом?", @"Do you think they will go by train?"),
            (@"(А) погода будет хорошая?", @"Will the weather be fine?"),
            (@"Где Дэвид встретит свою тещу?", @"Where will David meet his mother-in-law?"),
            (@"Когда люди идут на каникулы [берут отпуск]?", @"When do people take their holidays?"),
            (@"Четыре времени года - это весна, лето, осень, зима.", @"The four seasons are: spring, summer, autumn, winter."),
        };

        public override string[] Notes => new[]
        {
            (@"[То drive] буквально значит вести машину. Как правило,  однако, этот глагол переводим как ездить, подразумевая езду на автомобиле. "),
            (@"[How often] - как часто. "),
            (@"[To take a holiday] - дословно: брать каникулы. В русском языке, говоря о каникулах, обычно имеем в виду каникулы школьные или студенческие. В английском же приведенный выше оборот можно перевести и как ехать на каникулы и как получать отпуск. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Как обычно берем отпуск зимой (и) в этом году.",@"As usual, we're taking our holidays in winter this year."),
            (@"Если твое радио не работает, можешь одолжить мое.",@"If your radio doesn't work, you can borrow mine."),
            (@"Что ты делаешь? - Пишу письмо.",@"What are you doing? - I'm writing a letter"),
            (@"Как часто читаешь эту книжку? - Раз в день.",@"How often do you read this book? - Once a day."),
            (@"Нет, боюсь, что он еще не вернулся из Брайтона?",@"No, I'm afraid he isn't back from Brighton yet."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Будет очень холодно этой зимой. ", "It [will be ] very [cold ] this [winter]."),
            ( "Обычно они берут отпуска летом. ", "As [usual ] they [are taking their ] holidays in [summer]."),
            ( "Мы берем наши (отпуска) весной, я надеюсь, это будет отлично.", "We [are ] taking [ours ] in [spring ], I [hope ] it [will be] fine."),
            ( "Что он имеет в виду? ", "What [does ] he [mean]? "),
            ( "Как думаешь, экзамен будет трудный? ", "Do [you think] the exam [will be difficult]?"),
        };
    }
}
