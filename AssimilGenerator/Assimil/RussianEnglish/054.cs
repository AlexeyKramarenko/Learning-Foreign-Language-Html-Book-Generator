using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_54 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Расскажи мне больше (подробнее) о своей поездке.",@"Tell me more about your trip"),
            (@"Хорошо, Петер и я полетели самолетом в Сан-Франциско. Задержались там на два дня и поехали в Монтеррей.",@"Well, Peter and I took a plane to San Francisco. We stayed there for two days and went down to Monterrey."),
            (@"Потом мы посмотрели Канери Роу. - (Припоминаю), не написал ли кто- нибудь об этом книги?",@"There we saw Cannery Row. - Didn't someone write a book about that?"),
            (@"Да, Джон Стейнбек написал книгу. Они также организовали там фестиваль поп- (музыки) в шестидесятые годы.",@"Yes, John Steinbeck wrote one. They also held a pop festival there in the sixties"),
            (@"Потом мы поехали в Лос-Анджелес и посетили Диснейленд. Питер это уже знал (уже был знаком с Диснейлендом).",@"Then we drove to Los Angeles and visited Disneyland. Peter knew it already."),
            (@"Я считаю, что Диснейленд был фантастический. Это напоминало мне Консьержери в Париже.",@"I thought Disneyland was fantastic. It reminded me of the ""Conciergerie"" in Paris."),
            (@"Какой [что за! образованный человек!",@"What an educated person!"),
            (@"Ha прошлой неделе (у меня) был день рожденья. - Сколько тебе исполнилось лет? - О, как минимум [по крайней мере] тридцать два.",@"It was my birthday last week. - How old were you? - Oh, at least thirty-two."),
            (@"Самые лучшие десять лет жизни женщины -",@"The ten best years of a woman's life"),
            (@"это те, что между двадцатью девятью и тридцатью.",@"are those between twenty-nine and thirty."),
            (@"Владелец магазина: - Ваш счет еще не оплачен.",@"Shopkeeper. - Your bill isn't paid yet."),
            (@"Покупатель: Вы не получили моего чека?",@"Customer. - Didn't you receive my cheque?"),
            (@"Владелец магазина: Нет, не получил.",@"Shopkeeper.  - No, I didn't."),
            (@"Покупатель: Вышлю его сразу же.",@"Customer.  - I'll post it at once"),
        };

        public override string[] Notes => new[]
        {
            (@"[A trip] - экскурсия, путешествие, поездка: [a journey] - поездка (наземная, по суше); [а voyage] - путешествие (морем, по суше, воздушным транспортом). [То travel] - ездить, путешествовать; [travel agency] - экскурсионное бюро у бюро путешествий. "),
            (@"Английские неправильные глаголы имеют три формы. Первая употребляется в инфинитиве, конструкциях с повелительным значением во времени [Present Simple], вторая во времени [Past Simple] и третья во времени [Present Perfect], а также, как вскоре увидим, в конструкциях со страдательным залогом (предложение 10). [То take, took, taken]. "),
            (@"[То go, went, gone] - идти, пойти, поехать; формы других глаголов, которые будут встречаться в материалах учебника, дадим в следующих уроках на повторение. Все те глаголы, что нам уже известны или с которыми мы позже познакомимся, будут также приведены в словарике в конце книги. "),
            (@"[The sixties] - шестидесятые годы, [the seventies] - семидесятые годы и т.д. Годы в точных датах читаем следующим образом: 1995 - [nineteen ninety five] или девятьсот девяносто пятый (год). "),
            (@"[I thought ... was] - рассказывая о событиях в прошлом,   используем время Past Simple, которое на русский язык  переводим как настоящее время: [I thought] - считаю, полагаю ... "),
            (@"[Bill] - счет. "),
            (@"[At once] - сразу же, немедленно. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Сколько тебе было лет во время (празднования) последнего дня рожденья?",@"How old were you on your last birthday?"),
            (@"Я прошу прощенья, сэр. Полагал, что мы знакомы [я знаю вас],",@"I'm sorry sir, I thought I knew you."),
            (@"Я хочу больше знать о вашем предложении.",@"I want to know more about your offer."),
            (@"Самые лучшие яблоки -это те, у которых зеленая кожура.",@"The best apples are those with green skins."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мы видели фильм и слышали концерт. ", "We [saw ] а film and [heard] а concert. "),
            ( "Я надеюсь, что он (все-таки) взял хоть какое-то пирожного. Он не хотел никакого.", "I hope he [took some ] cake. - Не [didn't ] want [any]."),
            ( "Она вела машину так быстро, как (только) могла. ", "She [drove ] as fast [as ] she [could]. "),
            ( "Когда он мне позвонил, я пошла сразу же. ", "When he [(tele)phoned/calIed me], I went [at once]."),
            ( "Разве никто не написал книги об этом городе? ", "[Didn't ] someone [write ] а book [about] this town?"),
        };
    }
}
