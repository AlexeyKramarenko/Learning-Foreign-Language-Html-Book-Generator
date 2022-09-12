using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_94 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дорогой Дэвид. Большое спасибо за твое последнее письмо.",@"Dear David, Thanks very much for your last letter."),
            (@"Я надеюсь, что вы оба в порядке. Я полностью удовлетворен моей новой работой.",@"I hope you are both well. I'm thoroughly enjoying my new job."),
            (@"Человек, должность которого я занял, подал в отставку в прошлом месяце.",@"The person whose position I've taken resigned last month."),
            (@"Я могу понять почему, поскольку много работы [чтобы делать].",@"I can understand why, because there's a lot of work to do."),
            (@"Я пишу, чтобы попросить тебя об одолжении.",@"I'm writing* to ask you a favour"),
            (@"Ты (не) мог бы отыскать мне немного информации о профсоюзах.",@"Could you get me some information on trade unions?"),
            (@"Я должен был читать лекцию на прошлой неделе и не мог найти достаточного (количества) сведений.",@"I had to give a lecture last week and I couldn't find* enough details,"),
            (@"Я должен был попросить тебя раньше, но ты знаешь, как это (получается) [есть].",@"I should have asked you earlier, but you know how it is."),
            (@"С тех пор как последний раз тебя видел, (мало что) [немногое! произошло.",@"Since I last saw* you, nothing much has happened."),
            (@"Я много [тяжело] работал в этом месяце и у меня так мало свободного времени!",@"I've been working hard for a month and I've had so little spare time  !"),
            (@"(Я) видел Пита на прошлой неделе. Ты, конечно, знаешь, что он женился.",@"I saw* Pete last week. You know*, of course, that he's married."),
            (@"Фактически он женат уже больше года.",@"In fact he's been married for over a year."),
            (@"Он всегда говаривал: ""Брак - это прекрасный институт,",@"He always used  to say: ""Marriage is a great institution,"),
            (@"но кто кочет жить в институте""?",@"but who wants to live in an institution?""."),
            (@"Посмотри сейчас на него! Иных [больше] новостей нет, поэтому говорю тебе: ""До свиданья"".  С нетерпением жду от тебя известий [вскоре].",@"Look at him now!  There's no more news, so I'll say good-bye. Looking forward to hearing from you soon,"),
            (@"Твой друг/приятель, Джордж.",@"Your friend, George."),
        };

        public override string[] Notes => new[]
        {
            (@"[Thoroughly] - вполне, совершенно, до конца. [I'm thoroughly enjoying it] - Я полностью удовлетворен этим. [I'm thoroughly bored] - Мне страшно надоело. "),
            (@"[I've taken], как вы помните, является сокращением от [I have taken]. Сокращения нередки в личной переписке, где,' как правило, используется разговорный язык. Официальная же корреспонденция, основанная на формальных разновидностях языка, в принципе сокращения избегает. "),
            (@"[То ask а favour] - попросить кого-то об одолжении, любезности. [Do а favour] - оказать кому-либо услугу. "),
            (@"[I should have asked you] - Я должен был тебя попросить. "),
            (@"[Since I last saw you] - С тех пор как последний раз тебя видел - этот оборот можно трактовать как сокращение от [Since the last time I saw you]. "),
            (@"[Spare time] - свободное время, равно как [free time. Spare  parts] - запасные части. "),
            (@"[To use] - использовать; [used] - использованный, бывший в употреблении; [to be used to] - иметь привычку; [he used to say] - имел привычку говорить, говаривал. "),
            (@"[Looking forward to hearing from you] - это типичный оборот, используемый в письмах - С нетерпением жду от тебя известий."), 
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я любила [имела обыкновение любить] пирожные, когда была моложе.",@"I used to like cakes when I was younger."),
            (@"Я много [тяжело] работал с того времени, когда последний раз тебя видел.",@"I have been working hard since I last saw you."),
            (@"Я надеюсь, что он будет в состоянии получить для меня какую-то информацию.",@"I hope he will be able to get some information for me."),
            (@"Она только раз была в Австрии.",@"She has only been to Austria once."),
            (@"Она забыла свой кошелек, вот и должна была взять взаймы немного денег.",@"She forgot her purse, so she had to borrow some money."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мы с нетерпением ждем, когда же пойдём в отпуск/ на каникулы.", "We are [looking forward] to [going] on holiday."),
            ( "Стадд, широко [хорошо] известный художник, имел обыкновение [привычку] здесь жить.", "Studd, the well-[known ] painter [used to live] here."),
            ( "Человека, у которого украли чемодан, зовут Сандерс. ", "The man [whose ] suitcase [was stolen ] is [called] Sanders."),
            ( "Oн работает/работал в этой фирме в течение трех лет.", "Не [has been working ] for this company [for three years]."),
            ( "Куда ты положил запасную шину? Я не помню. ", "Where [did you put ] the [spare] tyre? -I [don't remember]."),
        };
    }
}
