using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_64 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Когда Франция и Англия решили построить туннель под Ла-Маншем (Английским каналом), огласили конкурс.",@"When France and England decided to build* a tunnel under the Channel, they asked for tenders"),
            (@"Было принято предложение фирмы, (выступившей) с самым низким (дешевым проектом) предложением. Удивленные низкой ценой, они спросили директора:",@"The firm with the lowest offer was accepted. Astonished by the low price, they asked the director:"),
            (@"Как вы собираетесь это сделать за такие небольшие [маленькие] деньги?",@"- How are you going to do it for so little money ? "),
            (@"Это просто, - сказал инженер, - начну копать с английской стороны.",@"- It's easy, the engineer said, I will start digging* on the English side,"),
            (@"a мой сын начнет копать с французской стороны,",@"and my son will start digging* on the French side,"),
            (@"и встретимся в середине.", @"and we'll meet* in the middle."),
            (@"Но это абсурд! Вас будут разделять между собой мили.",@"- But that's ridiculous (D! You'll be miles apart."),
            (@"Что будет, если вы встретитесь.",@"What will happen if you don't meet* ?"),
            (@"В этом случае, - ответил спокойно инженер, - будете иметь два туннеля по цене одного.",@"- In that case, the engineer answered, you will have two tunnels for the price of one. "),
            (@"Турист в Каире увидел два черепа по магазине - большой и маленький.", @"A tourist in Cairo saw* two skulls in a shop: a large one and a small one."),
            (@"Чьи они? (Что это?) - спросил он. - Большой - череп царицы Клеопатры, - прозвучал ответ.",@" - What are those? he asked. - The big one is the skull of Queen Cleopatra, was the reply."),
            (@"Правда? - сказал удивленный турист. - А маленький?",@"- Really, said* the amazed tourist, and the little one?"),
            (@"Это череп Клеопатры, когда она была маленькой девочкой, - ответил владелец магазина.",@"- That is the skull of Cleopatra when she was a young girl, answered the shopkeeper. "),
            (@"На забудьте повторить формы неправильных глаголов.",@"Don't forget* to repeat the irregular verbs."),
        };

        public override string[] Notes => new[]
        {
            (@"[То ask for tenders] - огласить конкурс. "),
            (@"Вспомните: [so little money, so few people, so much noise, so many cars]. "),
            (@"[Ridiculous] - смешно, забавно, абсурдно, бессмысленно. "),
            (@"[То be apart] - находиться на расстоянии между собой. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мой сын построил свой собственный дом.",@"My son built his own house."),
            (@"Каждый знает слова Цезаря: Пришел, увидел, победил.",@"Everyone knows Caesar's words: I came, I saw, I conquered."),
            (@"Они позвонили вчера вечером, но нас не было.",@"They came last night, but we weren't in."),
            (@"Ты помнишь Джонса? Я встретил его вчера на улице.",@"Do you remember Jones? I met him in the street yesterday."),
            (@"Он спросил меня, как у тебя дела.",@"He asked me how you were."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Легко начать курить, трудно бросить. ", "[It] is easy to [start smoking ], but [more difficult] to [stop]."),
            ( "Кто будет завтра на приеме? - Не помню. ", "[Who will be ] at the [party ] tomorrow? -I don't [remember]."),
            ( "Когда сможешь [будешь в состоянии] назвать [дать] свою цену? - Сразу/немедленно.", "When [will you be able ] to give [me your price]? - At once."),
            ( "Что это [me]? - To? To - черепа животных. ", "[What are those]?- [Those]? They are [animal skulls]."),
            ( "Как ты собираешься это сделать до следующего черверга?", "How [are you going ] to do it [before next Thursday.]?"),
        };
    }
}
