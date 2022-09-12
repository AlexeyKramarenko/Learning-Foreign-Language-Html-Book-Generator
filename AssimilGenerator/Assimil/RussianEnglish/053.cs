using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_53 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Мужчина пробует развлечь своего гостя в клубе.",@"A man is trying to entertain his guest in a club."),
            (@"Не хотел бы ты шотландского [виски]? - Нет, спасибо.",@"Would you like a Scotch? - No, thank you."),
            (@"Я раз пробовал и мне не понравилось. Никогда больше не пробовал.",@"I tried it once and didn't like it. I never tried it again."),
            (@"Тогда выпей немного пива. - Нет, спасибо.",@"Well, have some beer. - No, thank you."),
            (@"Пробовал когда-то и мне не понравилось. Никогда больше его не пил.",@"I tried some once and didn't like it. I never drank it again."),
            (@"А как с игрой в бильярд? - Нет, спасибо.",@"How about a game of billiards?  - No, thank you."),
            (@"Играл раз, и это мне не понравилось. Никогда больше не пробовал,",@"I played it once and didn't like it.  I never tried it again."),
            (@"Что ж, а игра в шахматы?  - Опять нет, спасибо.",@"Well, a game of chess? -Again, no thank you."),
            (@"Играл раз, и мне это не нравилось.",@"I played it once and didn't like it."),
            (@"Но вот это мой сын. Он прекрасный игрок.",@"But here is my son. He's an excellent player."),
            (@"Твой единственный сын, как я полагаю.",@"Your only son, I presume?"),
            (@"Что ты делал в Америке? - Мы взяли напрокат машину и посетили западное побережье.",@"What did you do in America? - We rented a car and visited the West Coast."),
            (@"Ты видел Большой каньон? - Нет, у нас не было времени.",@"Did you see the Grand Canyon? - No, we didn't have time»"),
        };

        public override string[] Notes => new[]
        {
            (@"[То entertain] - развлечь, потешить, [entertainment] - забава, развлечение, потеха, [entertaining] - забавный, занимательный. "),
            (@"[Would you like ...?] - хотел/а [не хотел/а] бы ты - вежливая форма, употребляющаяся чаще, чем [will you have...?] "),
            (@"Смотри урок 51 объяснение 4."),
            (@"[How about] имеет много значений, например, а что с, а как с, что слышно у, что скажешь на и т.п. "),
            (@"[To rent] - нанимать, взять напрокат, [rent-a-car] - фирма, сдающая машины напрокат; [to hire] - снять, взять в аренду."),
            (@"[Grand] - большой, великий, прекрасный, импонируюший. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Как насчёт чашки чая? - Да, пожалуйста.",@"How about а cup of tea? - Yes, please."),
            (@"Ты написал ему?",@"Did you write to him?"),
            (@"Нет, у пас не было времени.",@"No, we didn't have time."),
            (@"Ты - мой единственный друг.",@"You are my only friend."),
            (@"Они никогда не принимают своих друзей дома.",@"They never entertain their friends at home."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Как насчёт игры в шахматы? Нет, спасибо. Раз пробовал.", "How [about ] а [game ] of chess? - No [thank you ] I [tried ] it [once]."),
            ( "Тише, я пытаюсь заснуть. ", "Be [quiet ], I'm [trying ] to [sleep]."),
            ( "Не хотел бы ты попробовать этого пива? Ты очень мил.", "[Would ] you [like ] to [try this ] beer? [You're ] very [kind]."),
            ( "Они нас навестили, но нас не было. ", "They [visited ] us but we [weren't] in."),
            ( "Анна и ее друзья не любили своего учителя. ", "Anne and [her ] friends [didn't ] like [the] teacher."),
        };
    }
}
