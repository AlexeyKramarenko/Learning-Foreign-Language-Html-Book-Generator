using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_67 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"В прошлом месяце мы забрали нашего двоюродного брата, чтобы он посмотрел матч по крокету.",@"We took* my cousin to see* a cricket match last month."),
            (@"Но он заснул во время игры.",@"But he fell* asleep during the game."),
            (@"Спал спокойно два часа, пока мяч не ударил его по голове и не разбудил.",@"He slept* peacefully for two hours until a ball hit* him on the head and woke* him up."),
            (@"Привет, рад тебя опять видеть. Как ты себя чувствуешь?",@"Hello, it's nice to see* you again. How are you?"),
            (@"Очень хорошо. Я намериваюсь остаться с вами несколько дней,",@"Very well. I'm going to stay ® with you for a few days."),
            (@"А, да... я уезжаю завтра, а моя жена уехала два часа назад; - Что ж до свидания.",@"Ah, well, I'm leaving* tomorrow and my wife left* two hours ago ®. - Oh well, good bye."),
            (@"Госпожа Хиггинс сделала [поместила] надпись на могиле [на камне могилы] своего мужа. „Спи [отдыхай] спокойно .",@"Mrs Higgins put*  ""Rest in Peace"" on the tombstone of her husband's grave."""),
            (@"Потом адвокат сказал ей, что в завещании ее мужа ничего для нее не было,",@"Then the solicitor told* her that there was nothing for her in her husband's will."),
            (@"и вот она сказала каменщику, чтобы дописал [добавил] слова: ""пока я не приду"".",@"So she told* the mason to add the words ""until I come*""."),
            (@"В течение недели, попробуйте читать эту книгу как минимум полчаса в день [каждый день]",@"During the week, try to read* this book for at least half an hour every day,"),
            (@"И немножко больше на выходных.", @"and for a little longer at the weekend."),
            (@"Этот ежедневный контакт приведет к тому, что вы почувствуете себя как дома с английским",@"This everyday contact will make* you feel* at home with English"),
            (@"и поможет вам расширить лексический запас [строить обширную лексику], но запомните:",@"and help you to build* a wide   vocabulary, but remember:"),
            (@"Читайте немножко по-английски каждый день.",@"Read* some English every day."),
        };

        public override string[] Notes => new[]
        {
            (@"[Fall, fell, fallen] - упасть, [to fall asleep] - заснуть, [to fall in love] - влюбиться"),
            (@"[During] - во время, в какой-то период "),
            (@"[То stay] - остаться, [to rest] - отдыхать. "),
            (@"Напомним, что слово [ago] имеет значение - назад, [two hours ago] - два часа назад и обычно употребляется с простым прошедшим временем [Past Simple]. [А long time ago] - давным-давно. [How long ago?] - Как давно? "),
            (@"[To put, put, put] - пояосясить, класть. В этом предложении поместить, сделать. "),
            (@"[Wide] - широкий, безмерный, обширный. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Веди себя тихо, твой папа заснул полчаса назад.",@"Keep quiet, your father fell asleep half an hour ago."),
            (@"Привет, рад тебя опять видеть. Как у тебя дела?",@"Hello, it's nice to see you again. How are you?"),
            (@"Он вышел во время первого тайма [первой половины] матча.",@"He left during the first part of the match."),
            (@"Он сказал, что ему скучно и хотел идти домой.",@"He said he was bored and wanted to go home."),
            (@"Мы ждали его пять минут, а потом тоже ушли.",@"We waited for him for five minutes then left as well."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Уинстон Черчилль умер в 1965 году. ", "Winston Churchill died [in ] [nineteen sixty]-[five]."),
            ( "Он был премьер-министром во время войны. ", "[He was ] Prime Minister [during] the war."),
            ( "Он правил [имел власть] девять лет. ", "Не was [in ] power [for nine years]."),
            ( "Джон должен был лежать [остаться] в кровати всю неделю.", "John [had to ] stay [in ] bed [for a week ]."),
            ( "На неделе перед Роэюдеством магазины полны людей.", "[During ] the week [before ] Christmas, the shops are [full of people]."),
        };
    }
}
