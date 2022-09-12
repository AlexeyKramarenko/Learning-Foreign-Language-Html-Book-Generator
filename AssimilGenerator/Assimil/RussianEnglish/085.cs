using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_85 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид и Джоэн решили поехать в Ричмонд на пикник.",@"David and Joan decided to go* for a picnic in Richmond."),
            (@"По воскресеньям Дэвид встаёт поздно (долго спит), а Джоэн приносит ему завтрак в постель.",@"On Sundays, David has a lie-in and Joan brings* him breakfast in bed."),
            (@"В это воскресенье Дэвид встал в одиннадцать часов и, побрившись и помывшись, сошел вниз.",@"This Sunday, David got* up at eleven o'clock and after shaving and washing, went downstairs."),
            (@"Джоэн приготовила корзинку для пикника.",@"Joan was preparing the picnic basket."),
            (@"Положила туда холодное мясо, яйца, сваренные вкрутую, несколько холодных сосисок и салат.",@"She put* in cold meat, hard-boiled eggs, some cold sausages and a lettuce."),
            (@"Добавила буханку хлеба, немного масла, [и] ножи, и вилки.",@"She added a loaf of bread, some butter and the knives and forks."),
            (@"В это время Дэвид вывел машину из гаража.",@"Meanwhile  David got* the car out of the garage."),
            (@"Они положили корзину Б багажник и отправились в парк Бушей.",@"They put* the basket in the boot and set* off for Bushey Park."),
            (@"По дороге Дэвид остановился, чтобы купить [какого-нибудь] вина.",@"On the way  , David stopped to buy some wine."),
            (@"Парк Бушей - это огромный парк в пригородах Лондона.",@"Bushey Park is a huge park on the outskirts of London."),
            (@"Когда они приехали, то нашли спокойное место и уселись на плед, чтобы съесть свой ланч.",@"When they arrived, they found* a quiet place and sat* down on a rug ® to eat their lunch."),
            (@"Дай мне [немного] курицы, и чуть-чуть соли.",@"- Pass me some chicken, please... and some salt, as well."),
            (@"о Боже, сказала Джоэн, мне кажется [я думаю, что], я забыла соль.",@"- Oh dear, said* Joan, I think* I've forgotten* the salt."),
            (@"Идиотка! сказал Дэвид, но увидев, что она огорчилась, сказал:",@"- Idiot! said* David, but seeing* she was upset, he said:"),
            (@"Ничего страшного. Выпьем вина.", @"- Never mind. Let's have a glass of wine."),
            (@"Вынул бутылку из корзины, потом сказал «О Боже, я забыл штопор».", @"He took* the bottle out of the basket, then said*: - Oh dear, I've forgotten the cork screw! "),
        };

        public override string[] Notes => new[]
        {
            (@"[То have а lie-in] - валяться, лежать в постели. [То lie, lay, lain] - лежать. "),
            (@"[Meanwhile] - в это время, в то время, как, во время. [А while] - момент, минута, недолго, короткий промежуток времени. [Не stayed in London for a while.] - Oh оставался недолго в Лондоне. "),
            (@"[On the wау] - по дороге. "),
            (@"[Rug] - плед, коврик, используемый в путешествиях; [blanket] - тонкое домашнее одеяло."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Она очень быстро выздоровела.",@"She got over her illness very quickly."),
            (@"Выведи, пожалуйста, машину из гаража.",@"Will you get the car out of the garage, please?"),
            (@"По субботам он валяется в постели и встает в одиннадцать часов.",@"On Saturdays, he has a lie- in, and gets up at eleven."),
            (@"Она села в автобус вообще без денег.",@"She got on the bus without any money."),
            (@"Наверно, приближается зима. Очень рано темнеет.",@"Winter must be coming. It's getting dark very early."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "По дороге домой он остановило я, чтобы купить [какого-нибудь] вина.", "[On the way ] home, he stopped [to buy ] some [wine]."),
            ( "Он помылся, оделся и вышел не поевши. ", "After [washing ] and [dressing ] he left [without eating]."),
            ( "Положи вещи в багажник, а я в это время поищу штопор.", "[Put ] the [things in ] the boot, [meanwhile ] I [will look for ] the [corkscrew]."),
            ( "Oн проснулся, увидел, что уже было два часа, встал и спустился вниз.", "Не [woke up, saw ], [was ] it two o'clock, [got up ]  and [went] downstairs."),
            ( "Она была очень огорчена смертью своего сына. ", "She [was ] very [upset ] by the [death ] of [her] son."),
        };
    }
}
