using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_109 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Нам встречались в последнее время многие новые слова. Повторим некоторые из них.",@"We have seen* many new words recently. Let's revise some of them."),
            (@"Мы должны были купить новый холодильник, пока цены не пошли вверх.",@"We should have bought* a new fridge before the prices went up."),
            (@"Нет, спасибо, у меня уже есть больше, чем нужно.",@"No thank you, I already have more than I need."),
            (@"Всем [каждому] нужны деньги, но некоторым нужно больше, чем другим.",@"Everyone needs money, but some need more than others."),
            (@"Если докеры забастуют, мы будем вынуждены остаться на корабле.",@"If the dockers go on strike, we'll have to stay in the ship."),
            (@"Пособие по безработице доступно для тех, кто в нем нуждается.",@"Unemployment benefit is available to those who need it."),
            (@"Моему сыну - врачу - четыре года, а юристу - три.",@"My son the doctor is four and the lawyer is three."),
            (@"Ненавижу проходить мимо ювелирного магазина вместе с моей девушкой.",@"I hate walking past the jeweller's with my girlfriend."),
            (@"Не присмотрел бы ты за детьми, пока я буду ходить по магазинам?",@"Would you look after the baby while I go to the shops?"),
            (@"Удостоверения личности были упразднены в Англии после войны.",@"Identity cards  were abolished in England after the war."),
            (@"Мы с моим шефом [мой шеф и я] не всегда соглашаемся.",@"My boss and I don't always agree."),
            (@"Он поднял пенни снаружи банка и директор взял его на работу.",@"He picked up a penny outside the bank and the manager employed  him."),
            (@"Если будешь работать на фабрике, ты обязан вступить в профсоюз.",@"If you work in this factory, you must join a trade union."),
            (@"Мы скоро должны согласовать решение.",@"We've got to agree on a solution soon."),
        };

        public override string[] Notes => new[]
        {
            (@"[Fridge] - это сокращение от [refrigerator] - холодильник. "),
            (@"[То go up] - пойти ввел, подскочить, взорваться. [The prices went up.] - Цены пошли вверх. "),
            (@"[Identity cards] - буквально - идентификационная карта, аналог удостоверения личности, внутреннего паспорта."),
            (@"[То employ] - взять на работу, [employee] - работник, работающий; [employer] - работодатель, принимающий на работу."),
            (@"[То join] - присоединиться к (напр., веселью/обществу). "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Извините меня, я думаю, что это мое.",@"Excuse me, I think that's mine."),
            (@"Докеры бастовали и мы не могли сойти с корабля.",@"The dockers were on strike and we couldn't get off the ship."),
            (@"Я должен встать рано, у меня встреча с юристом.",@"I had to get up early, I had an appointment with my lawyer."),
            (@"Не могла бы ты купить мне газету, пока я буду мыть (посуду)?",@"Would you get me a paper while I do the washing-up?"),
            (@"Поезд должен был приехать полчаса назад.",@"The train should have got in half an hour ago."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Она ненавидит выходить сейчас, когда утрачивает зрение.", "She hates [going out] now that she [is getting] blind."),
            ( "Bee [каждый] кричали одновременно, и продавщица ничего не могла сделать.", "[Everyone/everybody] was shouting [at once] and the salesgirl [could not] do [anything]."),
            ( "Hem больше романтических героев в литературе. ", "There [are ] no [more] romantic heroes in literature."),
            ( "He могу с тобой согласиться, мне эта идея кажется глупой.", "I can't [agree with you ], I find [the idea stupid]."),
            ( "Где я должен выйти из автобуса? Через остановку после меня.", "Where [must] I [get off] the bus? - The stop [after me]."),
        };
    }
}
