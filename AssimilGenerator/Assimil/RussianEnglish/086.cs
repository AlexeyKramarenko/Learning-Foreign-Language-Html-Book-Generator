using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_86 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Родители Дэвида провели традиционное английское воскресенье:",@"David's parents spent* a traditional English Sunday:"),
            (@"Они встали рано и пошли в церковь.",@"They got* up early and went* to church."),
            (@"Когда они вернулись, миссис Вилсон поставила [положила] жаркое в духовку,",@"When they came* back, Mrs Wilson put* the joint in the oven"),
            (@"в то время как мистер Вилсон взял воскресную газету и сел, чтобы ее прочитать.",@"while Mr Wilson took* the Sunday paper and sat down to read*,"),
            (@"Перед ланчем он налил две рюмки хереса, (которые) они оба выпили.",@"Just before lunch, he poured two glasses of sherry and they both drank*."),
            (@"Миссис Вилсон подала еду, и они сели есть.",@"Mrs Wilson served the food and they sat* down to eat."),
            (@"После ланча, который состоял из говяжьего жаркого, картошки, брюссельской капусты и фруктов,",@"After lunch, which consisted of roast beef, potatoes and Brussels sprouts and fruit,"),
            (@"они оба вымыли посуду.",@"they both did the washing-up."),
            (@"Когда все было сложено (на свое место), миссис Вилсон вышла в сад,",@"When everything was put* away  , Mrs Wilson went* into the garden"),
            (@"а мистер Вилсон уселся перед телевизором.",@"and Mr Wilson sat* in front of the television."),
            (@"Он собирался посмотреть пьесу, но был (настолько) сыт, а все (увиденное) было таким спокойным, что [он] задремал.",@"He was intending to watch a play, but he was full ®, and everything was so peaceful that he dozed."),
            (@"Позже миссис Вилсон вернулась из сада и приготовила чай.",@"Later on, Mrs Wilson came* in from the garden and made* some tea."),
            (@"Вечером мистер Вилсон разгадывал кроссворд, в то время как миссис Вилсон вязала на спицах.",@"In the evening, Mr Wilson did the crossword while Mrs Wilson did some knitting."),
        };

        public override string[] Notes => new[]
        {
            (@"[While] - здесь: когда. "),
            (@"[To put, put, put] - положить, отложить. [To put away] - отложить; [to put back] - положить обратно; [to put on] - надеть на себя одежду; [to take off] - снять. "),
            (@"[To be full] - быть сытым. [I am full up] - Я сыт. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мы пришли бы вдвоем, если б у нас были деньги.",@"We would both come if we had the money."),
            (@"В то время как он читал, дети дрались.",@"While he was reading, the children were fighting."),
            (@"Ты всегда должна говорить правду.",@"You should always tell the truth."),
            (@"Когда поставишь жаркое в духовку, выпьем по рюмочке хереса.",@"When you have put the joint in the oven, we'll have a glass of sherry."),
            (@"Вы ведь вдвоем вымоете посуду?",@"Will you both do the washing-up please?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я хочу, чтобы вы оба отложили посуду. ", "I [want ] you [both to ] put [away] the dishes."),
            ( "Перед тем как посмотреть пьесу у ты должен прочитать текст.", "[Before watching ] а [play ], you [should read] the text."),
            ( "(Хватит!) Мне это надоело! Сиди перед телевизором и веди себя тихо.", "I'm fed up! [Sit in front of] the television and [keep quiet]."),
            ( "Пока ты читаешь газету, я вздремну немного. ", "[While] you [are reading ] the paper, [I'll doze] а little."),
            ( "Он налил виски, когда они сидели. ", "Не [poured ] а whisky [while ] they [were sitting down]."),
        };
    }
}
