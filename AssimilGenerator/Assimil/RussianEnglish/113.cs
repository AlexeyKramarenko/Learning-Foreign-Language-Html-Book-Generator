using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_113 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"- У меня была проблема на прошлой неделе, сказал мистер Хинд своему приятелю, инспектору.", @"' I had* a problem last week, said Mr Hind to his friend the inspector."),
            (@"Когда мой отец умер, я унаследовал его состояние в несколько миллионов фунтов.",@"When my father died, I inherited his fortune of several million pounds."),
            (@"Но на прошлой неделе пришел Грэг [чтобы встретиться со мной]. Он был садовником,",@"But, last week, Gregg came* to see* me. He used to be the gardener"),
            (@"пока я не уволил его в декабре.",@"until I fired   him in December."),
            (@"Он мне сказал, что как раз перед тем, как умер мой отец, он работал под его окном",@"He told* me that, just before my father died, he was working outside his window"),
            (@"и услышал, как мой отец составлял новое завещание в пользу моего брата.",@"and he heard* Dad drawing* up   a new will in favour   of my brother."),
            (@"Мы с моим отцом поссорились из-за чего-то в конце ноября,",@"My father and I had argued about something at the end of November,"),
            (@"и было возможно, что он решил изменить завещание.",@"so it was possible that he decided to alter the will."),
            (@"Грэг сказал мне, что документ находится в его владении, и что он мог бы его мне продать за пятьдесят тысяч фунтов.",@"Gregg told* me that the document was in his possession and that he would sell* it to me for fifty thousand pounds."),
            (@"Oн сказал, что на нём стоит дата тридцать первое ноября, т.е. три дня после первого завещания,",@"He said it was dated November the thirty-first, three days after the first will,"),
            (@"поэтому он [документ] стоил больших денег (для меня).",@"so it was worth a lot of money to me."),
            (@"Когда я отказал ему, он попробовал торговаться со мной. Сперва попросил двадцать пять тысяч фунтов,", @"When I refused, he tried to bargain with me. First, he asked for twenty-five thousand pounds,"),
            (@"а потом, в конце концов [наконец], десять тысяч.",@"and then, finally, ten thousand."),
            (@"Надеюсь, что ты ему не дал ничего, сказал инспектор.",@"- I hope you didn't give him anything, said* the inspector."),
            (@"Только пинка под зад, сказал Хинд. В чем [какая] была ошибка Грэга? (Ответ находится в уроке 119.)", @"""Only my foot in his backside"", said* Hind.  What was Gregg's mistake? (The answer is in Lesson 119.)"),
        };

        public override string[] Notes => new[]
        {
            (@"[To fire] - уволить с работы, выбросить, выгнать, выжечь; [to fire а gun] - выстрелить из ружья, пистолета; [fire] - огонь. "),
            (@"[То draw up] - формулировать, составлять, редактировать', [to draw, drew, drawn] - рисовать."),
            (@"[In favour] - в чью-нибудь пользу, [favour] - доброжелательность, благосклонность."),
            (@"[То alter] - изменить, переменить, переделать. [То alter the will] - изменить завещание."),
            (@"[To be dated] - датированный, отмеченный датой; [date] - дата, свидание. "),
            (@"[То bargain] - торговаться; bargain - оказия, возможность. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он работал здесь прежде, чем его уволили.",@"Не used to work here until he was fired."),
            (@"Я привыкла работать до десяти часов каждый вечер.",@"I am used to working until ten o'clock every night"),
            (@"Этот ковер - выгодная покупка, всего лишь двадцать три фунта.",@"This carpet is a bargain, only twenty-three pounds."),
            (@"Надеюсь, что ты ему ничего не дал.",@"I hope you gave him nothing."),
            (@"Он сказал, что продаст его мне, если захочу.",@"He said he would sell it to me if I wanted."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Как ты намереваешься это сделать? Попрошу помощи.", "How [are you going] to do it? - I [will ] ask [for] help."),
            ( "Надеюсь, что они не перестроят этот дом, он такой красивый.", "I hope they [won't alter] this [building], it's [so] beautiful."),
            ( "Oн спросил меня, как у тебя дела, и я сказал ему, что тебя не видел.", "Не asked me [how ] you [were] and I [told] him I [had] not [seen] you."),
            ( "Сперва он попросил у меня три тысячи фунтов, потом две, а в конце концов тысячу.", "[First] he asked me [for] three [thousand], [then] two and [finally one] thousand."),
            ( "Это стоит столько денег, что никто это не купит. ", "It is [worth so much] money that [no one/nobody] will buy it."),
        };
    }
}
