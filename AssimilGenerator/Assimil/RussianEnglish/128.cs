using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_128 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Пациент: - Доктор, помогите мне. Я разговариваю сам с собой.",@"Patient, - Doctor, help me. I keep talking to myself"),
            (@"Писихиатр: - Прошу вас не беспокоиться, в этом нет ничего необычного. В действительности тысячи людей это делают.'",@"Psychiatrist, - Don't worry sir, it's not uncommon. In fact, thousands of people do it."),
            (@"Пациент: - Да, но вы, господин доктор, не знаете [не даете себе отчета в том,], какие глупости я говорю.",@"Patient, - Yes, but doctor, you don't realise how stupid I sound!"),
            (@"На их первой встрече психиатр задал пациенту несколько стандартных вопросов.",@"At their first meeting, a psychiatrist asked his patient a few standard questions."),
            (@"Какая разница между маленьким мальчиком и карликом? - спросил он.",@"""- What is the difference between a little boy and a dwarf?"" he asked."),
            (@"Может быть много различий, - ответил пациент.",@"- ""There could be a lot of difference"", replied the patient."),
            (@"Какие, например?",@"- What, for example?"),
            (@"Ну, карлик может быть девочкой, - был ответ.",@"- ""Well, the dwarf could be a girl"", came* the reply."),
            (@"Привет, не видел тебя сто лет. Хочешь выпить?",@"Hello, I haven't seen* you for ages. Have a drink."),
            (@"Нет, спасибо, я никогда не пью. - На самом деле, почему [не (пьешь)]?",@"No thanks, I never drink*. - Really, why not?"),
            (@"Я не поклонник выпивки в присутствии моих детей,	",@"Well, I don't believe in   drinking* in front of my children,"),
            (@"а когда я далеко от них, не нуждаюсь в выпивке.",@"and when I'm away from them I don't need to drink!"),
            (@"Твоя девушка красива, но хромает.",@"Your girlfriend is good-looking, but she limps."),
            (@"Только тогда, когда ходит!",@"Only when she walks!"),
        };

        public override string[] Notes => new[]
        {
            (@"[To believe in] - верить в, доверять, придавать большое значение, думать, полагать, быть сторонником, поклонником чего-либо. [I don't believe in drinking] - Я не поклонник выпивки. [I don't believe in talking to strangers] - Я не думаю, что это хорошо - разговаривать с . незнакомыми [чужими]."),
            (@"[Away] - далеко, издали. [Go away] - отойди. [When the cats are away, the mice will play] - Когда кот далеко, мыши танцуют."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Разве ты никогда не был у психиатра? Ты должен (пойти).",@"Haven't you ever been to see a psychiatrist? You should."),
            (@"Он кажется умным [говорит умно], но на самом деле он не является [умным].",@"He sounds intelligent, but he isn't really."),
            (@"Извините, я не сторонник давать деньги взаймы.",@"I'm sorry, but I don't believe in lending money."),
            (@"Мы как раз выпили все твое виски. Как жаль.",@"We've just drunk all your whisky. What a pity!"),
            (@"Я не видел его сто лет, у него всё хорошо?",@"I haven't seen him for ages. Is he well?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Как прекрасно она выглядит! И какой умной кажется!", "How [pretty ] she looks! and [how ] intelligent she [sounds]!"),
            ( "Oн не поклонник выпивки, a она не нуждается в выпивке.", "Не [doesn't believe ] in drinking and she doesn't [need to drink]."),
            ( "Ты его в последнее время видел? - Конечно, я видел его в прошлый четверг.", "[Have ] you [seen him ] recently? - Of [course ], I [saw him ] last [Thursday]."),
            ( "Кто будет присматривать за домом, когда мы уедем?", "Who [is going ] to look [after ] the house [while ] we are [away]?"),
            ( @"Какова разница между (понятиями) ""резинка"" и ""вор""?", @"[What ] is the difference [between ] а ""[rubber] "" and а ""[robber]""?"),
        };
    }
}
