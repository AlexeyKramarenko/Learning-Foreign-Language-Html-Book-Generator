using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_33 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Мистер Марсден - шеф Дэвида. Он редактор газеты, в которой работает Дэвид.",@"Mr Marsden is David's boss. He is the editor of the newspaper for which David works."),
            (@"Его работа очень ответственна, но он ею занимается с удовольствием.",@"There are many responsibilities ® in his job, but he enjoys ® it very much."),
            (@"По мнению его жены, он слишком ответственен; она его никогда не видит!",@"In his wife's opinion, there are too many responsibilities; she never sees him!"),
            (@"Она предпочитает работу своего сына. Он банковский служащий и каждый день дома в шесть часов.",@"She prefers her son's job. He is a bank clerk and is home every day at six."),
            (@"Его работа не так хорошо оплачивается, как работа его отца, но он работает меньше,",@"His job is not as well paid as his father's, but he works less,"),
            (@"и его отпуск [-] лучше.",@"and the holidays are better."),
            (@"B Англии два раза в году бывает однодневный отпуск (выходной день), называемый ""Bank Holiday"".",@"In England, twice a year, there is a day's holiday called a ""Bank Holiday""."),
            (@"Я буду сегодня поздно (вечером), дорогая. - Почему?",@"I'll be home late tonight, dean - Why?"),
            (@"Я должен приготовить новую статью о налогах [Я имею новую статью о налогах к подготовке].",@"I've got a new article about taxation to prepare."),
            (@"Но ты всегда уходишь [идёшь] в офис рано, а возвращаешься поздно!",@"But you always go to the office early and come home late!"),
            (@"Ничего не могу поделать [Я не могу этому помочь]. Жизнь редактора, знаешь...",@"I can't help it. An editor's life, you know..."),
            (@"И жизнь его жены ....!",@"And his wife's life...!"),
            (@"Увидимся [увижу тебя] вечером, дорогая, до свиданья.",@"I'll see you tonight, love, good-bye."),
        };

        public override string[] Notes => new[]
        {
            (@"[Editor] — редактор; [editor-in-chief] — главный редактор; publisher — издатель."),
            (@"[Responsibility] - ответственность. Буквальный перевод данного предложения - есть много ответственности в его работе. Однако в русском языке такое предложение является неправильным. "),
            (@"[То enjoy] - радоваться, находить удовольствие в чем- нибудь. [Не enjoys his work] - он любит свою работу, занимается ей с удовольствием. "),
            (@"Припомним: [as well.... as] - так же хорошо ...., как. "), (@"[His father's] является сокращением от [his father's job]. "),
            (@"[Once] - однажды, [twice] - дважды, [three times] - трижды. "), (@"[A day's holiday] - однодневный отпуск, [a year's work] - годовая работа, [a five hour's walk] - пятичасовая прогулка. Притяжательная форма существительного (соответствует русскому родительному падежу; смотри урок 29 объяснение) употребляется в разных оборотах в отношении понятия времени и меры. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он работает меньше, чем его отец, но больше зарабатывает.",@"Не works less than his father but is paid more."),
            (@"Ее работа лучше моей.",@"Her job is better than mine."),
            (@"Прочитай упражнение дважды и произнеси его вслух.",@"Read the exercise twice and say it aloud."),
            (@"Газета, в которой он работает, называется «Звезда».",@"The paper for which he works is called ""The Star""."),
            (@"Мнение его жены о нем не очень хорошее.",@"His wife's opinion of him is not very good."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Жизнь этого человека очень увлекательна. Он - исследователь.", "That [man's ] life is fascinating. He's [an] explorer."),
            ( "Дважды в год ездим в Лондон повидаться с моей матерью.", "[Twice a ] year, we go [to ] London [to see my] mother."),
            ( "Фирма, в которой он работает, находится в Довере.", "The company [for which ] he works is based [in] Dover."),
            ( "Его работа не так хорошо оплачивается, как моя. ", "His [job ] is [not as well ] paid as [mine]."),
            ( "Сегодня вечером вернусь поздно, ", "[I'll ] be back [late] this evening."),
        };
    }
}
