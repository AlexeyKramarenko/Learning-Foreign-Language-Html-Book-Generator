using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_144 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Я хотел бы поменять немного денег. Какой сегодня курс?",@"['d like to change some money. What is the rate today?"),
            (@"Двадцать фунтов в пятифунтовых купюрах и десять в купюрах по одному фунту.",@"Twenty pounds in five pound notes and ten in one pound notes"),
            (@"У вас есть какие-то мелкие (деньги)?  Могу ли я использовать мою чековую книжку?",@"Do you have any change? May I use my chequebook?"), (@"Ha почте",@"In a post-office"),
            (@"Я хотел бы выслать телеграмму. Сколько стоит слово?",@"I'd like to send* a telegram. How much per word?"),
            (@"Мне нужно несколько марок. Сколько стоит послать открытку во Францию?", @"I need some stamps. How much is it to send* a postcard to France?"),
            (@"Я хотел бы реализовать денежный почтовый перевод (получить за него наличные).",@"I'd like to cash   this money order."),
            (@"В гостинице",@"At the hotel"),
            (@"Я хотела бы одноместную комнату. Есть только двухместная комната?", @"I'd like a single room please. You only have a double room  ?"),
            (@"А в комнате есть душ и туалет?", @"Does the room have a shower and a toilet?"),
            (@"Если кто-нибудь позвонит, когда меня нет, не могли бы Вы принять информацию?", @"If anyone calls while I'm out, could you take* a message  ?"),
            (@"Пожалуйста, приготовьте мой счет. Я выезжаю утром.", @"Please prepare my bill, I'm leaving in the morning."),
            (@"Покупки", @"Shopping"),
            (@"Я боюсь, что не знаю своего размера. Нет ли у вас чего-нибудь поменьше?", @"I'm afraid I don't know* my size. Do you have anything smaller?"),
            (@"Могу ли я это померить? Не очень хорошо лежит. Мне не идёт.",@"May I try it on  ? It doesn't fit very well. It doesn't suit me."),
            (@"Я подумаю. Это немного дороговато. Я вернусь позже,",@"I'll think* it over. It's a little too expensive. I'll come* back later."),
        };

        public override string[] Notes => new[]
        {
            (@"Обратите внимание на написание: [five-pound note] - пятифунтовая купюра, [fifty-pence piece] - пять пенсов, [а four-star hotel] - четырехзвездочная гостиница. "),
            (@"[Cash] - наличные; [to cash] - получить наличными; [cashier] - кассир; [cash-desk] - касса."),
            (@"Запомните эти предложения: [You only have а double left] - Осталась только двухместная комната. [I've only got two cigarettes left] - У меня осталось только две сигареты.  [How many do you have left?] - Сколько у тебя осталось? "),
            (@"[То take а message] - принять информацию, известие', [to  leave а message] - оставить информацию, известие. "),
            (@"[То try on] - мерить. "), 
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Где я могу поменять свои дорожные чеки?",@"Where can I change my travellers cheques?"),
            (@"Поспеши, осталось только пять минут,",@"Hurry up, there are only five minutes left."),
            (@"Я ожидал пятнадцать минут, чтобы меня обслужили.",@"I have been waiting to be served for a quarter of an hour."),
            (@"Мы ожидаем, что вы оплатите свой счет.",@"We expect you to pay your own bill."),
            (@"Этот пиджак лежит не очень хорошо.",@"This jacket doesn't fit very well."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Если ты хочешь это купить, ты должен решится, осталось только пять.", "If you [want ] to buy it you [must ] make [up ] your [mind ], there are only [five left]."), 
            ( "Обдумай это и позвони мне, когда примешь решение. ", "[Think ] it [over ] and [call/ring/phone] me when you [have taken/made] your decision."), 
            ( "Я не ожидала тебя (в это время), нет еще двух часов [до двух часов]. Ты доехал благополучно?", "I didn't [expect ] you [before ] two o'clock. Did you have [a good trip]?"), 
            ( "Кто-то звонил, когда меня не было? ", "Did [anyone/anybody ] call [while ] I was [out]?"), 
            ( "Она приезжает в Англию (уже) четыре года и все еще не знает своего размера.", "She has [been coming ] to England [for ] four years and she [still ] doesn't know [her] size."), 
        };
    }
}
