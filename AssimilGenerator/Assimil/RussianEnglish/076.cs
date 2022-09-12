using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_76 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Что я могу для Вас сделать (чем могу вам помочь), сэр? - Я хотел бы поговорить с мистером Дэвисом.", @"What can I do for you, sir? - I'd like to speak* to Mr. Davis."),
            (@"К сожалению [извините], его нет. Может быть, вы хотели бы увидеться с кем-то другим?",@"I'm sorry, he isn't in. Would you like to see* somebody else?"),
            (@"Нет, но не захотели бы вы (не были бы вы так любезны, чтобы) принять от меня сообщение.",@"No, but would you take* a message for me, please?"),
            (@"С удовольствием.",@"I'd be delighted."),
            (@"""Would"" используется в условных конструкциях в английском языке и ставится перед инфинитивом.",@"""Would"" is the conditional in English and is placed in front of the infinitive."),
            (@"Сокращенный вариант этой формы прост: ""Would"" трансформируется в 'd,",@"The contraction is easy: ""Would"" becomes* ... 'd."),
            (@"Например: <br> Я хотел бы чашечку чая.	",@"For instance: I'd like a cup of tea."),
            (@"Он тебе поможет. Мы хотели бы пиво, если у тебя есть [какое-нибудь].",@"He'd help you. We'd prefer beer, if you have any."),
            (@"Вопросительные конструкции также просты: Ты хотел бы чашечку чая? Ты хотел бы мне помочь?",@"Questions are easy, too: Would you like a cup of tea? Would you help me please?"),
            (@"Вот немного больше примеров: Он бы понял, если бы ты говорил гораздо медленне.", @"Here are some more sentences: He would understand* if you spoke* more slowly."),
            (@"Он не попросил бы помощи, если б не хотел этого.",@"He wouldn't ask for help if he didn't want it."),
            (@"Он не нуждался бы в учителе, если б говорил бегло.",@"He wouldn't need a teacher if he spoke* fluently."),
            (@"Известный юрист проиграл дело и был очень зол.	A famous lawyer had lost* a case and was very angry.",@"A famous lawyer had lost* a case and was very angry."),
            (@"„Если это закон, - кричал он, - то я сожгу свои книги!'*",@"""If this is the law, he shouted, I'll burn* my books!"""),
            (@"Судья отвечал: ""Было бы лучше, если вы их прочитали"".",@"The judge replied: ""It would be better if you read* them."""),
        };

        public override string[] Notes => new[]
        {
            (@"[To take a message] - принять сообщение, информацию. [To leave a message] - оставить сообщение, информацию. [Any messages?] - Есть какие-то (новости), известия? "),
            (@"[I'd be delighted] - оборот вежливости - очень приятно, с удовольствием, я очень рада [восхищена]. "),
            (@"[Would] выступает в выражении [would like to] - хотела бы и в условных предложениях. Вопросительные конструкции  строятся с помощью инверсии (изменения порядка  слов): Would you like to come? - Хотел бы ты прийти?,   а отрицательные - вводом not: [I would not (wouldn't) like to go] - Я не хотел бы идти. "),
            (@"В английском языке существуют три разновидности условных предложений. В данном случае перед нами вторая из них. В одной части сложного предложения выступает [would] с основной формой глагола, а в другой [if] - если, если бы и глагол в прошлом времени (Past Simple). Очередность этих частей сложного предложения может быть произвольной, но после [If] не может выступать would. [If he comes, I would be happy] - Если бы он пришел, я была бы счастлива. "), (@"[Case] - случай, судебное дело. [In this case] - в таком случае. "),
            (@"Следует помнить о правильном произношении форм: to read [ri:d], [red], [red]  - читать."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я это купил бы, это очень дешево.",@"I would buy it. It is very cheap."),
            (@"Он не позволяет мне пользоваться своим автомобилем по выходным [во время уикэндов].",@"He doesn't let me use his car at weekends."),
            (@"Я боюсь, что он еще не вернулся.",@"I'm afraid he isn't back yet."),
            (@"Я боюсь, что он еще не вернулся.",@"I'm afraid he isn't back yet."),
            (@"Что бы ты сделал, если б у тебя было много денег?",@"What would you do if you had a lot of money?"),
            (@"Как бы ты себя чувствовал, если б кто-нибудь тебя ударил?",@"How would you feel if someone kicked you?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Хочешь немного кофе? - Я хотел бы чаю, если у тебя есть [какой-то]?", "[Would ] you [like ] some coffee? - I [would prefer] tea if you have [any]."),
            ( "Я не хотел бы быть на твоем месте! ", "I [wouldn't ] like [to be ] in your place!"),
            ( "Кого бы ты хотел увидеть первым? ", "Who [would you ] like [to see] first?"),
            ( "Она бы купила немного, если б у нее были [имела] деньги.", "She [would ] buy [some ] if she [had some] money."),
            ( "Мы не хотели бы тебе мешать. ", "We [wouldn't] like to disturb you."),
        };
    }
}
