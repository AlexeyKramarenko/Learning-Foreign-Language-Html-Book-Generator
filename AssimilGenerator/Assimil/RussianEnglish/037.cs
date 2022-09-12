using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_37 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Можете ли Вы подсказать [рассказать] мне дорогу к Британскому музею?", @"Can you tell me the way to the British Museum?"),
            (@"Гм... Дайте подумать. Да. Вы идете пешком?", @"Mmm... Let me see. Yes. Are you on foot?"),
            (@"Да. - Тогда идите по улице Чаринг Кросс и сверните на авеню Шафтсбьюри,", @"Yes, I am. - Well, go up Charing Cross Road and take Shaftesbury Avenue."),
            (@"Вы дойдете до улицы Нью Оксфорд Стрит, а затем, то есть, а ... напротив, я полагаю.", @"You come to New Oxford Street. Er, then it's, er, just opposite I think."),
            (@"Да, именно, как раз напротив - Блумсбьюри Стрит. - Извините, повторите еще раз, пожалуйста?", @"Yes, that's it, just opposite is Bloomsbury Street. - Sorry, say that again?"),
            (@"Как раз напротив будет [у вас есть] Блумсбьюри Стрит. Идите по ней, и это [музей] будет находиться справа от Вас.", @"Just opposite, you've got Bloomsbury Street. Go down there and it's on your right."),
            (@"Его нельзя не заметить.", @"You can't miss it."),
            (@"Большое спасибо. - Все в порядке.", @"Thanks very much. - That's okay."),
            (@"Угощайся еще одним пивом. Я не хочу, но ты возьми [выпей].", @"Have another beer. - I don't want one, but have one yourself."),
            (@"Возьму [выпью]. Мне очень хочется пить. - Тебе всегда хочется пить.", @"I will. I'm very thirsty. - You're always thirsty."),
            (@"Может, потому, что я не пью столько, сколько надо [достаточно].", @"Perhaps it's because I don't drink enough."),
            (@"Обжора", @"A glutton"),
            (@"(Мать - своему сыну у после шестого кусочка пирога:)", @"(A mother to her son, after the sixth piece of cake):"),
            (@"Том, ты обжора. Как ты можешь так много есть?", @"Tom, you are a glutton. How can you eat so much?"),
            (@"Не знаю. Таково моё везенье [удача].", @"I don't know. It's just good luck."), 
        };

        public override string[] Notes => new[]
        {
            (@"<b>To tell</b> означает говорить, сказать, a также показать, указать, объяснить. "),
            (@"<b>Let me see</b> буквально означает дайте посмотреть, в смысле дайте подумать, "),
            (@"Названия улиц, приведенные в этом диалоге  настоящие названия улиц Лондона. "), 
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Поверните на первую улицу справа.", @"Take the first street on the right."),
            (@"Сверни налево в конце этой дороги.", @"Turn left at the end of the road."),
            (@"Только двадцать минут ходьбы [прогулочным шагом! до [улицы] Оксфорд Стрит.", @"It's only a twenty minutes' walk to Oxford Street."),
            (@"Извините, повторите ещё раз. Не слышу.", @"Sorry, say that again. I can't hear."),
            (@"Поторопись. Не опоздай на поезд.", @"Hurry up. Don't miss the train."),
            (@"Напротив церкви увидишь школу.", @"Opposite the church you can see the school."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Так много шума, что он пойдет спать.", "There is [too much noise] that he [is going to] bed."),
            ( "Можете ли Вы подсказать дорогу к музею?", "Саn you [tell] me [the way to] the [museum]."),
            ( "Идите вверх по этой улице, и это будет справа от вас.", "[Go up this] street and it's [on] your [right]."),
            ( "Вы идете пешком, или едете на машине? ", "Are you [on foot] or [in] а car?"),
            ( "Мне везет: я никогда не теряюсь.", "[I'm lucky] I [never] get lost."),
        };
    }
}
