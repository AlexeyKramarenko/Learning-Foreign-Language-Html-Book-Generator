using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_38 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид и Пит играют в дротики,", @"(Duvid and Pete are playing darts,)"),
            (@"2-Я хорош (в игре), Пит, но, думаю, ты (еще) лучше [лучший].", @"I'm good, Pete, but I think you're better"),
            (@"Нет, это неправда. Ох, шестьдесят! Может, ты и прав.", @"Mo, that's not true. Oh, sixty! Perhaps you're right."),
            (@"Эй, смотри, ты (стоишь) ближе, чем я. - Да, но я близорук,", @"Hey, look, you're closer  than  me. - Yes, but I'm short-sighted"),
            (@"Это не оправдание, (Ведь) ты видишь отсюда.", @"That's no excuse. You can see from here."),
            (@"Да, но не очень хорошо. Как бы то ни было, я не всегда выигрываю.", @"Yes, but not very well. Anyway, I don't always win."),
            (@"Но ты можешь купить напитки. Ты богаче, чем я.", @"But you can buy the drinks. You're richer than me."),
            (@"Хорошо. Что ты хочешь? - Хочу выиграть.", @"Alright. What do you want?  -I want to win."),
            (@"Пит богаче Дэвида, но Дэвид счастливее.", @"Pete is richer than David, but David is happier"),
            (@"Я больше тебя. -Да, но я умнее.", @"I'm bigger than you. - Yes, but I'm more intelligent"),
            (@"Как себя чувствует твой бедный отец? - Боюсь, что ему хуже.", @"How is your poor father? - He's worse, I'm afraid."),
            (@"Это самый лучший путь к музею.", @"This is the best way to go to the museum."),
        };

        public override string[] Notes => new[]
        {
            (@"<b>Better</b> - лучший - сравнительная степень от good - хороший. Прилагательные и наречия (good также является наречием - хорошо) имеют регулярные и нерегулярные сравнительные и превосходные степени. Нерегулярные следует запомнить, как, напр., good, better, best - лучше всего. "),
            (@"<b>Closer</b> - ближе - является примером слова с регулярным способом образования сравнительной и превосходной степени. В сравнительной степени к основе слова присоединяется окончание -еr, а в превосходной -est. Такие же правила распространяются на слова, состоящие из одного или двух слогов. Close, closer, closest - ближе всего. "),
            (@"В предложении после сравнительной степени используем слово than - чем. <b>You're closer than me</b> - Ты ближ:е, чем я. "),
            (@"<b>Short-sighted</b> - близорукий, long-sighted - дальнозоркий, colour-blind - дальтоник. "),
            (@"Anyway - как бы то ни было. "),
            (@"<b>То win</b> - выигрывать в какой-либо игре либо выигрывать  какой-либо приз, награду. <b>То earn</b> - зарабатывать деньги.  "),
            (@"<b>Happy, happier, happiest</b> - если прилагательное заканчивается буквой у, перед которой стоит согласная, в присоединенных окончаниях степеней сравнения у заменяем на i. "),
            (@"<b>Big, bigger, biggest</b> - если прилагательное представляет собой односложное слово, заканчивающееся на согласную, перед которой стоит гласная, при образовании степеней сравнения упомянутая согласная удваивается. "),
            (@"Многосложные прилагательные образуют сравнительную и превосходную степень с помощью слов more - более и most - самый. <b>Intelligent, more intelligent, most intelligent.</b> Это также регулярный способ словообразования. "),
            (@"<b>Bad, worse, worst</b> - плохо, хуже, хуже всего. А это очередной пример нерегулярного словообразования. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Боюсь, что не вижу. Я близорук.", @"I'm afraid I can't see. I'm short-sighted."),
            (@"Как дела у твоей бедной дочери? - Значительно лучше.", @"How is your poor daughter? - Much better."),
            (@"У нас совсем нет денег.", @"We've got no money at all."),
            (@"Он всегда выигрывает, когда играем в покер.", @"He always wins when we play poker."),
            (@"Она зарабатывает больше (денег), чем ее отец.", @"She earns more money than her father."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Лучший игрок выиграет матч.", "[The best] player will win the match."),
            ( "Oн богаче, но она счастливее.", "He is [richer] but she is [happier]."),
            ( "Твои глаза больше, чем твой желудок.", "Your [eyes] are [bigger than] your stomach."),
            ( "У меня нет никаких денег и никаких проблем. ", "I've got [no] money and [no] problems."),
            ( "Он самый плохой студент в группе [классе].", "He [is] the [worst] student [in] the class."),
        };
    }
}
