using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_124 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Для того, чтобы помочь вам в повторении [задаче повторения] сегодня и завтра посмотрим снова на некоторые из слов,",@"In order to help you with your task  of revision, today and tomorrow, we will look again at some of the words"),
            (@"которые встречались нам в последнее время наряду с несколькими новыми.",@"we have seen* recently, together with ® a few new ones."),
            (@"Это предложение может показаться вам трудным, но на самом деле оно простое.",@"This sentence may appear difficult to you, but actually it is simple."),
            (@"С вершины Пост Оффис Тауэр можно увидеть весь Лондон,",@"From the top of the Post Office Tower , you can see* the whole of London,"),
            (@"Индийская кухня прекрасна, но может быть очень острой.",@"Indian cooking  is delicious but it can be very spicy"),
            (@"Я купила этот плащ с рук [буквально: с другой руки, т.е. подержанный, бывший в употреблении]. Он мне идет?",@"I bought* this overcoat second-hand. Does it suit me ?"),
            (@"Если перед тем меня предупредишь, сможешь взять газонокосилку, когда тебе захочется [понравится].",@"So long as you warn me first, you can take* the lawn-mower when you like."),
            (@"Пятого ноября люди пускают фейерверки, разжигают костры и сжигают куклы.",@"On November the fifth, people set* off fireworks, light* bonfires and burn* guys."),
            (@"Хотя он (и) очень умён, он не сдаст экзамена, он не работал/ет.",@"Although he's very intelligent, he won't pass the exam, he hasn't worked."),
            (@"Мой автомобиль припаркован тут же возле кинотеатра [снаружи кинотеатра].",@"My car is parked just outside the cinema."),
            (@"У меня забронирована комната на фамилию Вилсон.",@"I have a room reserved in the name of Wilson."),
            (@"Чего бы он ни хотел, скажи ему, чтобы он ушел, я слишком занят.",@"Whatever he wants, tell* him to go away, I'm far too   busy."),
            (@"Внутри башни Тауэр можно увидеть воронов, которые едят из серебряных мисок.",@"Inside the Tower, ravens could be seen* eating from silver bowls."),
            (@"Не против ли вы подождать десять минут, мистер Вилсон еще не вернулся.",@"Would you mind waiting for ten minutes, Mr Wilson is not back yet."),
        };

        public override string[] Notes => new[]
        {
            (@"[Task] - задание, задача. "),
            (@"[Together] - вместе: together with - вместе с. [They always go out together] - Они всегда выходят вместе."),
            (@"[Post Office Tower] - башня в центре Лондона с почтой и достаточно изысканным рестораном. "),
            (@"[Indian cooking] - здесь: индийская кухня. "),
            (@"[Spice] - приправа, пикантность; [spicy] - острое, приправленное. [Hot] - горячий, но также и острый. "),
            (@"[То suit] - соответствовать, подходить, быть к лицу. [This hat suits you] - Тебе к лицу эта шляпа. [Would the twenty-fifth suit you?] - Вам подошел бы двадцать пятый? "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Вся семья пришла на свадьбу.",@"The whole family came to the wedding."),
            (@"Хотя он не работал, он   сдал экзамен.",@"Although he hadn't worked, he passed the exam."),
            (@"Так как шел дождь, я должна была одолжить плащ.",@"As it was raining, I had to borrow an overcoat."),
            (@"Он пробовал разжечь костер, но тот не разгорался.",@"He tried to light the bonfire but it didn't burn."),
            (@"Я слишком занят, скажи ему, чтобы он пришёл [вернулся] завтра.",@"I’m far too busy; tell him to come back tomorrow."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Хотя они и коллеги, они ненавидят друг друга.  ", "[Although ] they are colleagues, they hate [one another]."),
            ( "С вершины башни можно увидеть весь Лондон.  ", "From [the top of] the tower, you can see the [whole of] London."),
            ( "В этом зеленом платье тебе хорошо.  ", "That green dress [suits you]."),
            ( "(Не) согласитесь ли вы подождать пять минут, он еш,е не вернулся. ", "[Would] you [mind waiting ] for five minutes, he's not [back yet]."),
            ( "Я должен назначить встречу. - Двадцать третье вам подходит?", "I [have to] make an appointment. - Does the twenty-third [suit you]?"),
        };
    }
}
