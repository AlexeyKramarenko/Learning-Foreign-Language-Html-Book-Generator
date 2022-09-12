using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_55 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Когда я был в Америке, я сделал несколько очень хороших фотографий.",@"When I was in America, I took some very good photos"),
            (@"Привет, как дела? - Я устал. Только вчера вернулся из [моей] поездки.",@"Hello, how are you? - I'm tired. I only  came back from my trip yesterday."),
            (@"Машина, в которой ты меня видел, была машиной моей жены. [Это была машина моей жены, в которой ты меня видел.]",@"That was my wife's car you saw me with."),
            (@"Мы слышали о его поездке и о том, что он делал [о веш;ах, которые он делал]. Это было очень интересно.",@"We heard about his trip and the things he did. It was very interesting."),
            (@"Как насчёт стакана пива? Нет, спасибо. Я не хочу пить.",@"How about a glass of beer? - No thanks, I'm not thirsty."),
            (@"Ты видел его вчера? - Нет, не видел.",@"Did you see him yesterday? - No, I didn't."),
            (@"Он не оплатил свой счет, так как у него не было [никаких] денег.",@"He didn't pay his bill because he didn't have any money."),
            (@"Кем была та дама, с которой я видел тебя прошлым вечером.",@"Who was that lady I saw you with last night ®?"),
            (@"Это была не дама, это была моя жена.",@"That wasn't a lady, that was my wife."),
            (@"Мы думали, что он понял.",@"We thought he had understood."),
            (@"Мать: - Что ты делал в первый день в школе?",@"Mother, - What did you do on your first day at school?"),
            (@"Ребенок: - Я учился писать.",@"Child. - I learnt to write."),
            (@"Мать: - Уже! Ну и что ты написал?",@"Mother. -Already! Well, what did you write?"),
            (@"Ребенок: - Не знаю. Я не умею читать.",@"Child, - I don't know. I can't read."),
        };

        public override string[] Notes => new[]
        {
            (@"[То take а photo] - сделать фотографию. "),
            (@"[Only] - только, только лишь, только что. "),
            (@"[Lady] - дама, эюенщина - это выражение более элегантно, нежели [woman] - женщина. [Lady] - это также аристократический титул для женщины, [а lord] для мужчины."),
            (@"[Last night] - прошлым вечером, прошлой ночью. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он не мог прийти, так как у него не было времени.",@"Не could'nt come because he didn't have time."),
            (@"Почему ты мне раньше не сказал?",@"Why didn't you tell me before?"),
            (@"Я только вчера вернулся.",@"I only came back yesterday."),
            (@"Что ты думала о Джордже?",@"What did you think of George?"),
            (@"Думала, что был милый, но немного глупый.",@"I thought he was kind, but a little stupid."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Выглянув в окно, он пошел в магазин. ", "After he had [looked ] in the window, he [went into] the shop."),
            ( "Ты меня видел с дождевым плащом моей жены. ", "You [saw ] me with [my wife's] raincoat. "),
            ( "Что ты делал сегодня? Учил стихотворение. ", "[What did ] you [do ] today? -I [learnt] а poem. "),
            ( "Этим летом было так жарко, что мне всегда хотелось пить.", "[This ] summer, it [was so ] hot that I [was] always [thirsty]."),
            ( "Зачем ты это сделал? - Я думал, что это была хорошая идея.", "[Why did ] you [do ] that? I [thought ] it [was] a good [idea]."),
        };
    }
}
