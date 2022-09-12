using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_83 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Я еще не ходила за покупками [не сделала покупок].",@"I haven't done the shopping yet."),
            (@"Лучше я пойду сейчас, потому что в противном случае будет слишком поздно.",@"I'd better go* now or it'll be too late."),
            (@"Посмотрим, нам нужно [какое-нибудь] мясо. Куплю немного молотого (мяса) на сегодняшний вечер и на говяжье жаркое.", @"Let's see*, we need some ® meat.  I'll get* some chops for tonight, and a joint of beef."),
            (@"Я могу положить это в морозильник.",@"I can put* that in the freezer."),
            (@"Потом овощи: куплю [какую-нибудь] капусту, немного гороха и риса. У нас есть уже свекла и салат. ",@"Then vegetables: I’ll buy* some cabbage, some peas and some rice. We've already got* beetroot and lettuce."),
            (@"Куплю немного муки и сделаю йоркширский пудинг, который съедим [до съедения] с ростбифом в воскресенье.",@"I’ll buy some flour and make* a Yorkshire pudding to eat* with the roast beef on Sunday."),
            (@"Что нам еще нужно? Немного туалетной бумаги и отбеливатель ... и немного сладостей для детей.",@"What else do we need? Some toilet paper and some bleach... and some sweets for the kids"),
            (@"Я думаю, это все. Я все могу купить [получить] в супермаркете.",@"I think* that's all. I can get* everything at the supermarket."),
            (@"Джон, можно ли мне [могу ли я] взять машину? - Да, тебе помочь?", @"John, may I take* the car? - Yes. Do you want a hand?"),
            (@"Если ничего не делаешь, то было бы чудесно.",@"If you're not doing anything, that would be lovely."),
            (@"Дай [позволь] мне досмотреть конец этой программы.",@"Let me watch the end of this programme."),
            (@"Хорошо, я выведу машину из гаража и возьму сумки для покупок.",@"Alright, I'll take* the car out of the garage and fetch the shopping bags."),
            (@"Это не продлится долго, но я ждал целую неделю, чтобы посмотреть эту программу [ждал, чтобы посмотреть эту программу неделю].",@"I won't be a minute, but I've been waiting  to see this programme for a week."),
        };

        public override string[] Notes => new[]
        {
            (@"Как мы помним [some] переводится как: несколько, какое- то, немного. Не всегда, однако, оно переводится на русский язык. Часто в предложении оно выполняет такую функцию, как артикли - [а, an, the,] то есть определяет имена существительные и тогда не переводится. We need some meat можно перевест как: нам нужнo (какое-то) мясо. "),
            (@"[Joint] это объединение, соединение, скрепление, стык; жаркое, окорок. Происходит от выражения [to join], - соединять, объединять, присоединяться. [Joint-venture] - совместное предприятие. "),
            (@"[Kid] - употребляется в разговорной речи вместо [child] - ребенок. "),
            (@"[То want а hand] - хотеть, нуждаться в чьей-то помощи. "),
            (@"[Lovely] - прекрасный, прелестный, очаровательный. [That would be lovely] - это вежливое обращение - Это было бы прекрасно/чудесно, и т.п."),
            (@"Конструкцию [I've been waiting] переводим здесь как: я ждал. Скоро мы вернемся к этой конструкции."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Тебе нужно что-нибудь еще?",@"Do you need anything else?"),
            (@"Oн говорил в течении двух часов.",@"He has been talking for two hours."),
            (@"Вынь покупки из сумки и положи их на стол.",@"Take the shopping out of the bag and put it on the table."),
            (@"Лучше скажи ему сейчас, а то он рассердится.",@"You'd better tell him now or he'll get angry."),
            (@"Купить тебе что-нибудь в супермаркете?",@"Do you want me to buy you anything at the supermarket?"),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я жду его yofce час, и мне начинает становиться холодно.", "I [have been ] waiting [for ] him [for ] an hour and I [am beginning - ] to [be cold]."),
            ( "Ты не должна покупать рис, нам никакой рис не нужен.", "You [shouldn't buy ] any [rice ], we [don't need any]."),
            ( "Ты не был там, когда он рассказывал о своем путешествии?", "[Weren't ] you [there ] when he [told ] us [about] his journey?"),
            ( "Я еще ему не написала. Передать от тебя привет? ", "I [haven't written ] to him [yet]. Do you [want me to] say Hello?"),
            ( "Что еще нам нужно? - Мука и яйца, ", "[What ] else [do we need]? - [Flour] and eggs. "),
        };
    }
}
