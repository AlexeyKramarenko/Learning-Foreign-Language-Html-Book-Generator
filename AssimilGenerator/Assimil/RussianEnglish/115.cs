using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_115 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Немного больше примеров со (словами) make и do.",@"Some more examples of ""make"" and ""do"":"),
            (@"Он делает фильм об условиях жизни в крестьянском селе.",@"He is making* a film about living conditions in a peasant  village."),
            (@"Мне нужна была его помощь, но все, что он мог сделать, так это шутить.",@"I needed his help, but all he could do* was make jokes."),
            (@"Они заняты подготовкой к [своим] каникулам.",@"They are busy making preparations for their holiday."),
            (@"От запаха хорошей еды у меня текут слюнки.",@"The smell of good cooking makes my mouth water"),
            (@"Ты собираешься выйти замуж за миллионера? Не смешр! меня»",@"You're going* to marry a millionaire? Don't make me laugh!"),
            (@"У меня нет [никакого! кофе, ты должна удовлетвориться чаем.", @"I have no coffee, you'll have to make do with   tea."),
            (@"У него всегда получается рассердить меня.", @"He always succeeds   in making me angry,"),
            (@"Определись, пожалуйста, у нас немного времени, а магазин закрывается [магазин намеревается закрыть].",@"Please make up your mind, we don't have very much time and the shop is going to close."),
            (@"На что ни посмотришь сейчас, увидишь: ""Сделано в Гонконге"".",  @"Whatever you look at nowadays, you will see*: ""Made in Hong Kong."""),
            (@"Гости госпожи Ричарде восхищались большим чучелом акулы, которая была прикреплена у неё на стене,",@"Mrs Richard's guests were admiring a large stuffed ® shark that was mounted on her wall."),
            (@", - Мы с моим мужем поймали ее во время рыбной ловли, с гордостью сказала хозяйка,",@"- My husband and I caught* it on a fishing trip, said* the proud owner."),
            (@"- Чем она набита? - спросила одна из женщин.",@"- What is it stuffed with? asked one lady."),
            (@"- ""Моим мужем"", ответила хозяйка.", @"""- My husband"", replied their hostess."),
        };

        public override string[] Notes => new[]
        {
            (@"Обратите внимание на произношение [peasant] (peznt) - оно произносится так же, как [head, pleasant, dead]. Соединение двух гласных еа, как правило, произносится как [е]."),
            (@"[To make one's mouth water] - переводится с помощью фразеологизма: у кого-нибудь текут слюнки."),
            (@"[То make do with something] - удовлетвориться чем-л. "),
            (@"[То succeed] - наступать (после чего-либо), унаследовать, пользоваться успехом, получиться, удаться."),
            (@"[То make up one's mind] - решиться, определиться. "),
            (@"[То stuff]- набить, затыкать (щели), конопатить, [stuffed] - набит, с начинкой, [stuffing] - начинка, фарш. [Do your  stuff] - делай то, что тебе надо. [Hurry up and make your stuff] - Торопись и продвигайся. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Она никогда не может решиться, когда делает покупки.",@"She can never make up her mind when she is shopping."),
            (@" Они заняты подготовкой к отъезду.",@"They are busy making preparations for their departure."),
            (@"Не смеши меня! Это серьезная пьеса.", @"Don't make me laugh! This is a serious play."),
            (@"Что будет, если я не повторю свой (материал)?",@"What will happen if I don't do my revision?"),
            (@"Почему я всегда должен выполнять всю работу?",@"Why must I always do all the work?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "У меня нет кофе, ты должна удовлетвориться чаем. ", "I haven't [got any] coffee, you'll have to [make do with] tea."),
            ( "Что ни пробую сделать, (у меня) все получается. ", "[Whatever] I try [to do ] I [succeed]."),
            ( "Ты должен решиться: нет больше времени. ", "You must [make up ] your mind; there is [no more] time."),
            ( "Зимой в Англии всегда холодно? ", "[Is it ] always cold [in ] England [in winter]? "),
            ( "Из чего это сделано? Из муки, яиц и масла. ", "[What ] is this made [with ]? - With [flour eggs ] and [butter]."),
        };
    }
}
