using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_71 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Господин Маршалл ли господин Хобо сидели на своих местах у двери друг напротив друга.",@"Mr. Marshal and Mr. Hobbs were sitting  in the seats near the door, opposite one another  ."),
            (@"Дэвид Вильсон сел в поезд и сказал: ""Доброе утро"".",@"David Wilson got* into the train and said* : ""Good morning""."),
            (@"Эти двое мужчин ответили: ""Доброе"" и продолжали читать свои газеты.",@"The two men replied ""Morning""   and continued reading* their papers."),
            (@"Дэвид положил свой портфель на полку над своей головой и уселся.",@"David put his briefcase on the rack over his head and sat down."),
            (@"Зажёг сигарету, кинул спичку на пол и открыл свою газету.",@"He lit* a cigarette, threw* the match on the floor and opened his paper."),
            (@"Трое мужчин читали в тишине некоторое время.",@"The three men read* in silence for a while."),
            (@"Окно было наполовину открыто и сильно сквозило,",@"The window was half open and there was a strong draught."),
            (@"""Я так понимаю, что премьер-министр Китая скончался [умер]"", сказал господин Маршалл.",@"""I see*   the Chinese Prime Minister is dead"", said Marshall"),
            (@"Никто не сказал ни слова.",@"No one said a word."),
            (@"Через несколько минут господин Хобс сказал: ""Господи, боже мой, ещё одна (очередная) страшная авария самолета"".",@"After a few minutes, Hobbs said*: ""Oh dear, another terrible plane crash."""),
            (@"Остальные двое не проявили интереса.",@"The other two showed no interest."),
            (@"Тогда Дэвид закричал: ""О, нет!"", остальные посмотрели на него.",@"Then David shouted: ""Oh no!"", the others looked at him."),
            (@"""Стайлс, средний нападающий из команды Чильс болен и не сможет играть с командой Спарс"".",@"""Stiles, the Chelsea centre-forward, is ill and won't be able to play against Spurs."""),
            (@"Трое мужчин начали обсуждать страшную, трагическую новость.",@"The three men began* to discuss the terrible, tragic news."),
        };

        public override string[] Notes => new[]
        {
            (@"[Were sitting] - сидели. Это форма нового прошедшего времени. Оно означает действие, которое имело место в прошлом и длилось довольно долго. "),
            (@"[One another, each other] - в буквальном переводе означает друг друга. Теоретически one another относится к двум людям, а [each other] - к большему количеству людей. На практике, однако, не всегда этого придерживаются. [They saw one another] - они увидели друг друга. [They talked to each other] - они разговаривали друг с другом. [Oposite each other] - Друг напротив друга. "),
            (@"[Morning] - это часто употребляемый ответ на [good morning], который мы можем сказать в ответ знакомому. "),
            (@"[I see] - знаю, понимаю, вижу. "),
            (@"[Dead] - умерший, мертвый. [То be dead] - умереть; [to die] - умирать. [Не is dying] - он умирает; [Не died] - он умер; [Не is dead] - он умер."),
            (@"[News] - новости, известия, новинки. Это слово, несмотря на окончание s имеет форму единственного числа. [The news is good] - новости хороши. [А piece of news] - новость, известие, новинка. [This is а good piece of news] - Это хорошая новость. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Она зажгла сигарету и выкинула спичку на пол.",@"She lit a cigarette and threw the match on the floor."),
            (@"Они начали разговаривать о новости.",@"They began to talk about the news."),
            (@"Лорд Байрон родился в 1788 году, а умер в тысяча восемьсот двадцать четвертом.",@"Lord Byron was born in seventeen eighty-eight and died in eighteen twenty- four."),
            (@"Он положил свое пальто на стул и уселся.",@"He put his coat on a chair and sat down."),
            (@"Я против его идеи. <br> Я считаю ее бессмысленной.",@"I am against his idea. <br> I find it nonsense."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Они читая и свои газеты когда дверь открылась. ", "They [were reading ] their [papers ] when the [door opened]."),
            ( @"Они смотрели друг на друга в течение пяти минут, прежде чем сказать ""добрый день"". ", "They [looked ] at [one another for ] five minutes before [saying Good morning (hello)]."),
            ( "Мы не сможем позволить себе каникулы за границей.", "We [will not be able ] to [afford ] а holiday [abroad]."),
            ( "Окно было наполовину открыто и сильно сквозило. ", "[The window ] was [half] - [open ] and [there was ] а strong [draught]."),
            ( @"Он увидел тело и спросил: ""0н умер или спит?""", @"Не [saw ] the [body ] and asked: ""is [he dead ] or [asleep (sleeping)]?"""),
        };
    }
}
