using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_95 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"О, это письмо от Джорджа?  Я давно его не видела.",@"Oh, is that George's letter?  I haven't seen* him for a long time"),
            (@"Действительно, с той вечеринки в прошлом году. Как он поживает?",@"In fact, since the party last year. How is he?"),
            (@"О, прекрасно.  Ему нужна помощь в связи с его новой работой.",@"Oh, he's fine. He needs some help with his new job."),
            (@"Да, он работает в той школе со странным названием.",@"Yes, he's working in that school with a strange name."),
            (@"Ты имеешь в виду Ханджерфорд? Это школа, у которой прекрасная репутация.",@"You mean* Hungerford? It's a school that has an excellent reputation."),
            (@"Давно он там преподает?",@"How long has he been teaching* there?"),
            (@"Месяц. С того времени, как ушел [отказался] другой учитель. Кажется, ему это нравится.",@"For a month. Since another teacher resigned. He seems to be enjoying himself."),
            (@"Можно мне прочитать это письмо - Конечно, оно там, на телевизоре [наверху телевизора].",@"May I read* the letter? - Of course. It's over there on top of the television."),
            (@"Он всегда просит информацию, которую трудно найти.",@"He always asks for information which is difficult to find."),
            (@"Не совсем. В нашем офисе большая картотека.",@"Not really. We've got lots of files at the office."),
            (@"Надеюсь - он не ожидает, что ты напишешь книгу.",@"I hope he doesn't expect you to write a book!"),
            (@"Нет, только несколько строк с основными пунктами. Это не займет у меня слишком много времени.",@"No, just a few lines with the main points.  It won't take* too long."),
            (@"Надеюсь, что нет. - Начну немедленно, и это должно быть закончено самое позднее до завтра.",@"I hope not. - I'll start straight away and I should be finished by tomorrow at the latest."),
        };

        public override string[] Notes => new[]
        {
            (@"[For a long time] - давно, с давних времен. "),
            (@"[That] в данном предложении означает: которое и могло бы быть заменено относительным местоимением [which]. Смотри урок 39. "),
            (@"[То seem] - казаться, представляться, вроде бы, походить на что-нибудь. [It seems] - как мне кажется, оказывается, возможно, что. "),
            (@"[File] - картотека, акт, архив, подшивка за год, пачка (бумаг). "),
            (@"[Straight away] - немедленно, с места в карьер. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Это должно быть закончено до следующей недели.",@"It should be finished by next week."),
            (@"Завтра может идти дождь. - О, надеюсь, что нет.",@"It might rain tomorrow. - O, I hope not."),
            (@"Много ли времени займет написание книги?",@"How long will it take to write a book?"),
            (@"Кажется, он делает большие успехи.",@"He seems to be making good progress."),
            (@"Как обычно, в этом доме ничего не работает.",@"As usual, nothing works in this house!"), 
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн работает там уже месяц. С того времени, как ушел Джордж.", "Не [has been working ] there [for ] а month. [Since ] George [resigned]."),
            ( "Есяи выедешь немедленно, приедешь в девять. ", "If [you leave straight away ], you will arrive [by nine] o'clock."),
            ( "Я не понимаю, что именно он имеет в виду? ", "I [don't ] understand [what ] he [means exactly]."),
            ( "Он не ожидает, что ты напишешь книгу. - Надеюсь, что нет.", "Не doesn't [expect ] you [to write ] а book. - [I hope not]."),
            ( "Долго ждешъ? Уже час. ", "[ How long   ] have you [been ] waiting? - [For  ] an hour."),
        };
    }
}
