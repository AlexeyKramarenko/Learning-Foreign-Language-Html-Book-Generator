using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_92 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Джек, мне холодно* Закрой окно, на дворе [снаружи] холодно.",@"Jack, I'm freezing* ®. Close the window, . it's cold outside."),
            (@"Ты хочешь, чтобы я встал с постели [вылез из кровати] и закрыл окно,",@"You want me to get out of bed and close the window,"),
            (@"но, если я это сделаю, не будет тепло снаружи.",@"but if I do, it won't be warm outside."),
            (@"Расскажи мне о разводе миссис Хэйнс.",@"Do tell* me about Mrs Haines' divorce."),
            (@"Я бы предпочла, чтобы ты спросила саму миссис Хэйнс.",@"I'd prefer you to ask Mrs Haines herself!"),
            (@"Мы полагаем, что она приедет в восемь часов.",@"We expect her to arrive at eight o'clock."),
            (@"Надеюсь, что поезд придёт [будет] вовремя. Я не люблю ждать.",@"I  hope the train will be on time. I don't like waiting."),
            (@"Он хотел бы, чтобы они представились сами, поскольку забыл их фамилии.",@"He'd like them to introduce themselves because he has forgotten* their names."),
            (@"Мы попросили их, чтобы они зашли на стаканчик (вина) сегодня вечером,",@"We've asked them to come* round for drinks this evening,"),
            (@"но они хотели бы прийти на обед (ужин).",@"but they would liке to come* to dinner."),
            (@"Ты хотела бы, чтобы я забронировал билеты в театр?",@"Would you like me to make* reservations for the theatre?"),
            (@"Нет, спасибо, я сделаю это сама.",@"No thanks, I'll do it myself."),
            (@"Я хотел бы, чтобы ты помолилась перед едой.",@"I'd like you to say a prayer before your meal."),
            (@"Но зачем? Моя мама хорошо готовит [хорошая кухарка].",@"But why? My mother is a good cook."), 
        };

        public override string[] Notes => new[]
        {
            (@"[То freeze, froze, frozen] - мерзнуть, замерзать. [I'm freezing] - я мерзну, мне холодно - это выражение сильнее, чем [I'm cold] - мне прохладно. Напомним, что [warm] - тепло; [hot] - жарко, горячо; [cool] - холодно; [cold] - прохладно. "),
            (@"Обратим внимание на конструкцию: подлежащее - сказуемое - дополнение и инфинитив. Нам уже  встречалось много предложений, построенных по такой   схеме. Мы переводили их с помощью союза чтобы: [You   want me to get out of bed] - Ты хочешь, чтобы я встал с   постели. "), (@"Оборот [Do tell me] - Расскажи мне (непременно) представляет английскую формулу подчеркивания просьбы. Таким образом, если мы хотим на что-либо обратить внимание, ставим [do] перед глаголом. "),
            (@"[То come round] - заглянуть к кому-нибудь. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"(Не) можешь ли сам его спросить; у меня нет [не имею достаточно] времени.",@"Will you ask him yourself; I haven't enough time."),
            (@"Мне это сделать, или ты хочешь, чтобы она это сделала?",@"Shall I do it, or do you want her to do it?"),
            (@"Мы рассчитываем, что они принесут бутылку вина.",@"We expect them to bring a bottle of wine."),
            (@"Я хотел бы, чтобы они принесли пирожное.",@"I’d prefer them to bring a cake."),
            (@"Сколько времени тебе нужно, чтобы закончить?",@"How much time will you need to finish?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "(He) хочешь ли ты, чтобы я представил тебя той девушке, там?", "[Do ] you [want me to introduce  ] you to that girl over there?"),
            ( "Я возьму машину, если метро бастует. ", "[I'll take ] the саr [if ] the tube [is on strike]."),
            ( "Мы рассчитываем, что она придет где-то в двадцать минут одиннадцатого.", "We [expect her ] to arrive [at about twenty past ten ]."),
            ( "Oн (никогда) не женится. Он не любит тратить деньги.", "Не [won't ] get married. Не [doesn't like spending ] money."),
            ( "В котором часу ты хотел бы, чтобы я пришёл? ", "[What ] time [do you want me] to come? "),
        };
    }
}
