using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_82 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Прочитайте этот урок как обычно и когда закончите, ответьте на вопросы.",@"Read* this lesson as usual and when you have finished ® it, answer the questions."),
            (@"Какая разница существует между городом и метрополией?",@"What is the difference between a city and a town?"),
            (@"Где бы вы нашли кафедральный собор?",@"Where would you find* a cathedral?"),
            (@" Англия так же (настолько же) централизована, как и Франция?",@"Is England as centralised as France?"),
            (@"Есть ли какая-то разница между между севером и югом Англии?",@"Are there any differences between the North and South of England?"),
            (@"Какому произношению вы учитесь?",@"Which  accent are you learning?"),
            (@"Какое графство называют ""садом Англии""?",@"Which county is called the ""Garden of England""?"),
            (@"В какой части страны находится Корнуолл?",@"In which part of the country is Cornwall ?"),
            (@"Вы когда-нибудь были в Англии?",@"Have you ever been to England?"),
            (@"Я хочу, чтобы вы все написали сочинение, - сказала учительница, мисс Смит, (обращаясь к) своему классу,",@"""I want you all to write* an essay"", said the teacher, Miss Smith, to her class,"),
            (@"о том, что бы вы сделали, если бы выиграли состояние.",@"about what you would do if you won* a fortune, "),
            (@"Каждый начал (что-то) писатъ за исключением Вилли, который смотрел в окно.",@"Everybody started writing*, except Willy who looked out of the window."),
            (@"В конце урока учительница собрала сочинения и увидела, что Вилли ничего не написал.",@"At the end of the lesson, the teacher collected the essays and saw that Willy had* written nothing."),
            (@"Но ты ничего не сделал, Вилли! - Это и есть то, что я сделал бы, если б выиграл состояние... ничего.",@"""But you've done nothing, Willy! - That's what I'd do if I won* a fortune... nothing."""),
        };

        public override string[] Notes => new[]
        {
            (@"Если предложение начинается с [when], но не является вопросительным, после [when] не следует использовать О будущего времени. "),
            (@"[Which] - здесь: которого, какого из двух названных. "),
            (@"Обратим внимание на структуру этого предложения и его перевод. [I want you all to write an essay] - Я хочу, чтобы вы все написали сочинение. Иные предложения с этой конструкцией приводятся в задании [Fill in the missing words]. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Что производит большее впечатление - Лондон или Бристоль?",@"Which is more impressive, London or Bristol?"),
            (@"Что бы ты сделал, если бы выиграл состояние?",@"What would you do if you won a fortune?"),
            (@"Потратил бы (так) быстро, прежде чем моя жена обнаружила бы это.",@"I'd spend it quickly before my wife discovered it."),
            (@"Ты когда-нибудь был в Турции?",@"Have you ever been to Turkey?"),
            (@"Нет, но хотел бы поехать.",@"No, but I’d like to go."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я хочу, чтобы ты мне сказал правду. ", "I want [you to tell] me the truth."),
            ( "Ее родители хотят, чтобы она вышла замуж: за миллионера.", "[Her ] parents want [her to] marry а millionaire, "),
            ( "Мы хотим, чтобы они хорошо отдохнули [получили удовольствие] во время своего (здесь) пребывания.", "[We ] want [them ] to [enjoy ] themselves [during their] stay. "),
            ( "Она хочет, чтобы я ей одолжил свою автомашину. Что ты об этом думаешь?", "She [wants me ] to lend [her ] my car, [what. ] do you think?"),
            ( "Я хочу, чтобы он понял, поэтому буду говорить медленно.", "[I ] want [him to ] understand,  [so ] I [will ] speak [slowly]."),
        };
    }
}
