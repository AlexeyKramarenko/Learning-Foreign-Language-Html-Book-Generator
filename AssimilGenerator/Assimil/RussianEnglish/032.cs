using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_32 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вот несколько предложений с глаголами из последних нескольких уроков:",@"Here are some sentences with the verbs of the last few lessons:"),
            (@"Джоэн печатает письма все утро.",@"Joan types letters all morning."),
            (@"Дэвид [принимает телефонный звонок] от друга.",@"David receives a call from a friend."),
            (@"Джоэн готовит дома, если она не очень устала.",@"Joan cooks at home if she is not too tired."),
            (@"Твой муж еще работает?",@"Is your husband still working?"),
            (@"Да, его еще нет дома.",@"Yes, he is not home yet."),
            (@"Подожди его, он страшно занят.",@"Wait for him, he's extremely busy."),
            (@"Телефон звонит. [Ответь] (подними трубку), пожалуйста.",@"The phone is ringing. Answer it, please."),
            (@"Его жена работает на полную ставку,",@"His wife works full-time."),
            (@"а он - только на часть ставки.",@"but he only works part-time."),
            (@"Я [не в состоянии] (не могу позволить себе) (иметь, купить) новый автомобиль. Они (автомобили) слишком дороги.",@"I can't afford a new car. They're too expensive."),
            (@"Пойдем в ресторан сегодня вечером.",@"Let's go out to a restaurant tonight."),
            (@"Нет, спасибо. Я не голоден,",@"No thanks, I'm not hungry,"),
            (@"но мне хочется пить: пойдем в паб.",@"but I am thirsty: let's go to the pub."),
        };

        public override string[] Notes => new[]
        {
            (@"[To type] - печатать, набирать на печатной машинке; [a typewriter] - печатная машинка; [а typist] - машинистка."),
            (@"[То cook] - готовить; [а cook] - повар, повариха; [а cooker] - кухонная плита. "),
            (@"[Extremely] значит необычно, неизмеримо, огромно,  чрезвычайно. Это слово сильнее чем [very] - очень. "),
            (@"[Phone] - сокращенная форма от [telephone] - телефон. Аналогично [to phone] - звонить от [to telephone]. "),
            (@"[Full time] - работа на тлную ставку - противопоставляется [part time]. См. урок 29, объяснение. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Они никогда не едят в ресторане.",@"They never eat in a restaurant."),
            (@"Кухня его жены [то, что готовит его жена] превосходна (его жена прекрасно готовит).",@"His wife's cooking is excellent."),
            (@"Он всё еще ждет телефонного звонка от своего шефа.",@"He is still waiting for a call from his boss."),
            (@"Лучше бы мы купили новую машину, старая не работает,",@"We had better buy a new car, the old one doesn't work."),
            (@"Изучение английского языка - работа, занимающая только часть времени (""не на полную ставку"").",@"Learning English is only a part-time job."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Ее муж всегда голоден и он всегда ест в ресторане. ", "[Her ] husband [is ] always [hungry ] and he [always] eats in a restaurant."),
            ( "Пожалуй выпью пива, хотя и не хочу пить [не являюсь жаждущим].", "I'm [going ] to drink а beer [though ] I'm [not thirsty]."),
            ( "Пойдем и встретимся [увидимся] с Дэвидом, если он дома.", "[Let's ] go [and ] see David, if he's [in]. "),
            ( "У него [он имеет] всегда много дел в феврале. ", "Не [always ] has а [lot to ] do [in February]."),
            ( "В 1997 году; в апреле; встреча двадцать восьмого. ", "[In ] nineteen [ninety] - [seven ]; [in ] April; а meeting [on ] the [twenty]-eighth."),
        };
    }
}
