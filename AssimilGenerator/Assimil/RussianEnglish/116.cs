using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_116 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"В воскресенье Дэвид решил, что поедет проведать [посмотреть] своих родителей, которые живут в Оксфорде.",@"On Sunday, David decided he would go and see* his parents who lived in Oxford."),
            (@"Они хотели выехать рано, чтобы избежать пробок [толкотни], поэтому встали в полседьмого.",@"They wanted to leave* early to avoid the crowds, so they got up at half past six."),
            (@"Около семи часов они были готовы. Сели в автомобиль и отправились (в путь).",@"By seven o'clock, they were ready. They got into the car and set off ."),
            (@"Ты взял все (ничего не забыл)? - спросила Джоэн.",@"- Have you got everything? said Joan."),
            (@"Конечно же, (все). Я вчера вечером позвонил папе и сказал, что мы приедем около десяти.",@"- Of course I have.  I rang*   Dad last night and told* him we would arrive at about ten."),
            (@"Они выехали на автостраду и вскоре быстро ехали по направлению к Оксфорду.",@"They took* the motorway and were soon driving* quickly towards Oxford."),
            (@"Я уверена, что мы что-то забыли, - сказала Джоэн.",@"""I'm sure we've forgotten* something, said Joan."""),
            (@"Нет, подарки на заднем сиденье, а книга, которую хотел папа, в бардачке,", @"- No, the presents are on the back seat and the book Dad wanted is in the glove compartment,"),
            (@"наша сумка с дорожными вещами в багажнике - что мы могли забыть?",@"our over-night bag is in the boot - what could we have forgotten*?  "),
            (@"Они ехали в тишине, Джоэн смотрела на окрестности,",@"They drove* on in silence. Joan looked at the countryside  ,"),
            (@"и время от времени поглядывала на спидометр, удостоверяясь, что они не превышают ограничения скорости.", @"and from time to time glanced at the speedometer to make* sure they were not breaking*   the speed-limit."),
            (@"Как далеко еще?  - Только [одни] пятьдесят миль. Будем там через час.", @"""How far to go?  - Only another fifty miles.  We'll be there in an hour."""),
            (@"Вдруг мотор закашлялся и автомобиль стал сбавлять ход.",@"Suddenly, the motor coughed and the car began* to slow down."),
            (@"Черт! Знаю, что забыл. Забыл наполнить бак перед выездом.",@"""Damn! I know what I forgot*. I forgot* to fill the tank before leaving*."""),
        };

        public override string[] Notes => new[]
        {
            (@"[То set off] - отправиться (в путь). "),
            (@"[То ring, rang, rung] - звонить, позвонить. [Ring] - колечко;  [ear-ring] - сережка. "),
            (@"[Over-night bag] - сумка с дорожными вещами (дословно: на ночь). "),
            (@"[Countryside] - пейзаж:, окрестности, "),
            (@"[To break, broke, broken] - сломать, сбить, разбить. [To break the speed limit] - превысить ограничение скорости. [To break the law] - преступить закон. [To break a promise] - не сдержать обещания."),
            (@"[How far to go?] - [Как] далеко еще? "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Во сколько он позвонил прошлой ночью?",@"What time did he ring last night?"),
            (@"Как далеко еще? <br> - Только около двадцати миль.",@"How far to go? <br> - Only about twenty miles."),
            (@"Ты не должна прибывать в театр во время представления.",@"You shouldn't arrive at the theatre during the performance."),
            (@"Они остановились, чтобы наполнить бак, после чего поехали дальше.",@"They stopped to fill the tank, then drove on."),
            (@"Перед выездом, пожалуйста, замкни все двери и закрой все окна.",@"Before leaving, please lock all the doors and close the windows."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "В mo время, когда Дэвид вел (машину), Джоэн осматривала окрестности.", "While David [was driving ] Joan [was looking at ] the [countryside]."),
            ( "Я позвонил ему вчера, чтобы сказать, что мы приедем около восьми.", "I [rang him ] yesterday [to say ] that we [would ] arrive [at about] eight."),
            ( "Ты взял [имеешь] все? - Конечно, что бы я мог забыть?", "[Have ] you [got everything ]? - Of course, what [could I] have forgotten?"),
            ( "Ha протяжении недели он читает по три часа каждый день.", "[During ] the week, he reads [for ] three hours [a] day."),
            ( "Удостоверься, что ничего не забыл. ", "[Make sure ] that you [have forgotten] nothing."),
        };
    }
}
