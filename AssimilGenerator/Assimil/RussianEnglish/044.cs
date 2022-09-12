using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_44 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дай мне этот бумажник, он мой.",@"Give me that wallet, it's mine."),
            (@"Откуда ты это знаешь? - (Это) просто [хорошо], он не твой, а внутри есть десять фунтов.",@"How do you know? - Well, it's not yours, and there are ten pounds inside it."),
            (@"Он одалживает (у меня) мои вещи, но недоволен, когда я одалживаю его (веш[и),",@"He borrows my things, but he isn't pleased when I borrow his."),
            (@"Эти люди все являются ее друзьями. Они хотят прийти на вечеринку.",@"These people are all friends of hers. They want to come to the party."),
            (@"Что, все? - Ну, может, только несколько из них.",@"What, all of them? - Well, perhaps only a few of them."),
            (@"Где моя ручка? <br> - Тут, ты можешь воспользоваться моей. <br> - Это очень любезно с твоей стороны.",@"Where is my pen?   <br> - Here, you can use mine.  <br> - That's very kind of you."),
            (@"Чей этот спортивный автомобиль?  <br> - [Он есть] их.", @"Whose is this sports car? <br> – It’s theirs"),
            (@"Я думаю [предполагаю], что они очень богаты. - Нет, Их дом меньше вашего.", @"I suppose they are very rich. - No, their house is smaller than yours."),
            (@"На самом деле/в действительности, они живут в палатке.",@"In fact, they live in a tent!"),
            (@"Циник",@"A cynic"),
            (@"Ты собираешься выйти замуж за Гарольда. Какой он?",@"So you're going to many Harold. What is he like?"),
            (@"Он честный, любезный, добрый, милый и благородный.",@"He's honest, kind, gentle, sweet and noble."),
            (@"А что ты будешь есть?",@"And what are you going to eat?"),
            (@"Циник - это человек, который знает цену всему",@"A cynic is a person who knows the price of everything"),
            (@"и (не знает меры) ценности ничего (Оскар Уайльд).",@"and the value of nothing (Oscar Wilde)."),
        };

        public override string[] Notes => new[]
        {
            (@"Нам уже знакомо слово [my] - мое, моя, мой. [Mine] значит то же самое, что [my], только после [my] должно стоять существительное, которое после [mine] не употребляется, но мы точно знаем, что в каждом конкретном случае под [mine] подразумевается. В этом предложении [mine] заменяет словосочетание [my wallet]. "), (@"[Yours] - твой, заменяет в предложении [your wallet]. "),
            (@"[Inside] - внутри. "),
            (@"[То be pleased] - быть довольным. "),
            (@"[His] - его, заменяет в этом предложении [his things]. "),
            (@"[Friends of hers] = her friends. "),
            (@"[Theirs] - их, заменяет в этом предложении [their car]. "),
            (@"[What... like?] - какой, какая, какие? [What's he like?] - Какой он (есть)? "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Чьи это ручки? - Мои.",@"Whose are these pens? - They are mine."),
            (@"Хочу одолжить одну из твоих книжек.",@"I want to borrow one of your books."),
            (@"Я довольна, поскольку знаю, что ты собираешься поехать на каникулы.",@"I'm pleased to know that you're going on holiday."),
            (@"Она все еще хочет выйти замуж за миллионера.",@"She still wants to marry a millionaire."),
            (@"Он беднее меня. На самом деле, у него нет денег!",@"He's poorer than me. In fact, he has no money!"),
            (@"Спасибо, это очень любезно с твоей стороны.",@"Thank you, that's very kind of you."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Это не твое, это мое. ", "It's [not yours], it's [mine]."),
            ( "Чья эта палатка? -Это их. ", "[Whose] is this [tent]? - It's [theirs]."),
            ( "Он берёт взаймы не кошелек [не одалживает кошелька], но деньги внутри него.", "Не [doesn't borrow] the [wallet] but the money [inside it]"),
            ( "Цена и ценность — это не то же самое. ", "[Price] and [value] [are] not the same [thing]."),
            ( "У тебя новый спортивный автомобюгъ. Какой он [есть]?", "You've got а [new sports car]. What's [it like]? "),
        };
    }
}
