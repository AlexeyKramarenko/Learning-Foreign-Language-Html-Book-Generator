using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_108 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Давайте присмотримся к некоторым профессиям, доступным сегодня людям.",@"Let's look at some of the occupations available to people today."),
            (@"(Работая) продавцом [как продавец], вы можете быть мясником, продавцом овощей, пекарем;",@"As a tradesman , you can be a butcher, a greengrocer, a baker;"),
            (@"можно продавать изделия из железа, быть модисткой, ювелиром или продавцом книг и т.п.",@"you can be an ironmonger, a milliner, a jeweller or a bookseller, etc."),
            (@"(Работая) ремесленником [как ремесленник] вы можете быть столяром, золотых дел мастером, часовщиком или монтером.",@"As a craftsman, you can be a joiner, a goldsmith, a watchmaker or a fitter."),
            (@"Есть также работники физического труда - такие как каменщики.",@"are also manual workers, such as bricklayers"),
            (@"Затем существуют (независимые) профессии: учитель, врач, юрист или маклер.",@"Then there are the professions: teacher, doctor, lawyer or broken"),
            (@"(Обязательная срочная) военная служба была отменена в Англии в 1963",@"Military service was abolished in England in May 1963"),
            (@"(тысяча девятьсот шестьдесят третьем) году,",@"(nineteen sixty three),"),
            (@"таким образом, служба в армии также считается профессией.",@"so the armed services are also considered as a career ."),
            (@"Сегодня в промышленности существует много проблем: забастовки случаются часто и бывают серьезными.",@"There are many problems in industry today: strikes are frequent and often serious."),
            (@"Профсоюзы, которые защищают интересы своих членов,",@"The trade unions, which look after their members' interests,"),
            (@"не всегда согласны с работодателями.",@"do not always agree with the employers."),
            (@"Если шахтеры или железнодорожники бастуют, результаты (забастовки) могут быть небезопасными для страны.",@"If coal-miners or railwaymen go on strike, the results can be very serious for the country."),
            (@"Эти проблемы известны как „трудовые отношения в промышленности''.",@"Such problems are known as ""industrial relations""."),
        };

        public override string[] Notes => new[] 
        {
            (@"[Available] - доступно. [This item is no longer available] - Эта вещь уже недоступна."),
            (@"[Tradesman] - продавец, торговец-, [trade] - торговля. "),
            (@"[Bricklayer] - каменщик; [brick] - кирпич; [to lay, laid, laid] - класть, укладывать; [mason] - каменщик, а также - каменотес. "),
            (@"[Career] - карьера, профессия. "),
            (@"[То strike, struck, struck] - ударять; [strike] - забастовка; [to go on strike] - бастовать; [striker] - забастовщик. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"в этой части Лондона уже нет большого количества ювелиров / золотых дел мастеров.", @"There are no longer many goldsmiths in this part of London."),
            (@"Боюсь, что я с тобой не согласен.",@"I’m afraid I don't agree with you."),
            (@"Он является (членом) профсоюза? - Я так полагаю.",@"Does he belong to a trade union? - I think so."),
            (@"Куда ты положил мои часы? - В спальню.",@"Where did you put my watch? - In the bedroom."),
            (@"С половины девятого его можно будет застать (на месте) [он будет доступен].",@"He will be available from eight thirty."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Почему ты не в армии? - Военной слулсбы больше не существует.", "Why [aren't] you [in] the army? - Military service [по longer] exists."),
            ( "Я мог бы быть столяром, но мой отец хотел, чтобы я учился.", "I [could] have [been а joiner], but [my ] father [wanted me] to study."),
            ( "Ты должен начать думать о своей карьере, это никогда не поздно.", "You [should] start [thinking] about [a career], it's [never too late]."),
            ( "Я стал бы врачом, если б мог. ", "I [would ] become [a doctor ] if [I could]."),
            ( "Оба политика согласились. ", "[Both] politicians [agreed]."), 
        };
    }
}
