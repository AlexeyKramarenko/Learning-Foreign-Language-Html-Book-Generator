using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_61 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Я взял эти буклеты [брошюры] вчера в бюро путешествий.",@"I got* these brochures yesterday from the travel agent's."),
            (@"О, хорошо!  Просмотрим их!	",@"Oh good! Let's have a look at them!"),
            (@"Мне нравятся эти, об Испании. Поедем в Испанию в этом году.",@"I like the ones about Spain. Let's go* to Spain this year."),
            (@"Ни я, ни ты не говорим по-испански.",@"But neither you nor I speak* Spanish."),
            (@"Ничего страшного. В этих городах все говорят [каждый говорит] по-английски.",@"It doesn't matter. In these towns, everybody speaks* English."),
            (@"Что ж, можем поехать или в Испанию, или в Шотландию.",@"Well, we can either go* to Spain or to Scotland."),
            (@"В Шотландию! Но в Шотландии холодно, а я хочу немного солнца.",@"Scotland! But it's cold in Scotland and I want some sun."),
            (@"Не слишком холодно и очень красиво. И не надо лететь самолетом.",@"It's not too cold, and it's very beautiful. And you don't have to take* a plane."),
            (@"Я не люблю летать и ты тоже.",@"I don't like flying and neither do you."),
            (@"Но испанский более легкий для понимания, чем английский, на котором говорят в Шотландии.",@"But Spanish is easier to understand* than the English they speak in Scotland."),
            (@"Нонсенс! Во всяком случае, мы бы могли увидеть Лохнесское чудовище.",@"Nonsense! Anyway, we might see* the Loch Ness Monster."),
            (@"Его не существует! - Откуда ты знаешь?",@"It doesn't exist! - How do you know*?"),
            (@"Это либо какой-то миф, либо выдумка, чтобы привлечь туристов.",@"It's either a myth or an invention to attract tourists."),
            (@"Что ж, мы должны решить: или Испания или Шотландия.",@"Well, we must decide: either Spain or Scotland."),
        };

        public override string[] Notes => new[]
        {
            (@"[Travel agent's] - бюро путешествий, [at the butcher's] - у мясника, [at the baker's] - в пекарне. В этих выражениях опускаем существительное [shop: at the butcher's shop], так как они и так понятны без него. "),
            (@"Мы помним, что в английском языке соблюдается принцип однократного отрицания. В этом предложении отрицание заключается в обороте [... neither ... nor].  "),
            (@"[You don't have to take a plane] - переводим в безличной форме как ""не надо лететь самолетом""."),
            (@"[Might] является формой прошедшего времени от [may] - мочь. [I might come] - возможно, что приду конструкцию можно также переводить с помощью условного наклонения: [We might see him] - Мы бы могли его увидеть."),
            (@"[Invention] означает изобретение, выдумка. [То invent] - изобрести."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Боюсь, что я должен уйти. Уже поздно и становится темно.",@"I’m afraid I have to leave. It's late and it's getting dark."),
            (@"Я предпочитаю те, которые он показал нам на прошлой неделе.",@"I preferred the ones he showed us last week."), (@"Мы должны решить быстро, иначе будет слишком поздно.",@"We must decide quickly or it will be too late."),
            (@"Я боюсь летать (полета самолетом). - Я тоже.",@"I'm afraid of flying. - So am I."),
            (@"Поглядим на эти новые буклеты.",@"Let's have a look at those new brochures."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Moжешь ехать или на автобусе, или на машине. Автобусом быстрее.", "You can go [either by ] bus or [by ] car. The bus is [quicker (faster)]."),
            ( "Ни ты, ни я не понимаем испанского языка. Ничего страшного.", "[Neither ] you [nor ] I [understand ] Spanish. - It [doesn't matter]."),
            ( "Возможно, что он прилетит самолетом, но я так не думаю.", "Не [might ] come [by ] plane, but I [don't think so]."),
            ( "Oн боится полета (самолетом) и я тоже. ", "He's [afraid (scared) ] of [flying... ] and [so am I]."),
            ( "Возможно, что она позвонит сегодня вечером. Подождем [нам нужно будет подождать].", "She [might ] phone [this evening ]. We will [have to] wait."),
        };
    }
}
