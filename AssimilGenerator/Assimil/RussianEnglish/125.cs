using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_125 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Согласно моему словарю, это слово означает «беззаботный».",@"According to my dictionary, this word means* ""carefree""."),
            (@"Ночью взломщик проник в замок и украл все ее драгоценности.",@"During the night, a burglar broke* into the castle and stole* all her jewels."),
            (@"Ты стираешь это резинкой, а не «взломщиком», дурачок.",@"You erase it with a ""rubber"", not a ""robber"", you silly thing."),
            (@"Эта реклама гласит, что если нальешь молока в эти хлопья, то они станут хрустящими.",@"The advertisement says that if you pour milk onto this cereal, it will crackle."),
            (@"Oн купил два подержанных динамика к своей стереосистеме [своему стерео], но они не работают. Это была плохая покупка.",@"He bought two second-hand loudspeakers for his stereo, but they didn't work. It was a bad bargain."),
            (@"На этом пиджаке не хватает пуговицы, или же у [меня] есть лишняя петля!",@"There is a button missing from this jacket, or else   I’ve got an extra button-hole!"),
            (@"У меня нет мелочи для автомата с сигаретами. Одолжи мне пятьдесят пенсов?",@"I have no change   for the cigarette- machine. Lend* me fifty pence will you?"),
            (@"Ты должен бросить курить, это вредно [плохо] для твоего здоровья.",@"You ought to stop smoking, it's bad for your health."),
            (@"«Ваше здоровье!», сказал бармен. «Ваше здоровье!», ответил клиент.",@"""Your health!"", said the barman. ""Cheers!"", said the customer."),
            (@"Позволь мне представить тебя мистеру Легарду; он только что вернулся из Женевы.",@"Let me introduce you to Mr Legarde; he has just arrived from Geneva."),
            (@"Он кажется приятным человеком. Чем он занимается [делает]? - Он зубной врач. - Тогда я ошибся, он неприятный человек,",@"He seems a pleasant man. What does he do? - He's a dentist - Then I was wrong, he's an unpleasant man."),
            (@"Будешь говорить по-английски все более свободно, если будешь в повторять понемногу каждый день.", @"You will speak* English more and more fluently if you revise a little every day."),
        };

        public override string[] Notes => new[]
        {
            (@"[You silly thing] - дурачок, глупышка; [you poor thing] - бедненький, бедняжка. "),
            (@"[Cereal] - молочный суп с разного рода хлопьями, которые заливаются холодным или теплым молоком. "),
            (@"[or else] - ибо иначе, в противном случае, или, или же. [Do this or else I'll hit you.] - Сделай это, или я тебя ударю. [Something else] - что-нибудь другое. [Elsewhere] - где-нибудь в другом месте."),
            (@"[Change] - мелочь, сдача. [То change] - изменить, заменить. [Exchange] - обмен (денег); [exchange rate] - обменный курс."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я бы не хотел быть зубным врачом, их никто не любит.",@"I wouldn't like to be a dentist, no one likes them."),
            (@"Ты никогда не должен верить рекламам.",@"You should never believe advertisements."),
            (@"Если бы ты это сказал, то бы был не прав.",@"If you said that, you would be wrong."),
            (@"На моей рубашке не хватает пуговицы.",@"There is a button missing from my shirt."),
            (@"Залей кипяток в кофе.",@"Pour the boiling water onto the coffee."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Если бы ты не закперла дверь, тебя ограбили бы. ", "If you [hadn't ] locked the doors you [would have been] burgled."),
            ( "Чего-то не хватает. Что это могло бы быть? ", "[There ] is something [missing ]. What [could] it [be]?"),
            ( "У меня только пятифунтовая купюра. - Мне очень жаль, у меня нет сдачи (никакой мелочи).", "I've [only ] got а five-pound note. - I'm [sorry ] I haven't got any [change]."),
            ( "Что означает это слово? - Не знаю, я никогда не учил русский язык.", "[What ] does this word [mean ]? - I don't know, I have [never learned/learnt ] Russian."),
            ( "Сколько стоила бы новая стереосистема? - Слишком много для меня.", "[How ] much [would] а new stereo [cost]? - Far [too much] for me."),
        };
    }
}
