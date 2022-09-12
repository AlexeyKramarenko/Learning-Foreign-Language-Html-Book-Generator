using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_93 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Он бросил [перестал] курить на прошлой неделе и с того времени стал невыносим.",@"He stopped smoking  last week and has been unbearable ever since."),
            (@"Он любит дразнить свою жену ее тратами,",@"He enjoys teasing his wife about her spending,"),
            (@"но, чтобы избежать [возникновения] ссоры, он всегда в конце соглашается с ней.",@"but, to avoid causing an argument, he always agrees with her in the end."),
            (@"Преступник отрицал, что грабил банк, но было слишком много свидетелей.",@"The criminal denied robbing the bank, but there were too many witnesses."),
            (@"Вы можете не курить? Это купе для некурящих.",@"Would you mind not smoking? This is a non-smoking compartment."),
            (@"Нет смысла пробовать бежать, если не умеешь ходить.",@"It's no use trying to run* before you can walk."),
            (@"Этот новый фильм о Швейцарии стоит посмотреть.",@"That new film about Switzerland is worth seeing*."),
            (@"Представь себе, что ты поп-звезда. Это, наверно, великолепно!",@"Imagine being a pop-star. It must be great!"),
            (@"Женщина, которой стало жалко нищего, пригласила его на кухню.",@"A lady who felt*  sorry for a beggar invited him into the kitchen."),
            (@"На столе было немного сардинок и копченый лосось.",@"On the table, there were some sardines and some smoked salmon."),
            (@"Нищий немедленно принялся [начал] есть копченый лосось.",@"The beggar immediately began* eating*  the smoked salmon."),
            (@"Тут есть также сардинки, сказала женщина громким [крикливым] голосом.",@" - There are some sardines as well, said the lady in a loud voice."),
            (@"Предпочитаю копченый лосось, ответил нищий.",@"- I prefer the smoked salmon, replied the beggar."),
            (@"Но он значительно дороже, жаловалась недоброжелательная [плохо расположенная к нему] хозяйка.",@"But it's more expensive, complained the unwilling hostess."),
            (@"Да, я знаю, леди... но он того стоит.", @"- Yes I know, lady... but it's worth it! "),
        };

        public override string[] Notes => new[]
        {
            (@"Современный английский язык предпочитает формы: [he stopped smoking] - перестал курить, вместо [bе stopped to smoke]. Аналогично обстоит дело с глаголом [to like: Не likes swimming] встречается чаще, чем [he likes to swim]. "),
            (@"[Unbearable] - невозможный, несносный, невыносимый, [I can't bear him] - я не могу его выдержать. "),
            (@"[Ever since] - с того времени, с той поры. "),
            (@"[То agree with] - соглашаться с кем/чем-нибудь. [Не agrees  with те] - Он соглашается со мной. [An agreement] - чо согласие, соглашение. "),
            (@"[To feel sorry] - почувствовать эк:алость, стало жалко. [I'm sorry for that poor man.] -Мне жалко этого бедняка. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Нет смысла его спрашивать, он ничего не знает о политике.",@"It's no use asking him, he doesn't know anything about politics."),
            (@"Чей это словарь?  - Думаю, что его.",@"Whose is this dictionary ? - I think it's his."),
            (@"Пойди посмотри этот новый фильм, он в самом деле этого стоит.",@"Go and see that new film, it's really worth it."),
            (@"Одолжи мне, пожалуйста, немного денег? - Мне очень жаль, но я не могу себе это позволить",@"Will you lend me some money? - I'm sorry, I can't afford it."),
            (@"Он спит с тех пор, когда мы отъехали от станции.",@"He has been asleep ever since we left the station."),
         };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн перестал разговаривать, когда вошел его шеф. ", "Не [stopped talking (speaking) ] when [his boss came in]."),
            ( "Стоит изучать иностранный язык, это очень пригодится.", "It's [worth learning ] а [foreign language ], it's very [useful]."),
            ( "Она остановилась, чтобы взглянуть на витрину магазина.", "She stopped [to look at] а shop window."),
            ( "Мне тебя жалко, но я ничего не могу сделать. ", "I [feel sorry ] for you, but [I can't] do anything."),
            ( "Чья эта чековая книжка? - Моей жены. ", "[Whose is ] this [cheque  ]-[book] ? - It's [my wife's]."),
        };
    }
}
