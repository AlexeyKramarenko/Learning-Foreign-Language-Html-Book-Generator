using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_66 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Как обычно, изучите (материал, изложенный на) странице, потом ответьте на вопросы, обраш;аясь к предыдущим урокам.",@"Learn this page as usual, then answer the questions with the help of® the preceding lessons."),
            (@"Какое популярное название имеет метро?",@"What is the popular name for the Underground?"),
            (@"Где еще есть подземные железные дороги? Как они называются?",@"Where else can you find* an underground railway system? What is it called?"),
            (@"Разве метро дорогое? Почему оно дороже парижского метро?",@"Is the Tube expensive?  Why is it dearer than the Parisian Metro?"),
            (@"Почему нужно сохранять [держать! свой билет до выхода [пока не дойдешь до выхода]?",@"Why must you keep* your ticket until you reach the exit?"),
            (@"Как называются английские автобусы? Можно ли курить в английском автобусе? Где (именно)?",@"What are London buses called?  Can you smoke on a London bus?  Where?"),
            (@"Кто берет плату за проезд? Кто ведет автобус?",@"Who collects the fares? Who drives the bus?"),
            (@"Что такое Хакни кебз? Какого они цвета?",@"What are Hackney Cabs? What colour are they?"),
            (@"Как узнать, что такси свободно?",@"How do you know* if a cab is free?"),
            (@"Чем лучше всего ездить / путешествовать по Лондону?",@"Which is the best way to travel around London?"),
            (@"Пожалуйста, билеты [стоимость проезда].  <br> - До Хайд-парка, пожалуйста. <br> - Это (будет) двенадцать пенсов.",@"Fares please. <br> - Hyde Park, please. <br> - That's twelve pence."),
            (@"Я не знаю Лондона. <br> Вы не подскажите, где я должен сойти?",@"I don't know London. <br> Will you tell* me where I must get* off?"),
            (@"Конечно.<br> Если вы хотите курить, вы должны пойти наверх.",@"Of course. <br> Oh, if you want to smoke, you must go* upstairs."),
        };

        public override string[] Notes => new[]
        {
            (@"[To learn] - учиться, научить, но и изучить, узнавать. "),
            (@"[With the help of] - с помощью, обращаясь за помощью. "),
            (@"Здесь оборот [you can find] переводим не как можно найти, но как находится. "),
            (@"[Dear, expensive] - дорогой. "),
            (@"[То reach] - достигать, доходить. When you reach thirty -   Когда тебе исполнится тридцать [достигнешь тридцати].  [When you reach the exit] - Когда дойдешь до выхода. "),
            (@"[Fares, please] - оборот, используемый кондукторами, продающими билеты. Значит то же самое, что [Tickets, please] - Билеты, пожалуйста."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он должен уйти сразу? - Дак, к сожалению.",@"Must he leave at once? - Yes, I’m sorry."),
            (@"Они ушли утром (этого дня) перед тем, как ты встала.",@"They left this morning before you got up."),
            (@"Брайтон - это популярное место для выезда на каникулы.",@"Brighton is a popular place to go for your holidays."),
            (@"Откуда знаешь, что ты прав?",@"How do you know if you are right?"),
            (@"Что случится, если он не позвонит?",@"What will happen if he doesn’t phone?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Почему я должен ей писать? - Потому что она твоя двоюродная сестра.", "Why [must I write ] to [her ]? - Because [she is ] your [cousin]."),
            ( @"Если увидишь (объявление) ""Сдается (квартира)"", знай, что она свободна.", @"[If ] you [see ] the ""[For Hire sign ]"", you know [it ] is [free]."),
            ( "(Под)скажите мне, пожалуйста, где я должен выйти. - Я не знаю Лондона.", "[Tell me ] where I [must get off ] please, [I don't know London]."),
            ( "Где я могу купить (проездной) сезонный билет? ", "Where [can I ] а [buy ] - [season-ticket]? "),
            ( "Четыре времени года - это весна, лето, осень, зима. ", "The four [seasons are]: [spring], [summer], [autumn], [winter]."),
        };
    }
}
