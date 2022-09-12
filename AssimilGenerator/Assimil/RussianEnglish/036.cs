using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_36 : LessonBase
    {

        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид и Джоэн идут к Марсденам на ужин.", @"David and Joan are going to the Marsden's for dinner."),
            (@"Они приходят [прибывают] в семь тридцать (в половине восьмого) и мистер Марсден открывает двери и приглашает их внутрь.", @"They arrive at seven thirty and Mr Marsden opens the door and invites them in."),
            (@"Проходите в салон и присаживайтесь. Что вы будете пить?", @"Come into the sitting-room and sit down. What will you have to drink?"),
            (@"Мне виски. Джоэн, что хочешь ты?", @"A whisky for me. - Joan, what will you have?"),
            (@"Херес, если можно. Сухой, пожалуйста.", @"A sherry, if I may. Dry, please."),
            (@"Он подает напитки и они все садятся,", @"He serves the drinks and they all sit down."),
            (@"Миссис Марсден спускается [сходит] по лестнице и присоединяется к ним.", @"Mrs Marsden comes downstairs and joins them."),
            (@"Входит повар и говорит: ""Ужин готов"".  Они идут в столовую комнату.", @"The cook comes in and says: ""Dinner is ready."" They go into the dining-room."),
            (@"Еда превосходна. Они едят суп, баранину, фруктовый салат и сыр.", @"The meal is excellent. They eat soup, lamb, fruit salad and cheese."),
            (@"Вам везёт, миссис Марсден, потому что у вас есть повар, - говорит Джоэн.", @"You're very lucky to have a cook, Mrs Marsden, says Joan."),
            (@"Да, вы знаете, у меня так мало времени на кухню.", @"Yes, You see, I have so little time to cook."),
            (@"У меня тоже. Но Дэвид не зарабатывает достаточно [денег], поэтому...", @"So do I. But David doesn't earn enough money, so..."),
            (@"Воцарилась неловкая тишина.", @"There is an embarrassed silence."),
            (@"Угощайтесь бренди, - говорит мистер Марсден.", @"Have a brandy, says Mr Marsden."),
        };

        public override string[] Notes => new[]
        {
            (@"<b>Dinner</b> - прием теплой пищи, состоящий из двух или 
                трех блюд, обычно принимается вечером. Слово supper 
                - обозначение вечернего приема холодной пищи - 
                используется редко. У англичан в течение дня, как 
                правило, четыре приема пищи: breakfast, lunch, tea - 
                полдник, dinner. "),
            (@"<b>Will</b>, как видим, участвуя в постановке вопросов, ставится перед подлежащим. "),
            (@"<b>А whisky</b> является сокращением от <b>а glass of whisky</b> - стаканчик виски. Поэтому это существительное предваряет артикль а, который в иных случаях не употребляется с вещественными именами (см. урок 14, объяснение. "),
            (@"<b>Dry</b> - сухое (вино), <b>sweet</b> - сладкое, <b>straight</b> - чистое (без воды). "),
            (@"<b>Downstairs</b> - вниз. Англичане обычно живут в  индивидуальных домах. На первом этаже расположены   кухня, салон и столовая, на втором - спальня. "),
            (@"В конце приема пищи - по французскому обычаю - можно подать разные сорта сыра. "),
            (@"<b>So do I</b> - я также, <b>so does he/she</b> - он/она также.  "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Входите и присаживайтесь. Что вы будете пить?", @"Come in and sit down. What will you have to drink?"),
            (@"Так много дел и так мало времени.", @"There is so much to do and so little time,"),
            (@"Сколько денег вы зарабатываете?", @"How much money do you earn?"),
            (@"Давай, присоединяйся к нам.", @"Come and join us."),
            (@"Она подает ужин ровно в восемь.", @"She serves dinner at eight exactly."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Входите в салон. Присаживайтесь.", "Come [into] the [sitting]-[room]. Sit [down]." ),
            ( "Она спускается no лестнице и идет в столовую комнату.", "She and comes [downstairs] [into] the [dining]-room."),
            ( "Проходите внутрь, пожалуйста. Я пойду за вами.", "[Go in] please [I will] follow you."),
            ( "Он открывает двери и приглашает их войти.", "Не [opens the door]   and invites [them] to [come in]."),
            ( "Что будешь пить? Сухое белое вино, пожалуйста.", "What [will] you [have] to drink? A [dry] [white] [whine] please."),
        };
    }
}
