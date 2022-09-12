using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_80 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Джон увидел своего соседа, курящего трубку.",@"John saw* his neighbour smoking a pipe."),
            (@"Он вынул свою собственную трубку из (своего) кармана и спросил:",@"He took* his own pipe out of© his pocket and said* :"),
            (@"У тебя есть спичка? - Да, пожалуйста.",@"""- Have you got* a match? - Yes, here you are"""),
            (@" Ой, - сказал Джон, - я оставил свой табак дома.	 ",@"- Oh dear , said John, I have left* my tobacco at home,"),
            (@"""В таком случае,"" - сказал его сосед, - отдай мне мою спичку.", @"""- In that case"", said  the neighbour, give me back my match,"""),
            (@"Актер первый раз увидел себя в фильме.",@"An actor saw* himself on film for the first time."),
            (@"Да, - сказал критик, - теперь видишь, как мы должны страдать (как нам приходится страдать).",@"""Yes, said* the critic, now you see* what we have to suffer."""),
            (@"Извините, сэр, я хочу жениться на вашей дочери.",@"Excuse me, sir, I want to marry your daughter."),
            (@"Видел ли ты мою жену, молодой человек?",@"Have you seen* my wife, young man ?"),
            (@"Да, сэр, и все еще хочу жениться на вашей дочери.", @"Yes, sir, and I still want to marry your daughter."),
            (@"Ролле Рейс остановился перед (магазином) Харродс и (из машины) вышла женщина в шубе и бриллиантовом ожерелье.", @"A Rolls Roy ce stopped in front of Harrods and a lady in a fur coat and diamond necklace got* out."),
            (@"Бездомный подбежал к ней и сказал: ""Пожалуйста, лэди, я не ел неделю"".", @"A tramp   ran* up to her and said: ""Please, lady, I haven't eaten for a week."""),
            (@"Что ж, ты должен будешь себя заставить (есть), (Тебе надо будет себя заставить) - прозвучало в ответ.",@"- Well, you will have to force yourself  was the reply."),
        };

        public override string[] Notes => new[]
        {
            (@"[To take out of] - вынуть, вытащить из. "),
            (@"[Неге you are] - можно перевести как пожалуйста. Этот  оборот используем, когда что-то кому-то подаем. "),
            (@"[То give back] - отдать. "),
            (@"[On film] - в фильме; [on television] - по телевидению; но [on the radio] - по радио."),
            (@"[Harrods] - один из самых элегантных торговых домов в Лондоне."),
            (@"[Tramp] - когда-то это слово переводилось как бродяга. Сейчас скорее следовало бы перевести как бездомный, бомж: - [homeless]."),
            (@"[То run up] - подбежать. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Вскоре я должен буду взять обратно книгу Питера.",@"I must take back Peter's book soon."),
            (@"Она поставила банку обратно на полку.",@"She put the jar back on the shelf."),
            (@"Отдай ему его трубку, прежде чем он разозлится.",@"Give him back his pipe before he gets angry."),
            (@"Ты должен будешь бежать, полиция нас видела.",@"You will have to run, the police have seen us."),
            (@"Мужчина в сером костюме и очках - юрист.",@"The man in the grey suit and glasses is a lawyer."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн не ел неделю или дольше. ", "Не [has not eaten ] for [a week ] or [more]."),
            ( "Я не разговаривая с ним по крайней мере два месяца. ", "I [haven't ] spoken [to ] him [for at least] two months."),
            ( "Они не видели друг друга (несколько) лет. ", "They haven't [seen one another ] for [years]."),
            ( "Он вышел из машины, взошел по ступенькам и вошел в здание.", "Не [got out of  ] the car, [went up ] the steps and [went into] the building."),
            ( "Ты должен идти, уже очень поздно и темнеет. ", "You [should leave ], it is [very late ] and it is [getting] dark."),
        };
    }
}
