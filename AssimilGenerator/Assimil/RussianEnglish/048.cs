using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_48 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Как далеко (отсюда) до вокзала? - Не очень далеко.",@"How far is it to the station? - Oh, not too far."),
            (@"Около десяти минут пешком и только две на машине.",@"It takes about ten minutes on foot and only two by car."),
            (@"Вызвать тебе такси? - Нет, спасибо, я прогуляюсь. У меня много (свободного) времени.",@"Shall I call you a taxi? - No thanks, I'll walk. I have plenty of time."),
            (@"Социолог исследует средний (среднестатистический) рост англичан.",@"A sociologist is studying the average height of the English."),
            (@"Знаешь ли ты, - говорит он своей девушке, - только один англичанин из 920 имеет шесть футов роста [высоты]?",@"Do you know, he says to his girlfriend, only one Englishman in nine hundred twenty (920) is six feet tall ®?"),
            (@"Да, - говорит девушка, - но это всегда тот,",@"Yes, says the girl, but it's always him"),
            (@"который сидит передо мной в кинотеатре.", @"that sits in front of me in the cinema."),
            (@"Бизнесмен пишет конкуренту, который очень нечестен:", @"A businessman is writing to a competitor who is very dishonest :"),
            (@"„Поскольку моя секретарь - леди, она не может Вам сказать, что я о Вас думаю;",@"""As my secretary is a lady, she cannot tell you what I think of you,"),
            (@"a поскольку я джентльмен, я не могу даже думать о таком;",@"and as I am a gentleman, I cannot even think it;"),
            (@"но поскольку Вы не являетесь ни тем, ни иным,",@"but as you are neither one or the other,"),
            (@"надеюсь, Вы (меня) понимаете!",@"I hope you understand!"),
        };

        public override string[] Notes => new[]
        {
            (@"Вспомним употребление глагола [to take] - см. урок 18, объяснение 3. Повторим предложение из этого урока по памяти."),
            (@"[Plenty of] - много - используется в разговорной речи значительно чаще, чем синонимичные слова [much] и [many]. "),
            (@"[The English, the Russian] - англичане, русские, но [an Englishman] - англичанин, а [Russianman] -русский."),
            (@"[One in nine hundred twenty] - один из девятисот двадцати. "),
            (@"[Tall] - высокий. [How tall are you?] - Какого ты роста? (Насколько ты высокий?) [It is six feet tall and three feet wide] - Это шесть футов высотой и три фуута шириной."),
            (@"[Honest] - честный, [dishonest] - нечестный. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Как много времени занимает дорога до вокзала?",@"How long does it take to go to the station?"),
            (@"Нет, спасибо, мы пойдем пешком.",@"No thanks, we'll go on foot."),
            (@"Кто сидит перед ними? <br/> -Я думаю, это Джордж,",@"Who is sitting in front of them? <br/> -I think it's George."),
            (@"Что ты думаешь об этом уроке?",@"What do you think of this lesson?"),
            (@"Только один мужчина из двадцати носит шляпу.",@"Only one man in twenty wears a hat."),
            (@"Сколько составляет средняя зарплата в Англии? <br/> - Не достаточно!",@"How much is the average salary in England ? <br/> -Not enough!"),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Ни Поль, ни я не мо.жем прийти завтра. Извините. ", "[Neither ] Paul [nor ] I [can ] come tomorrow. I'm [sorry]."),
            ( "Эти упражнения займут (отнимут) только полчаса. ", "[These ] exercises [only take ] half an hour [to do]."),
            ( "Какого ты роста? Не могу сказать тебе (сколько будет) в метрах.", "How [tall] are you? -I [cannot] tell you [in] meters. "),
            ( "Просить ли его, чтобы позвонил тебе завтра в шесть?", "[Shall ] I ask [him ] to phone [you ] tomorrow [at ] six [o'clock]?"),
            ( "Можем пойти пешком. У нас много времени. ", "We [can ] go [on foot ]: we have [plenty of] time."),
        };
    }
}
