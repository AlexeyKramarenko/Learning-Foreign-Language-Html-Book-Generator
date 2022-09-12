using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_106 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Мы должны решить, куда поедем в [наш] отпуск.",@"We must decide where to go for our holidays,"),
            (@"Мы должны были (это) решить [несколько] месяцев назад.",@"We should have decided  months ago;"),
            (@"Я буду внизу через минуту.  Я должен закончить [эту] статью, которую пишу.",@"I’ll be down in a minute, I’ve got to  finish this article I’m writing*."),
            (@"У тебя есть все, что нужно? <br> - Да, спасибо.",@"Have you got everything you need? <br> - Yes thanks."),
            (@"""Джоэн взяла брошюру и прочитала: „Чтобы получить место наверняка [быть уверенным в получении места], необходимо заблаговременно (его) забронировать"".",@"Joan picked up a brochure and read*: ""To be sure of obtaining a place, it is necessary to book  well in advance  ."""),
            (@"И  другой: ""Следует зарезервировать (место) рано, чтобы избежать (времени наибольшего) спроса"".",@" And, in another one: ""You must book early to avoid the rush  ."""),
            (@"Джоэн была очень раздражена, потому что была уже середина июня, а они ничего не сделали.",@"Joan was very angry because it was already the middle of June and they had done nothing."),
            (@"Что ж, если намереваешься что-то сделать, следует это делать должным образом, - подумала она.",@"Well, if you're going to do something, you should do it properly, she thought*."),
            (@"Она посмотрела на кипу брошюр, а потом вышла (чтобы) приготовить [сделать] чашку чая.",@"She looked through the pile of brochwies and then went to make* a cup of tea."),
            (@"Дэвид, закончив статью, сошел вниз.",@"David, having finished his article, came* downstairs."),
            (@"Он остановился и поднял почту с коврика.",@"He stopped and picked up the post from the mat."),
            (@"О, ещё брошюры [по-прежнему больше брошюр]. У нас их больше, чем нам требуется.", @"Oh look, still more brochures. We've got more than we need."),
            (@"Джоэн была в ярости: [Тебе] нужен кусок динамита, чтобы привести тебя в движение, - крикнула она.", @"Joan was furious: ""You need a stick of dynamite to move you, she shouted."""),
            (@"Ой, перестань, не сердись. Приготовь [сделай] чай.", @"Oh come on, don't be angry. Make* the tea."),
            (@"Приготовь [сделай] себе сам! -крикнула Джоэн и вышла, хлопнув дверью.", @"Make* it yourself! shouted Joan and went out slamming the door."),
            (@"Дэвид почесал голову: ""А что я сделал?""",@"David scratched his head: - But what did I do? "),
        };

        public override string[] Notes => new[]
        {
            (@"Найдите в объяснениях к предыдущим урокам подобные конструкции. Вскоре поговорим о них подробнее. "),
            (@"Конструкция [I've got to] может использоваться наравне с [I have to] - Я должен, "),
            (@"[То book] - бронировать, резервировать; [booking] - бронь,  резервация; [а book] - книга. "),
            (@"[In advance] - раньше, заблаговременно. "),
            (@"[То rush] - спешить, бросаться, мчаться; [rush] - напор,  наплыв, спрос, суета; [rush hours] - час пик. "),
            (@"[Post] - почта, корреспонденция; [to post, to mail] - выслать; [post office] - почта; [G.P.0 - General Post Office] - главпочтампт. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Нам следовало [мы должны были] это купить, когда у нас были деньги.",@"We should have bought it when we had the money."),
            (@"Она пыталась избежать ссоры. ",@"She was trying to avoid an argument."),
            (@"Он вышел, тихо закрывая двери.",@"He went out closing the door quietly. "),
            (@"У тебя мог быть [ты могла иметь] грипп [вспышка гриппа].",@"You might have a touch of  flu."),
            (@"Ты можешь это одолжить, но не можешь этого оставить (у себя).", @"You may borrow it but you can't keep it."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Вы должны забронировать заблаговременно для того, чтобы избежать ожидания.", "You [must book ] in advance in [order ] to [avoid] waiting."),
            ( "У тебя есть все, что тебе нужно? ", "Have you [got ] everything you [need]? "),
            ( "Я должен закончить этот роман прежде, чем он меня об этом попросит.", "I've [got to ] finish this [novel ] before he [asks ] me [for] it."),
            ( "Прекрати! У меня больше, чем мне нужно. ", "[Stop ]! I've got [more than I need]."),
            ( "Мне следует идти, я должен быть на встрече с врачом.", "I [must ] go, I've got an [appointment ] with the [doctor]."),
        };
    }
}
