using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_72 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Поезд останавился на вокзале, но никто (в него) не сел.",@"The train stopped at a station but no one got* on."),
            (@"В последнюю минуту двери открылись",@"At the last minute, the door opened"),
            (@"и старый джентльмен с седой бородой и в очках вошел в купе.",@"and an old gentleman with a grey beard and glasses  got* into ® the compartment."),
            (@"Едва успел [схватил его (поезд)]! - сказал он, тяжело садясь.",@"""I just caught it!"" he said, sitting* down heavily."),
            (@"Он снял свои очки и вытер [свое] лицо полосатым носовым платком.",@"He took* off his glasses and wiped his face with a striped handkerchief."),
            (@"Каждый (из пассажиров) читал и курил, за исключением старого джентльмена.",@"Everyone was reading* and smoking, except the old gentleman."),
            (@"У него наверняка не было времени, купить газету перед тем как он (едва догнал) [поймал / схватил] поезд,",@"He had obviously had no time to buy* a paper before catching ® the train."),
            (@"Дэвид вскоре заметил, что мужчина читал его газету, но тайком.",@"David soon noticed that the man was reading* his paper with him, but very discreetly."),
            (@"В газете Дэвида было [газета Дэвида имела] двадцать страниц, и ему хотелось поделиться [ей] с ним,",@"David's paper had twenty pages and he would have liked ® to share it with him,"),
            (@"но он не хотел показать старому джентльмену, что заметил, что тот ее читал:",@"but he did not want to show the old gentleman that he had noticed he was reading* it:"),
            (@"боялся его обидеть.",@"he was afraid of offending him."),
            (@"Дэвид дошел до конца страницы, но не хотел ее перевернуть, потому что его сосед все еще читал.",@"David reached the bottom of the page, but did not want to turn it because his neighbour was still reading*."),
            (@"Наконец Дэвид решил проблему. Сложил газету, положил на сиденье,",@"At last, David solved the problem. He folded the paper, put it on the seat,"),
            (@"закрыл глаза и притворился, будто спит.",@"closed his eyes and pretended to be asleep."),
        };

        public override string[] Notes => new[]
        {
            (@"[Glasses] - очки; [glass] - стакан, стекло. "),
            (@"[In, into] - ву внутрь. [Into] - внутрь чего-либо - используется в связке с глаголами движения. [Не jumped into the water] - Он прыгнул в воду. [Не got into the car] - Он оказался в автомобиле [вошел/проник в автомобиль]."),
            (@"[Heavily] - тяжело, с усилием. "),
            (@"[Before catching] - перед тем, как [схватил] (едва успел). После слов [after] - после, [before] - перед, прежде чем - часто используются глаголы с окончанием [-ing], или герундии (gerunds). [Before catching the train, he bought a paper]. - Прежде чем он едва успел на поезду он купил себе газету. [After reading it for a while, he fell asleep]. После того, как он почитал её некоторое время [почитав её npoмежуток времени], он заснул."),
            (@"[Не would have liked] - ему хотелось - мы вернемся к этой конструкции в следующих уроках."),
            (@"После [of] также часто выступает отглагольное существительное - см. объяснение этого урока. "),
            (@"[То pretend] - притворяться. [То pretend to be asleep] - притворяться, что спишь; [Не pretended to be а millionaire]. - Он притворялся, будто он миллионер. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Без движения рук он перевернул страницу.",@"Without moving his hands, he turned the page."),
            (@"Он боялся, что разбудит своего отца.",@"He was afraid of waking his father."),
            (@"Было так холодно в Шотландии, что я простудился.",@"It was so cold in Scotland that I caught a cold."),
            (@"Он притворялся, будто он парашютист, а на самом деле был почтальоном.",@"He pretended to be a parachutist, but he was really a postman."),
            (@"Когда дойдешь до конца этой книги, прочитай ее еще раз.",@"When you have reached the end of this book, read it again."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Прежде чем вытереть свое лицо, он снял очки. ", "Before [wiping his ] face, he [took off ] his [glasses]."),
            ( "Все читали, за иааючением Дэвида, который притворялся, будто спит.", "[Everyone was ] reading [except ] David who was [pretending ] to [sleep]."),
            ( "Помни: нельзя научиться без учебы.", "[Remember ]: you cannot [learn ] without [studying]."),
            ( "Хотел бы тебе помочь, но, к сожалению, я слишком занят.", "I [would ] like [to help ] you, but, [unfortunately ], I [am too busy]."),
            ( "По прочтении отчета он вложил его в папку. ", "After [reading ] the report he [put ] it [in his] [case]."),
        };
    }
}
