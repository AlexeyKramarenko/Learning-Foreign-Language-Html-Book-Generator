using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_1 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Knowledge of English is vital in today’s fast—moving world; (1)",@""),
            (@"it is spoken by some three hundred and sixty million people (2)",@""),
            (@"and is the tool of communication in so many fields that we will not even attempt to number them.",@""),
            (@"But the language we hear today is not the language of the people who live in the British isles. (3)",@""),
            (@"Of course, that is where it all started, but, for several hundred years,",@""),
            (@"different peoples and ethnic groups have added their own particular contributions to English (4)",@""),
            (@"so that what we hear and speak now is truly a << United Nations» of languages.",@""),
            (@"But why is English so widespread ? Why not French or Spanish — both major languages —",@""),
            (@"or even Esperanto, the international language ?",@""),
            (@"Apart from the enormous influence of the United States (although some claim that American is a separate language),",@""),
            (@"and the extent of Britain's old colonial empire, which at one time spanned onethird of the surface of the globe, (5)",@""),
            (@"the real answer is that English is an extremely flexible language — it is structurally closer to Chinese than to its European cousins!",@""),
            (@"Words can be nouns or verbs: <b>a chair</b> becomes <b>to chair</b> with no complexes; (N 1)",@""),
            (@"up can be an adverb, a prepositign, 3 noun, an adjective or even a verb.",@""),
            (@"Neologisms — made-up words — enter the language on tiptoe so that nobody notices, (6)",@""),
            (@"and different trades, crafts and sciences give us new expressions every week.",@""),
            (@"It is because of this wealth that we need a guide to help the speaker and the writer to use English,",@""),
            (@"so follow us now on our trip through the highways and byways of the English language.  (7)",@""),
        };

        public override string[] Notes => new[]
        {
            (@"Мы все еще знаем, что вы достаточно хорошо знаете язык Английский, мы позволяем себе время от времени, и прежде всего в начале нашего спектакля напомним некоторые моменты, которые мы считаем важными. Итак, в этом сначала напишите нам знания (знания) нет определенной статьи, потому что мы считаем это знание используется в более широком смысле, поэтому не определено. Мы вернемся к этому пункту с более подробной информацией.  подробно в уроках 9 и 10. Давайте также вспомним que fast (быстро) одновременно является прилагательным и наречием"),
            (@" миллион не берет. да, но в неточных выражениях, Это как миллионы людей (миллионы людей)."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"I hesitated for a week and he upped the price by twenty percent.",@""),
            (@"Yes, and that’s just the tip of the iceberg.",@""),
            (@"The United Nations represents the peoples of the world.",@""),
            (@"The Verrazano Narrows Bridge in New York harbor has a span of 4,260 feet, the longest in the world.",@""),
            (@"Plastics are a by-product of oil refining.",@""),
            (@"Since the Managing Director is absent, Mr Barney will chair today’s meeting",@"")
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( @"Наш опыт [охватывает] весь спектр навыков проектирования и производства.", "Our experience [spans] the whole range of designing and manufacturing skills."),
            ( @"", @"[Knowledge] is vital in today's world and [the knowledge] you have acquired by studying this method will be of great value."),
            ( @"", @"The bank lost [millions] of dollars in the deal, exactly fifty-two [million]."),
            ( @"", @"She [tiptoed] past the living room and slipped out of the front door."),
            ( "", "There are so many dialects [that what] we speak is not really English."),
        };
    }
}
