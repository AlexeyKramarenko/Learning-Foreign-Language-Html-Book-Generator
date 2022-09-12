using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_101 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Закоренелый холостяк: - Поверьте мне, все женщины глупы: я встретил только одну умную женщину в своей жизни.",@"Confirmed bachelor.  - Believe me, all women are silly; I have only met* one intelligent woman in my whole life."),
            (@"Почему же ты не женился на ней?",@"Why didn't you marry her then?"),
            (@"Я просил ее, но она отказала мне.",@"I asked her, but she refused me."),
            (@"Парикмахер: - Я брил вас раньше, сэр?",@"Barber: - Have I shaved you before, sir?"),
            (@"Клиент: - Нет, эти шрамы у меня с войны.",@"Customer: - No, I got those scars during the war."),
            (@"Послушай, Томми, если ты пообещаешь никогда больше не произносить это скверное слово, я дам тебе десять пенсов.",@"Listen, Tommy, if you promise never to say that rude word again, I will give* you ten pence."),
            (@"О, я знаю другое, которое стоит, по меньшей мере, пятьдесят пенсов.",@"Oh, I know* another that is worth at least fifty pence!"),
            (@"Директор крупной фирмы подверг критике работника за [его] неэффективность,",@"The manager of a large firm criticised an employee for his inefficiency"),
            (@"Работник был так раздражен, что начал критиковать методы руководства фирмой.",@"The employee was so annoyed that he started criticising the way in which the company was run*."),
            (@"Вы являетесь директором этой фирмы? - спросил его директор в бешенстве.",@" - Are you the manager of this company?  the manager asked him furiously."),
            (@"Конечно, нет, сказал работник.",@"- Of course not, said the employee."),
            (@"Так не болтайте, как дурак! - крикнул директор.",@"- Then don't talk like a fool!'' shouted the manager."),
            (@"Пессимист напоминает нам, что чашка наполовину пуста.",@"A pessimist reminds us that a cup is half empty"),
            (@"Оптимист напоминает, что она наполовину полная.",@"and an optimist reminds us that it is half full."),
        };

        public override string[] Notes => new[]
        {
            (@"[Bachelor] - холостяк; [spinster] - старая дева, но данное выражение имеет уничижительную окраску, обычно говорят [а single woman] - одинокая женщина. "),
            (@"[А firm, company] - фирма; [а society] - общество. "),
            (@"[Inefficiency] - неэффективность, непроизводительность,  бездарность. Противоположное значение имеет слово  [efficiency]. "),
            (@"[То run а company, to run а firm] -руководить фирмой; [to run, ran, run] - бежать, бегать. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Он был такой злой, что начал кричать.",@"He was so angry he started shouting."),
            (@"Сколько стоят твои швейцарские часы?",@"How much is your Swiss watch worth?"),
            (@"Он подвергся критике за неэффективность.",@"He was criticised for his inefficiency."),
            (@"Он говорит по-английски как англичанин.",@"He speaks English like an Englishman."),
            (@"Разве не ожидалось от тебя, что ты никогда не произнесешь этого слова?",@"Weren't you supposed never to say that word?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "A что скажешь о стаканчике виски? - Нет, спасибо, не хочу (никакой).", "[How about ] а glass of whisky? - No thank you, [I don't want one/any  ]."),
            ( "Почему ты мне не сказал, что играешь в шахматы? ", "[Why didn't  ] you [tell ] me [that ] you played [chess]? "),
            ( "Это не стоит пробовать, ты не выиграл бы [выиграешь].", "It [isn't worth trying ], you [would ] not [win]."),
            ( "Поблагодари его, пожалуйста, за его любезность [доброту].", "Please [thank ] him [for] his kindness."),
            ( "Большое спасибо, действительно. - Не за что. ", "Thank you [very ] much [indeed ]. - Not [at all]."),
        };
    }
}
