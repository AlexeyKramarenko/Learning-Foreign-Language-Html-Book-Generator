using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_118 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Этим утром Оксфорд выглядел [очень] прекрасно. Не напрасно называют его ""городом шпилей"".",@"Oxford looked very beautiful that morning. It is not for nothing  that it is called ""The City of Spires""."),
            (@"Они проехали через центр и вскоре прибыли на спокойную улочку, где жили родители Дэвида.",@"They drove* through the centre and soon arrived at the quiet street where David's parents lived."),
            (@"Отец Дэвида поприветствовал их в дверях: - Здравствуйте, вы хорошо выглядите. Входите.",@"David's father greeted them at the door. ' - Hello, you look well. Come* in!"),
            (@"Вы хорошо доехали? Дэвид и Джоэн посмотрели друг на друга с неловкостью.",@"Did you have a good trip? David and Joan looked at one another uncomfortably"),
            (@"Э..., так, спасибо, всё было в порядке.",@"- Er, yes thanks, it was* alright"),
            (@"Кладите свои сумки там и входите в гостиную.",@"- Put* your bags down there and come* into the front room."),
            (@"Мать Дэвида сидела перед камином.",@"David's mother was sitting in front of the fire."),
            (@"Она встала, как (только) они вошли, и поцеловала их обоих.",@"She stood* up as they came* in and kissed them both."),
            (@"Джоэн достала сверток из-за спины и дала его миссис Вилсон.",@"Joan took* a parcel from behind her back and gave* it to Mrs Wilson."),
            (@"Это что-то небольшое, что я нашла в старых вещах, то есть в антикварном магазине.",@"- It's just a little something I found* in a junk... I mean*, in an antique shop."),
            (@"Миссис Вилсон раскрыла сверток и вынула маленькую серебряную коробочку.",@"Mrs Wilson opened the parcel and took* out a small silver box."),
            (@"О, это чудесно! - воскликнула, - но что это?",@"- Oh, it's lovely! she cried, but what is it?"),
            (@"Это викторианское. Это... вещь.",@"- Well, it's Victorian. It's a... thing."),
            (@"А, [хорошо,] ты тоже не знаешь. Я не хочу [могу] тебя обидеть, не так ли?",@"- Oh good, you don't know* either. I can't offend you, can I?"),
            (@"Думаю, что положу сюда [в это] свои сережки.",@"I think* I'll put* my earrings in it."),
        };

        public override string[] Notes => new[]
        {
            (@"[It is not nothing] - не напрасно. "),
            (@"[To greet] - (по)приветствовать, встретить. [He greeted me with a smile] - Он поприветствовал меня улыбкой. [Greetings] - пожелания. [Christmas greetings] - празничные пожелания (на Рождество). "),
            (@"[Uncomfortably] - неловко, неудобно, со стеснением. [То  feel uncomfortable] - чувствовать себя неуютно. [An  uncomfortable silence] - неловкое молчание. "),
            (@"[Front room, sitting room, lounge] - салон, гостиная, холл, вестибюль. "),
            (@"[Junk] - старые вещи. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я купила тебе подарок, но (сама) не знаю, что это.",@" I've bought you a present but I don't know what it is."),
            (@"Мне не по карману новая машина; должен купить подержанную [использованную].",@"I can't afford a new car; I'll have to buy a second-hand one."),
            (@"Она встала и расцеловала их обоих.",@"She stood up and kissed them both."),
            (@"Я никогда в жизни не покупал коровы.",@"I've never bought a cow in my life."),
            (@"Они разговаривали между собой первый раз спустя (несколько) месяцев (отсутствия контактов).",@"They spoke to one another for the first time for months."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Куда ты положил мои тапки? - Там, за креслом. ", "Where have you [put my ] slippers? - Over there, [behind] the armchair."),
            ( "Автобус останавливается перед музеем. Выйдешь там.", "The bus stops [in front of] the museum. [Get off] there."),
            ( "Оставьте свои вещи там и идите за мной в гостиную.", "[Put ] your things [down ] there and [come into ] the front room with [me]."),
            ( "Как называется та вещь, [что лежит] там? - Не имею понятия.", "What is that [thing ] over there [called ]? - I have [no] idea."),
            ( "Как вы доехали [поездка была хорошей]? Нет у мне было неудобно в самолете.", "Did you have [a good trip ]? - No, I was [uncomfortable] in the plane."),
        };
    }
}
