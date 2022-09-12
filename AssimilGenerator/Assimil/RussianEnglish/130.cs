using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_130 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"В этом и следующем уроках посмотрим на разные виды писем.",@"In this lesson and the next one, we will look at different sorts of letter."),
            (@"Дорогой Майк. [Я] пишу, чтобы поблагодарить тебя и твою жену за прием (оказанный) нам в прошлый уикэнд.",@"Dear Mike, I'm writing* to thank you and your wife for having us last weekend."),
            (@"Мы прекрасно провели время, и было так приятно снова увидеть тебя и Мэри.",@"We thoroughly enjoyed ourselves, and it was so nice to see* you and Mary again."),
            (@"Было приятно также снова увидеть Лондон после такого долгого перерыва [времени].",@"It was nice, too, to see* London after all this time."),
            (@"Жизнь в пригороде (течет) спокойно, а временами даже слишком спокойно.",@"Life in the suburbs is quiet, but sometimes a bit too quiet."),
            (@"По дороге домой мы подвезли попутчика автостопом - молодого студента, возвращающегося в университет.",@"On the way home, we gave* a lift to a hitchhiker - a young student going back to university."),
            (@"Мы долго разговаривали - ты ведь знаешь Джоэн -",@"We had a long chat  - you know* what Joan is like -"),
            (@"и, кажется, студенческая жизнь изменилась по сравнению с той жизнью, которую мы знали.",@"and it seems that student life has changed from the life you and I knew*."),
            (@"Сначала ребенок изучал „общественную антропологию*', о которой я всегда думал, что это что-то, связанное с обезьянами.",@"For a start, the kid was studying ""Social Anthropology"", which I always thought* had something to do with monkeys."),
            (@"Потом он нам сказал, что не ходил на лекции, но посвещал свое время подготовке к политическим встречам.",@"Then he told* us that he didn't attend lectures but spent* his time preparing political meetings."),
            (@"Во время уикэндов он ходит на демонстрации.",@"At the weekend, he goes to demonstrations."),
            (@"В наши времена этого бы нам не позволили, не так ли?",@"In our day, it wouldn't have been allowed, would it?"),
            (@"Я высказываюсь по-старому и нетерпимо? Полагаю, что на самом деле я...",@"Do I sound old and intolerant? I suppose I am really..."),
            (@"Спасибо еще раз за ваше гостеприимство, с нетерпением ждем скорых новых встреч с вами.",@"Thanks again for your hospitality, and I look forward to seeing* you both again soon."),
            (@"Самые сердечные приветы для тебя и твоей жены. Твой Дэвид.",@"Kindest regards to you and your wife. Yours, David."),
        };

        public override string[] Notes => new[]
        {
            (@"[To have someone] - принимать кого-либо. [Thank you for having us] - Спасибо за прием [нас]."),
            (@"[То give а lift] - подвезти кого-либо. [Lift] - лифт; [to lift] - поднять, поднимать. [I'll give you а lift to the station] - Я подвезу тебя на вокзал. "),
            (@"[Chat] - разговор, болтовня; [to chat] - разговаривать, болтать. "),
            (@"[For а start] - вначале, во-первых. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"По дороге домой нам пришлось остановиться на станции (технического) обслуживания.",@"On the way home we had to stop at a service station."),
            (@"Это не имеет ничего общего с тобой.",@"It has nothing to do with you."),
            (@"Когда я ходил в школу [был в школе], этого не разрешалось.",@"When I was at school, that would not have been allowed."),
            (@"Он владеет тремя домами и двумя спортивными автомобилями.",@"He owns three houses and two sportscars."),
            (@"Отложим эту встречу, потому что никто не может на ней присутствовать.",@"We will put off the meeting since nobody can attend."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мы написали три письма, из которых два были друзьям.", "We [wrote ] three letters, two [of which] were to friends."),
            ( "По дороге домой мы подвезли автостопом попутчика. ", "On [the way home ], we gave [a Hft ] to а [hitch]-[hiker]."),
            ( "Я говорю как уставший? В последнее время я недосыпал [не много спал].", "Do I [sound ] tired? I [haven't slept] much recently."),
            ( "Мы прекрасно провели время и с нетерпением эюдем новых встреч с вами.", "We [thoroughly enjoyed ] ourselves and we [look forward] to seeing you [again]."),
            ( "Его автобиография не имеет ничего общего с романами, которые он написал.", "[His ] autobiography has nothing [to do with ] the [novels ] he [has written]."),
        };
    }
}
