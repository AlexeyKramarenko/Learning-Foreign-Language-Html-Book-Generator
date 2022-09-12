
using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_129 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Вот несколько идиоматических выражений, которые вы можете встретить, когда поедете в Англию.",@"Here are a few idiomatic expressions you might meet when you go to England:"),
            (@"Я сидел слишком долго: у меня затекла нога [иголки и булавки в ноге].",@"I've been sitting* down for too long; Fve got pins and needles in my foot."),
            (@"Он надел свое новое пальто наизнанку и можно было увидеть этикетку с ценой.",@"He put* on   his new coat inside out and you could see the price tag."),
            (@"Oн был очень открытым человеком, который называл вещи своими именами.",@"He was a very blunt man who called a spade a spade."),
            (@"Это нетрудно сделать, но нужно этому выучиться [знать один приём].",@"It's not difficult to do, but there's a knack  to it."),
            (@"Если ждешь автобус на остановке по требованию, ты должен поднять руку, чтобы автобус остановился.",@"If you wait for a bus at a request stop, you must put* out your hand to make* the bus stop."),
            (@"Мой муж меня не понимает, воспринимает меня как нечто само собой разумеющееся.",@"My husband doesn't understand* me, he takes* me for granted"),
            (@"Когда [ты] покупаешь в рассрочку, то делаешь первый взнос в 50 фунтов, а потом шестнадцать месячных выплат по восемь фунтов.",@"When you buy* on hire-purchase, you make* a down payment of fifty pounds and then sixteen monthly instalments of eight pounds,"),
            (@"Все фрукты испортились, но она не могла вынести мысли о том, чтобы их выбросить.",@"All the fruit had gone bad  , but she couldn't stand* the idea of throwing*   it away."),
            (@"Он строил из себя миллионера, но в действительности не имел ни гроша.",@"He pretended to be a millionaire, but actually he was broke."),
            (@"Мы должны отложить встречу аж до следующего четверга, так как ни у кого нет времени [никто (не) свободен].",@"We will have to put* off the meeting until next Thursday since nobody is free."),
            (@"Надеюсь, что вскоре поедим. Я умираю от голода!",@"I hope we can eat* soon.  I'm starved!"),
            (@"Папа спросил меня, хочу ли я спортивный автомобиль или яхту. Меня это не интересовало [я не хотел проявить ни малейшего внимания].",@"Daddy asked me if I wanted a sports car or a yacht.  I couldn't care less."),
            (@"Что там в Гаумонте на этой неделе? -Для меня это не имеет никакого значения [никакой разницы], у меня нет ни гроша.",@"What's on   at the Gaumont this week? - It doesn't make* any difference to me, I'm hard up."),
        };

        public override string[] Notes => new[]
        {
            (@"Вспомним выражения с глаголом [to put]. [То put on] - одеть, надеть одежду, положить нечто на что-то; [to  put out] - вытащить, поднять (строка 6); to put off - отлоэюить, переложить (строка 11). "),
            (@"[Blunt] - тупой; [sharp] - острый; [a blunt man] - открытый человек, говорящий откровенно; [а sharp man] - хитрый, ловкий, но в то же время быстрый и умный человек; [sharp practice] - обман. "),
            (@"[Knack] - талант, мастерство, проворство, приём. [There's а knack in it] - нужно этому научиться. "),
            (@"[Grant] - дар, пособие, дотация; [to take for granted] - быть заранее убежденным в чем-либо, воспринимать что-то как нечто само собой разумеющееся. "),
            (@"[То install] - инсталлировать, устанавливать, монтировать, оборудовать; [instalment] - рассрочка, задаток; [to pay by instalments] - платить в рассрочку; [to buy on hirepurchase] - купить в рассрочку. "),
            (@"[То go bad, to rot] - испортиться. "),
            (@"[To throw, threw, thrown] - бросать, опрокидывать; [to  throw away] - выбрасывать; [to overthrow] - свалить, снести у привести в упадок. "),
            (@"[To starve] - голодать, испытывать голод, недоедать, морить голодом. [То be starving] - умирать от голода, быть голодным, как собака. "),
            ("[What's on?] - что слышно, что там происходит, что играют?")
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Этот нож такой тупой, что не порежет (ничего).",@"This knife is so blunt that it won't cut."),
            (@"Через неделю все фрукты испортились,",@"After a week all the fruit had gone bad."),
            (@"Я неделями не ем, у меня нет ни гроша.",@"I haven't eaten for weeks. I'm broke."),
            (@"Он всегда откладывает свой визит к зубному врачу.",@"He always puts off his dentist's appointments."),
            (@"Не могу встать, у меня нога затекла.",@"I can't stand up, I've got pins and needles in my foot."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я не могу вынести этого человека, когда он строит из себя эксперта.", "I can't [stand ] that man when he [pretends] to be an expert."),
            ( "Я всегда без денег под конец месяца. - Я тоже. ", "I'm always [hard up ] at [the end ] of the month. - Me [too]."),
            ( "Это не трудно, но нужно этому научиться. ", "It's not difficult but [there's a knack] (to it)."),
            ( "Осторожно, не надевай перчатки наизнанку. ", "[Be ] careful! Don't [put ] your gloves on [inside out]."),
            ( "Можешь ломать, что хочешь, мне все равно. ", "You can break [what you like/want ], I couldn't [care less]."),
        };
    }
}
