using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_62 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Шотландия наполовину меньше Англии, но населения (в ней) значительно меньше.",@"Scotland is half as big as England but the population is much smaller."),
            (@"Есть два главных региона (в Шотландии): на севере Хайлэндз - (горы), которые (считаются) дикими и прекрасными,",@"There are two main regions: in the north, the Highlands which are wild and beautiful"),
            (@"а на юге Лоулэндз - (низины), которые более (приспособлены для земледелия) [земледельческие].",@"and in the south, the Lowlands which are more agricultural."),
            (@"Хотя Эдинбург и является столицей, Глазгоу - главный промышленный центр.",@"Although Edinburgh is the capital, Glasgow is the main industrial centre."),
            (@"Шотландия была отделена от Англии стеной, построенной римским императором Адрианом.",@"Scotland was separated from England by a wall, built* by the Roman emperor Hadrian."),
            (@"Части той стены существуют и поныне.",@"Parts of this wall still exist today."),
            (@"Некоторые старые люди все еще говорят на гаэльском языке, но большинство шотландцев говорит на английском.",@"Some older people still speak* Gaelic, but most Scots ® speak* English."),
            (@"Шотландские города выглядят иначе, чем английские.",@"Scottish towns look very different from English ones."),
            (@"В английских городах дома главным образом построены из красного кирпича,",@"In English towns, the houses are mainly built of red brick,"),
            (@"в то время, как в Шотландии дома - в основном из серого камня (сланца).",@"whereas in Scotland, the houses are mainly of grey slate."),
            (@"Самая высокая британская гора, Бен Нэвис, находится в Шотландии.",@"Britain's highest mountain, Ben Nevis, is in Scotland."),
            (@"Шотланцы имеют свою религию, называемую пресвитерианство, и свои собственные права.",@"The Scots have their own religion, called Presbyterianism, and their own laws."),
            (@"Таким образом, хотя Шотландия и является частью Великобритании,",@"So, although Scotland is part of Great Britain,"),
            (@"она никогда не была объединена с Англией [таким же образом], как Уэльс.",@"it has never been united with England in the same way as Wales."),
        };

        public override string[] Notes => new[]
        {
            (@"Слово [Scots] - шотландцы - является одновременно прилагательным: а Scots village (или a Scottish village) - шотландская деревня. [Scotch] значит только шотландское виски."),
            (@"[In the same way] - таким же образом. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Шотландия наполовину меньше Англии.",@"Scotland is half as big as England."),
            (@"Большинство населения [людей] Шотландии говорит по-английски.",@"Most people in Scotland speak English."),
            (@"... хотя некоторые старые люди все еще говорят на гаэльском языке.",@"... although some older people still speak Gaelic."),
            (@"Английский - легкий для изучения,  тогда как гаэльский - сложный.",@"English is easy to learn, whereas Gaelic is complicated."),
            (@"Конечно, это мое личное мнение.",@"Of course, that is my own opinion."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Хотя мы и шотландцы, ни я, ни моя жена не говорим по-гаэльски.", "[Although ] we [are] Scottish, [neither ] I [nor ] my wife [speak] Gaelic."),
            ( "Дома в основном построены из сланца. ", "The houses are [mainly built of slate]."),
            ( "Шотландские города выглядят очень разнообразно. ", "[Scottish ] towns [look] very different."),
            ( "Это моя собственная брошюра. Возьми его (брошюру). ", "This is [my own ] brochure. Take [his]."),
            ( "Он не произносит это так [таким же образом], как я.", "Не doesn't [pronounce ] it [in ] the same [way ] as [me]."),
        };
    }
}
