using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_141 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Спроси его, можешь ли ты одолжить у него косилку? - Спросил и он сказал нет.",@"Ask him if you can borrow the lawnmower. - I did, and he said no."),
            (@"Oн сказал, что она ему нужна сегодня. Что я мог сказать?",@"He told* me that he needed it today. What could I say?"),
            (@"Ты мог сказать, что нужно подстричь траву. Но неважно.",@"You could have said that the grass needed cutting*  . Well, never mind."),
            (@"Я был поражен спокойствием жителей Лондона, которых встретил.",@"I was struck* by the calm of the Londoners I met*."),
            (@"Колонна Нельсона производит впечатление. Бронзовые львы у подножия сделаны из французских пушек.",@"Nelson's Column is very impressive. The bronze lions at the foot are made* from French cannons."),
            (@"Я люблю картины, а картины в Национальной Галерее были изумительны.",@"I like paintings, and the paintings   in the National Gallery were marvellous."),
            (@"Я почти совсем не говорил по-английски. Ты бы поверил? Все [каждый], кого я встречал, были французами.",@"I hardly   spoke* any English. Would you believe it? Everyone I met* was French."),
            (@"Oн сказал, что не может ждать. У него как раз была срочная встреча, и он должен был уйти.",@"He said he couldn't wait. He had an urgent appointment and had to leave*."),
            (@"Она наверняка должна была выйти, потому что ее машины нет в гараже.",@"She must have left*, because her car isn't in the garage."),
            (@"Если бы мы подумали об этом раньше, ты бы мог поехать с нами.",@"If we had thought* of it earlier, you could have come* with us."),
            (@"Он мог прийти, когда меня не было, но оставил бы записку [сообщение].",@"He might have come* while I was out, but he would have left* a message."),
            (@"Я мог понять все, что они говорили, невзирая на то, что большинство из них говорили с сильным акцентом.",@"I was able to understand* everything they said, despite the fact that most of them had heavy accents."),
            (@"Ты купил так много сувениров. Наверно, ты потратил целое состояние.",@"You bought* so many souvenirs. You must have spent* a fortune!"),
            (@"Она решила учиться медицине, невзирая на совет своего отца.",@"She made* up her mind to study medecine, despite her father's advice."),
            (@"Скажи ему, чтобы пришел немедленно. Мы уже опаздываем, а я не хочу пропустить начало.", @"Tell him to come* straight away. We're late already and I don't want to miss the beginning."),
        };

        public override string[] Notes => new[]
        {
            (@"Запомните эти выражения: [the grass needs cutting] - нужно подстричь траву; [this house needs repairing] - этот дом надо отремонтировать; [your hair wants cutting] - твои волосы нуждаются в стрижке."), (@"Присмотримся к использованию артиклей в этом предложении. [I like paintings] - я люблю картины - неизвестно, какие именно, поэтому без артикля [the]. А, [an] используется с существительными единственного числа. [The paintings in the National Gallery] - картины в Национальной Галерее. Здесь картины являются  определенными - те, что имеются в Галерее, и в связи с этим используется артикль [the]. "),
            (@"[Hardly] - еле-еле, едва, почти; [hard] - тяжелишая. [We hardly saw him.] - Мы его почти не видели. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Не хотел бы ты зайти на стаканчик сегодня вечером?",@"Would you like to come round for drinks this evening?"),
            (@"Я едва его узнал в такой одежде.",@"I hardly recognised him dressed like that."),
            (@"Они, наверное, ушли: нет их пальто.",@"They must have left: their coats have gone."),
            (@"Нужно сменить масло.",@"The oil needs changing."),
            (@"В котором часу ты хочешь, чтобы я пришел?",@"What time do you want me to come?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Ты мог ей/ему сказать, что нужно подстричь траву. ", "You [could ] have [told him/her ] that the grass [needed cutting]."),
            ( "Она хочет, чтобы мы поторопились, она не любит ждать.", "She wants [us to hurry ] (up), she [doesn't ] like [waiting]."),
            ( "Они должны были это взять, я не могу нигде этого найти.", "They [must ] have [taken ] it, I can't find it [anywhere]."),
            ( "Если бы я подумал об этом раньше, то Вы могли бы уйти с нами.", "If I [had thought of] it [earlier ] you [could have ] left with [us]."),
            ( "Она могла прийти вчера вечером, никого не было дома.", "She [might have ] come last night, there was [no one/nobody] at [home]."),
        };
    }
}
