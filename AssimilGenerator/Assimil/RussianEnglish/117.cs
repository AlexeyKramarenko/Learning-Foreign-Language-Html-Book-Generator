using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_117 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"К счастью, в багажнике была канистра с Бензином.",@"Fortunately, there was a can of petrol in the boot."),
            (@"Дэвид налил его в бак и они поехали на бензозаправочную станцию.",@"David put* that into the tank and they drove* on to a service station."),
            (@"Заправьте его, сказал Дэвид, и лучше проверьте масло.", @" - Fill her up, said David, and you had better check the oil."),
            (@"Почему бы нам не пойти выпить чашку кофе? - сказала Джоэн.", @"- Why don't we go and have a cup of coffee? said Joan."),
            (@"O.K,  хорошо. Когда он закончит, я присоединюсь к тебе.", @"""- Okay, fine. When he's finished, I'll join you."""),
            (@"Джоэн вышла из машины и направилась в сторону кафе.", @"Joan got out of the car and walked towards the cafeteria."),
            (@"Она остановилась возле киоска, чтобы купить журнал, а потом вошла в кафе и купила два кофе.",@"She stopped at a kiosk to buy* a magazine and then went into the cafe and bought* two coffees."),
            (@"Дэвид пришел через пять минут и сел.",@"David arrived five minutes later and sat* down."),
            (@"Извини, дорогая, я должен был послушаться тебя. ", @" - I'm sorry, love, I should have listened to you,"),
            (@"Ты сказала, что мы кое-что забыли, и ты была права.",@"you said we had forgotten* something and you were right."),
            (@"Да, это глупо, если не хватит бензина на автостраде. Ты должен был проверить (это) раньше.", @"- Yes, it's silly to run out of petrol on the motorway. You ought to have checked before."),
            (@"Хорошо, я же попросил прощения, не правда ли?",@"- Alright! I said I was sorry, didn't I? Let's finish our coffee and leave*."),
            (@"Они вернулись в машину и продолжили путешествие молча (в тишине).", @"They got back into the car and continued their journey in silence."),
            (@"Джоэн читала свой журнал, а через час они прибыли в Оксфорд.", @"Joan read* her magazine and an hour later they arrived in Oxford."),
        };

        public override string[] Notes => new[]
        {
            (@"[Service station] - станция обслуживания; [filling station, petrol station] - бензозаправочная станция. "),
            (@"[To run out of] - не хватать. "),
            (@"Напомним, что [ought to] означает то же самое, что [should], то есть ты должен/должна. [She should go, she ought to go] - она должна идти."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Что случилось? - я думаю, что у нас закончился бензин.",@"What's the matter? - I think we've run out of petrol."),
            (@"Когда им надоело ехать, они остановились на станции обслуживания.",@"When they were bored with driving, they stopped at a service station."),
            (@"Ты должен был (это) проверить перед отъездом.",@"You ought to have checked before leaving."),
            (@"Запрещается превышать ограничение скорости.",@"It is forbidden to break the speed limit."),
            (@"Когда он закончит, я куплю тебе чашку кофе.",@"When he's finished, I’ll buy you a cup of coffee."), 
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мы должны поехать повидать моих родителей, я давно их не видел.", "We [ought to ] go and see [my ] parents, I haven't [seen ] them [for] a long time."),
            ( "Я очень люблю читать. Я покупаю по роману каждый месяц.", "I'm very [fond of] reading. I buy a [novel every] month."),
            ( "У нас закончился бензин, но в багажнике есть канистра с бензином.", "We've [run out of] petrol but [there is ] а [can] in the boot."),
            ( "Лучше проверь масло, я не хочу испортить двигатель.", "You [had better ] check the [oil], I don't want to break down."),
            ( "Он зарабатывает много денег, но его работа очень скучная.", "Не [earns a lot of] money but [his ] job is very [boring]."),
        };
    }
}
