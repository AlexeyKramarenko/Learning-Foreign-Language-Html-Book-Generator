using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_88 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Привет Джоэн! Извини, я опоздал. (Я) как раз встретил старого Бакера. Он такой зануда [скучный],",@"Hello Joan! Sorry, I'm late. I've just met* ® old Barker. He's so boring."),
            (@"(Он) начал рассказывать мне о своем отпуске. ""Ты должен туда поехать, ты обязан туда поехать"".", @"He started telling* me about his holiday: ""You must go here, you should go there""."),
            (@"Действительно, мы должны начать думать о нашем отпуске, ты (же) знаешь (об этом).",@"Actually, we should start thinking* about our holiday, you know*  ."),
            (@"Да; куда, мы говорили, хотели бы поехать?",@"Yes; where did we say we would go*?"),
            (@"[Хорошо], ты сказал, что поедем или в Испанию, или в Шотландию.",@"Well, you said* we would go* either to Spain or to Scotland."),
            (@"A-a, но я также думал об Уэльсе с тех пор, как встретил коллегу, который ездил туда в прошлом году.",@"Ah, but I've also been thinking* of Wales since I met* a colleague who went^ there last year."),
            (@" O нет! Ты обещал, что поедем за границу в этом году.",@"Oh no! You promised we could go* abroad this year."),
            (@"Да, но это было до того, как я получил банковскую выписку (со счета). Уэльс дешевле Испании.",@"Yes, but that was before I received my bank statement. Wales is cheaper than Spain."),
            (@"Да, но я хочу загореть! Купила себе новое бикини,",@"Yes, but I want a sun tan! I've even bought* a new bikini."),
            (@"Что ж, в Уэльсе солнечно, пейзаж фантастичен..., а мы без денег.",@"Well, it's sunny in Wales, the scenery is fantastic... and we're broke"),
            (@"Ты несносен [невозможный]. Я собираюсь пойти завтра в туристическое агенство и забронировать два места на какой-нибудь самолет. Спокойной ночи!",@"You're impossible! I'm going* to the travel agent's tomorrow to book two seats on any plane. Good night!"),
            (@"Дэвид вздохнул, когда Джоэн хлопнула дверью.",@"David sighed as Joan slammed the door."),
            (@"Он сел в кресло, налил себе шотланского виски",@"He sat* down in an armchair and poured himself a Scotch"),
            (@"и начал просматривать брошюры туристических агенств.",@"and began* to look at the travel agent's brochures."),
        };

        public override string[] Notes => new[]
        {
            (@"[I've just met] - сокращение от [I have just met. I've just bought a house] - Я только что (недавно) купил дом. [I've just eaten] - Я как раз ел."),
            (@"[You know] - оборот, используемый в разговорной речи со значением ""знаешь, понимаешь"". "),
            (@"Если первая часть сложного предложения выражена прошедшим временем, то и другая часть тоже должна  стоять в прошедшем времени. Так, во второй части  предложения [Where did we say we would go?] служебный О глагол [will] заменен на [would]. Это называется последовательностью времен. "), (@"[То break, broke, broken] - ломать, разрушать [to be broken] - быть разоренным, сидеть без денег, без гроша. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Она сказала, что возьмет меня с собой в Лондон.", @"She said she would take me to London."),
            (@"Я не слышал, что он говорил, вот и ушел.",@"I couldn't hear what he was saying, so I left."),
            (@"Могу я вам (чем-то) помочь? <br> - Да, я хотел бы получить некоторую информацию.",@"May I help you? <br> - Yes, I would like some information, please."),
            (@"Ты можешь одолжить мне двадцать пенсов? <br> - Извини, у меня нет ни гроша.",@"Can you lend me twenty pence? <br> - I'm sorry, I'm broke."),
            (@"Ты должен выбрать или одно или другое.",@"You must choose either one or the other."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Я сисду его с десяти, а его все еще тут нет. ", "I [have been ] waiting for him [since ] ten and he [isn't ] here [yet]."),
            ( "Oн спит с той поры, как мы выехали из Лондона. ", "Не has [been sleeping since ] we [left] London."),
            ( "Да, но это было перед тем, как я получил мою банковскую выписку.", "Yes, but [that was ] before [I received (got) ] my [bank]-[ statement  ]."),
            ( "Ни ты, ни она не могли бы этого сделать. ", "[Neither ] you [nor ] she [could do it]."),
            ( "Он сказал, что покажет мне свое кресло. Это новая модель.", "Не [told me ] he [would show ] me [his armchair ]. It's the [new model]."),
        };
    }
}
