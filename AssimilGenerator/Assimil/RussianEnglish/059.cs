using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_59 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Мужчины говорят о женщинах как о «прекрасном поле», «нежном поле» или «слабом поле».", @"Men speak* of women as the ""fair sex"" or the ""gentle sex"" or the ""weaker sex""."),
            (@"Женщины редко говорят о мужчинах как о «сильном поле».",@"Women rarely speak* of men as the ""stronger sex""."),
            (@"Некоторые мужчины думают, что их считают «платящим полом».",@"Some men think* they are considered as the ""paying sex""."),
            (@"Моей жене каждую ночь снится, что вышла замуж за миллионера.",@"My wife dreams every night that she's married to a millionaire."),
            (@"Счастливчик. Моей снится, что она жена миллионера, в дневное время.",@"You're lucky. Mine dreams she's married to a millionaire in the daytime !"),
            (@"Природа дала нам уши, которые всегда открыты",@"Nature has given* us ears which are always open"),
            (@"и рот, который лучше почаще держать закрытым.",@"and a mouth which it is often better to keep shut,"),
            (@"Гордые родители [двое гордых родителей] показывают своему сыну его нового брата.",@"Two proud parents were showing their son his new brother."),
            (@"Мальчик посмотрел на младенца с минуту и [потом] начал плакать.",@"The boy looked at the baby for a minute and then started crying"),
            (@"Родители улыбнулись. «Что случилось?» - спросили.",@"The parents smiled, ""What's the matter?"" they asked."),
            (@"""У него нет ни волос, ни зубов"",всхлипнул ребенок." ,@"- ""It's got* no hair or teeth"", the child sobbed."),
            (@"""Это несправедливо. Это старый младенец"".", @"It's not fair. It's an old baby."),
            (@"Мы не просим вас выучить неправильные глаголы за два или три дня,",@"We do not ask you to learn the irregular verbs in two or three days"),
            (@"но только повторять их, когда их встретите [в тексте].", @"but only to repeat them when we meet* them."),
        };

        public override string[] Notes => new[]
        {
            (@"[Daytime] - днем, [night-time] - ночью. "),
            (@"[Started crying] или [started to cry] - начать плакать, расплакаться. "),
            (@"[Fair] - справедливый, правильный, добросовестный, благородный. [Fair sex] - прекрасный пол, [fair play] - игра по правилам, благородное поведение [манеры] - это английское выражение употребляется в русском языке как синоним правильного, честного поведения. ")
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"B Англии редко идет дождь летом.",@"It rarely rains in the summer in England."),
            (@"Англичане известны своими благородными манерами.",@"English people are famous for their spirit of fair-play."),
            (@"Поедем в Вэст Энд и посмотрим представление.",@"Let's go to the West End and see a show."),
            (@"В котором часу закрываются банки? - В три тридцать.",@"What time do the banks shut? - At three thirty."),
            (@"Посмотри на этот текст с минуту, потом повтори его.",@"Look at this text for a minute, then repeat it."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я дал ему это вчера вечером. Разве он не может этого найти?", "I [gave ] it [to him ] last [night]. [Саn't he] find it?"),
            ( "Они показывали нам фильмы, которые сняли на каникулах.", "They [were showing us ] the films [that (which) they ] took [on holiday]."),
            ( "Она выпустила собаку наружу и закрыла дверь. ", "She [put ] the dog [outside ] and [shut] the door."),
            ( "Моя машина не работает [не ездит]. <br /> - Счастливчик, у меня нет машины.", "My car [doesn't work.] - [You're lucky ], haven't [got one]."),
            ( "Французы нас считают сдержанными. ", "[We are considered by] the French as being reserved."),
        };
    }
}
