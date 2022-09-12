using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_110 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Спасибо тебе большое за всю твою помощь. - Не за что.",@"Thank you very much for all your help. - Not at all"),
            (@"Набери этот номер и попроси секретаря мистера Смита.",@"Dial this number and ask for Mr Smith's secretary."),
            (@"Человек, у которого украли на прошлой неделе мотоцикл, жалуется.",@"The person whose motor-bike was stolen* last week is complaining."),
            (@"Это не мог быть Дэвид, он не сказал: ""Привет"".",@"That couldn't have been David, he didn't say ""Hello""."),
            (@"Она привыкла присматривать за людьми, она (ведь) санитарка.",@"She is used to looking after people, she is a nurse."),
            (@"В настоящее время она работает в больнице, но в следующем месяце сменит работу.",@"At present, she is working in a hospital, but next month she is changing jobs."),
            (@"С меня попросили двадцать франков за чашку чая в Париже!",@"I was charged twenty francs for a cup of tea in Paris!"),
            (@"Прошу меня извинить, я иностранец: вы не могли бы мне помочь? Я заблудился.",@"Excuse me, I'm a foreigner; could you help me?  I'm lost"),
            (@"Но вы говорите очень хорошо по-английски. - Я должен говорить (еще) бегло.",@"But you speak* English very well. -I should speak* it fluently."),
            (@"Если бы я лучше готовился к урокам, я говорил бы бегло.",@"If I learned my lessons better, I would speak* it fluently."),
            (@"Джордж провел три месяца на Лазурном берегу в прошлом году.  - Счастливый [Джордж]!",@"George spent* three months on the Riviera last year. - Lucky George!"),
            (@"Не стоит покупать новый проигрыватель; я могу (может быть) получить его (в подарок) на день рожденья.",@"It's not worth buying* a new record- player; I might get one for my birthday."),
            (@"Я не знал (был не в курсе), что она говорит по-китайски.  - Она тоже [ни она].",@"I wasn't aware she spoke Chinese. - Neither was she!"),
            (@"Кони являются очень сильными животными.",@"Horses are very strong animals."),
        };

        public override string[] Notes => new[]
        {
            (@"[To lose, lost, lost] - потерять. [He got lost, he is lost] - он заблудился. [Get lost] - проваливай."),
            (@"[To learn one's lessons] - учить уроки, готовиться к ним. "),
            (@"[То be aware] - отдавать себе отчет, знать о чем-то. Противоположностью является оборот [to be unaware]."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Она может быть купит мне новый проигрыватель.",@"She might buy me a new record-player."),
            (@"Никто из нас не хотел сменить работу.",@"Neither of us wants to change jobs."),
            (@"Я не знал, что ты знала Джорджа.",@"I wasn't aware that you knew George."),
            (@"Я не знала его очень долго.",@"I haven't known him for very long."),
            (@"Разве стоит из-за этого высылать телеграмму? Не думаю.", @"Is it worth sending a telegram?  - I don't think so."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я недавно потеряла работу. ", "I [lost my ] job a little while [ago]."),
            ( "Секретарь этого человека делает за него всю работу. Счастливчик!", "[That man's ] secretary does [all ] his work [for him] Lucky man!"),
            ( "Я не знаю у сколько он зарабатывает. - Я тоже [ни я]. ", "I don't know [how much ] he [earns ]. - Neither [do I]. "),
            ( "В настоящее время она работает в больнице, но собирается сменить работу.", "[At present ], she [is ] working [in ] а hospital, but she [is going ] to change [jobs]."),
            ( "Он привык помогать людям. Работает [является] экскурсоводом.", "Не is [used to ] helping people, [he's a] guide."),
        };
    }
}
