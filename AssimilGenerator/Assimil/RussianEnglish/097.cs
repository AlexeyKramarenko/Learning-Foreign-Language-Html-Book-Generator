using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_97 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Как обычно, изучите этот урок, а потом ответьте на следующие вопросы, пользуясь последним уроком.",@"Learn this lesson as usual, then answer the following questions with the help of the preceding lesson."),
            (@"Сколько Дэвид должен был заплатить врачу, когда был болен?",@"How much did David have to pay* the doctor when he was ill?"),
            (@"Что такое Государственная Служба Здоровья?",@"What does National Health Service mean*?"),
            (@"Как финансируется Государственная Служба Здоровья?",@"How is the National Health Service financed?"),
            (@"Кто несет ответственность за еженедельные взносы?",@"Whose   responsibility is the weekly contribution?"),
            (@"Кто должен платить взносы в Государственную Страховую Компанию?",@"Who has to make* National Insurance contributions?"),
            (@"Платит ли что-нибудь работодатель?",@"Does the employer pay* anything?"),
            (@"Кто получает дополнительное пособие?",@"Who receives Supplementary Benefit?"),
            (@"Кем являются пожилые граждане?",@"Who are senior citizens?"),
            (@"Два маленьких мальчика, которые посещали Британский музей, остановились, чтобы посмотреть на египетскую мумию.",@"Two little boys who were visiting the British Museum stopped to look at the Egyptian mummy."),
            (@"Мумия была покрыта бинтами, а на шее [вокруг шеи] была табличка [знак] с 1215 г. до н.э. (тысяча двести пятнадцать).",@"The mummy was covered with bandages and had a sign 1215 B.C.   (one thousand two hundred and fifteen) around its  neck."),
            (@"Я думаю [над тем], что означает эта табличка, сказал один из мальчиков.",@"- I wonder  what that sign means*, said one of the boys."),
            (@"Это должен быть номер машины, которая его переехала, ответил его приятель.",@"- That must be the number of the car which knocked   him over”, replied his friend."),
        };

        public override string[] Notes => new[]
        {
            (@"[Whose] в этом предложении переводим как: кто. "),
            (@"[B.C. - Before Christ] - до нашей эры [перед Христом] - до нд н.э. "),
            (@"[Mummy] в английском языке среднего рода, поэтому и местоимение среднего рода [its]. "),
            (@"[To wonder] - думать, размышлять, задуматься над чем-нибудь, [wonderful] - чудесный."),
            (@"[То knock] - стучать, [to knock over] - переехать, перевернуть, [to knock out] - нокаутировать."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Наш телефон поломался и мы не могли отвечать ни на какие звонки.",@"Our phone was broken and we couldn't receive any calls."),
            (@"Мы бы предложили помощь, если бы она не была бесполезна.",@"We'd offer to help if it wasn't useless."),
            (@"Ты должен был немедленно заплатить мужчине.",@"You should have paid the man straight away,"),
            (@"Если бы она сделала другую прическу, могла бы выглядеть красиво.",@"If she did her hair differently she could look nice."),
            (@"Могу не заплатить мой взнос на этой неделе.",@"I might not pay my contribution this week."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Если бы мы устроили прием на будущей неделе, то кто смог бы прийти?", "If we [gave/had ] а party [next week ] who [would be able to come ]?"),
            ( "Не мог бы ты мне сказать, что такое «еженедельный взнос»?", @"[Could ] you [tell ] me [what ] ""weekly contribution"" [means]?"),
            ( "Из-за дождя матч был отменен. ", "[Because of ] the [rain ], the match [has been  ] cancelled."),
            ( "Должен ли я заплатить что-нибудь за обслуживание ?", "[Must ] I pay [something ] for the [service]? "),
            ( "Бутылка была покрыта пылью и вокруг горлышка была паутина.", "The bottle was [covered with ] dust and [had ] cobwebs [around] the neck."),
        };
    }
}
