using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_68 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Англичане очень любят спорт.",@"English people are very fond of® sport."),
            (@"Они занимаются им, смотрят (как болельщики), разговаривают о нем и думают о нем,",@"They play it and they watch it; they talk about it and think* about it."),
            (@"Наиболее типичная английская игра - это крикет, в который играют в летние месяцы.",@"The most typically English game is cricket, which is played during the summer months."),
            (@"Но наиболее популярная игра - это футбол, в который играют все остальное время [года] (восемь месяцев).",@"But the most popular game is football, which is played during the rest of the year (for eight months)."),
            (@"Профессиональный футбол - это очень захватывающее зрелище, а игроки зарабатывают большие суммы денег.",@"Professional football is very exciting to watch and the players earn large sums of money."),
            (@"Другой игрой с мячом - менее популярной, чем футбол - является регби.",@"Another ballgame, less popular than football, is rugby."),
            (@"Название регби футбол было придумано в школе Регби приблизительно в 1820 году.",@"Called rugby football, it was invented   at Rugby School in about 1820 (eighteen twenty)."),
            (@"Мальчику по имени Эллис так надоела игра ногами,",@"A boy, called Ellis, was so bored with playing with his feet,"),
            (@"что он взял мяч в (свои) руки - и родилась новая игра.",@"that he took* the ball in his hands - and. a new game was born  !"),
            (@"Другим популярным видом спорта являются конные гонки, которые запрещены в Англии в воскресенье.",@"Another popular sport is horse-racing, which is forbidden* in England on Sundays»"),
            (@"В Англии не существует государственной лотереи, однако игра, называемая бинго, очень популярна.", @"There is no State lottery in England, but a game called Bingo is very successful."),
            (@"Многие кинотеатры закрываются и превращаются в залы бинго.", @"Many cinemas are closing and being converted into Bingo halls."),
            (@"Считается, что около шести миллионов человек, главным образом, женщины, регулярно играют в бинго.",@"It is estimated that about six million people, mainly women, play Bingo regularly."),
        };

        public override string[] Notes => new[]
        {
            (@"[То be fond of] - любить. "),
            (@"[То invent] - найти, находить, выдумывать. "),
            (@"[Foot] - ступня, [feet] - ступни, [legs] - ноги. "),
            (@"[То be born] - родиться. [I was born in London] - Я родился в Лондоне. [Where were you born?] - Где ты родилась? "),
            (@"[Successful] - успешный, удачный, преуспевающий, популярный, привлекательный."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мне надоело слушать его, вот я и уснул.",@"I was bored with listening to him, so I fell asleep."),
            (@"Танцы запрещены в церкви.",@"Dancing is forbidden in the church."),
            (@"Стобби Нильс является преуспевающим футболистом.",@"Stobby Niles is a successful football player."),
            (@"Я очень люблю твою сестру. Она замужем?", @"I’am very fond of your sister. Is she married?"),
            (@"Она играет в бинго каждую неделю и выигрывает большие суммы (денег).", @"She plays Bingo every week and wins large sums of money."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн рассказывал о своих приключениях в Африке, а я скучал.", "Не was [talking about his ] adventures [in ] Africa but I [was bored]."),
            ( "Футболист зарабатывает больше, чем директор банка.", "А football [player earns] more [than] а bank manager. "),
            ( "Курение в лондонском метро запрещено. ", "It [is forbidden to] smoke in the London tube."),
            ( "Крикет менее зрелищен, чем регби. ", "Cricket is [less exciting ] to [watch than] Rugby."),
            ( "Он зарабатывает много (денег), но он работает все лето [на протяжении лета].", "Не [earns ] а [lot of ] money but he works [during ] the [summer]."),
        };
    }
}
