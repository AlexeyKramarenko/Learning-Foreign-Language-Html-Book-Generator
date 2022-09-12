using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_136 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Гостиница была прекрасной; небольшая, но удобная и только за тридцать пять фунтов за ночь с завтраком.",@"The hotel was fine: small but comfortable and only thirty-five pounds a night with breakfast."),
            (@"Я зарегистрировался, принес чемодан в комнату и отправился открывать для себя Лондон.",@"I checked in, put* my case in my room and set* out to discover London."),
            (@"Тони прервал: Знаешь, тебе повезло. Тридцать пять фунтов за ночь - это очень дешево.",@"Tony interrupted: ""You were lucky, you know.  Thirty-five pounds a night is very cheap."""),
            (@"Ты мог бы заплатить до шестидесяти фунтов - и тоже за маленькую комнату.",@"You could have paid up to sixty pounds - and for a small room, too."),
            (@"Знаю - сказал Пьер, - но Лондон дешевле Парижа.",@"- I know, said Pierre, but London is cheaper than Paris,"),
            (@"За исключением метро, которое значительно дороже и куда менее современно, чем наше метро.",@"except the tube: that's much dearer, and far less modern than our Metro."),
            (@"Я решил сразу же всюду ходить. Даже купил себе пару ботинок.",@"I decided straight away to walk everywhere. I even bought* a pair of shoes."),
            (@"Это обернулось [было] небольшой проблемой. Продавец спросил меня: ""Какой размер вы носите?""", @"That was a bit of a problem. The salesman asked: ""What size do you take?"""),
            (@"Я не имел понятия. К счастью, у него была таблица пересчета.",@"I had no idea. Fortunately he had a conversion table."),
            (@"Вы носите сорок второй размер, что дает девять с половиной.",@"You take* a size forty-two that makes* you nine and a half."),
            (@"У нас есть прелестная пара (обуви) на распродаже: только пятьдесят фунтов - (цена) снижена со ста.",@"We have a nice pair in the sales  : only fifty pounds reduced from one hundred pounds. "),
            (@"Я воспользовался случаем. Положил свои старые ботинки в сумку и вышел в новых.",@"I got* a bargain. I put* my old shoes in a bag and walked out in my new ones."),
            (@"Я не имел понятия, что Лондон такой большой. Дорога до Трафальгарской площади заняла у меня час.",@"I had no idea London was so large. It took* me an hour to walk to Trafalgar Square."),
            (@"Я хотел посмотреть картины в Национальной галерее.",@"I wanted to look at the paintings in the National Gallery."),
            (@"И снова был приятно удивлен: это было бесплатно.", @"I had another nice surprise: it was free. "),
        };

        public override string[] Notes => new[]
        {
            (@"По-английски говорим [thirty five pounds а night], а по-русски тридцать пять фунтов за сутки. "),
            (@"[Everywhere] - везде; [nowhere] - нигде. "),
            (@"[Sale] - pacnpoдажа; [sales] - распродажи. [To sell, sold, sold] - продавать. [To be sold out] - продано."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мне нравятся все картины за исключением одной.",@"I like all the paintings except one."),
            (@" Она должна была ходить по Лондону. Ты видишь больше.",@"She should have walked around London. You see more."),
            (@"Я не мог вспомнить, какой у меня размер.",@"I couldn't remember what size I took."),
            (@"Мне не по карману роскошные гостиницы, я должен остаться в „ночлежках с завтраком"".", @"I can't afford luxurious hotels, I have to stay in ""Bed and Breakfasts""."),
            (@"Есть хорошая пара ботинок на распродаже.",@"There is a nice pair of shoes in the sales."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я не имею понятия, какой размер ношу. Может, девятый.", "I have [no idea ] what [size ] I take [Perhaps] a nine."),
            ( "У них не было больше ботинок на распродаже, я должен был довольствоваться сапогами.", "They had [no more ] shoes [in the ] sales, I had to [make do] with boots."),
            ( "Нам повезло [мы были удачливы], мы оказались (там) сразу же.", "We [were lucky ], we went in [straight away]."),
            ( "У нас небольшие проблемы: я потерял свой кошелёк и паспорт.", "We have а [bit ] of а problem: I've [lost ] my [wallet ] and my [passport]."),
            ( "Ты могла заплатить значительно больше, чем заплатила. До тринадцати фунтов.", "You [could have ] paid [much (far) more ] than that. [Up to thirteen] pounds."),
        };
    }
}
