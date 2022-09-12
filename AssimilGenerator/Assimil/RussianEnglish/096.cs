using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_96 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Помните ли вы, как в пятьдесят седьмом уроке Дэвид должен был пойти к врачу [увидеть врача]?",@"Do you remember, in Lesson fifty-seven, John had to see the doctor?"),
            (@"В Англии вы не платите ни врачу, ни больнице, а платите только небольшую сумму зубному врачу.",@"In England, you do not pay* the doctor or the hospital, and you pay* only a small charge  for the dentist."),
            (@"Это (так происходит) благодаря Государственной службе здоровья, которая оплачивает все медицинские расходы.",@"This is because of the National Health Service, which pays* all medical costs."),
            (@"Она частично финансируется из средств, называемых платежами Государственного страхования.",@"It is financed in part by contributions called National Insurance payments."),
            (@"Каждый работающий мужчина или женщина должны каждую неделю платить в госстрах индивидуальный взнос.",@"Every working man or woman has to make* a single  National Insurance contribution every week."),
            (@"Обязанностью работодателя является проверка того, заплачен ли взнос.",@"It is the responsibility of the employer to make* sure that the payments are made."),
            (@"Oн удерживает сумму с недельной или месячной зарплаты работающего, а потом добавляет свою собственную оплату.",@"He deducts a sum form the worker's wage or salary  and then adds his own contribution."),
            (@"Остальные деньги для Государственной службы здоровья идут из (фондов) общего налогообложения.",@"The rest of the money for the National Health Service comes* from general taxation. "),
            (@"Те, у кого доходы очень низкие, могут получить так называемое дополнительное пособие.",@"Those whose incomes are too low can obtain what is called Supplementary Benefit."),
            (@"Это (еже)недельное пособие, (которое) целиком финансировано из (фондов) общего налогообложения.",@"This is a weekly allocation   and is financed entirely by general taxation,"),
            (@"Государство также выплачивает пенсии людям, ушедшим на пенсию.",@"The State also pays* ""pensions"" to people in retirement"),
            (@"Эти люди известны как ""граждане сеньоры"".",@"These people are known* as ""senior citizens""."),
            (@"Таким образом, если вы идете к врачу, или с чем-то более серьезным (обращаетесь) в больницу,",@"So, when you go to the doctor's or, for something more serious, the hospital,"),
            (@"не нужно беспокоиться о расходах.",@"you do not have to worry about the cost."),
        };

        public override string[] Notes => new[]
        {
            (@"[Charge] - цена, расходы, издержки. [To charge] - назначать цену, взимать оплату. [They charged me thirty pence for a glass of water] - Они взяли с меня тридцать пенсов за стакан воды. [Service charge 15%] - Стоимость обслуживания 15%."),
            (@"[Contribution] - пожертвование, взнос, налог, контрибуция. [То make а contribution] - платить взнос. "),
            (@"[Working man] - трудоустроенный, работающий мужчина. [Worker] - работник, [workman] - рабочий."),
            (@"[Single] - единственный, одиночный, одинокий, холостой, незамужняя. [She is single] - Она не замужем. [А single  ticket] - билет в один конец, [а return ticket] - билет туда и обратно. "),
            (@"[Wage] - недельная зарплата; [salary] - месячная зарплата. [Income] - доход."),
            (@"[Taxation] - налогообложение; [tax] - налог; [taxpayer] - налогоплательщик; [income tax] - подоходный налог; [duty free goods] - беспошлинные товары. [VAT (value added tax)] - НДС (налог на добавленную стоимость). "),
            (@"[Allocation] - ассигнование, кредит; то, что получено в порядке распределения."),
            (@"[Retirement] - состояние отдыха; [in retirement] - на пенсии; [to retire] - уйти на пенсию."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Из-за тумана самолет опоздает.",@"Because of fog, the plane will be delayed."),
            (@"Старые люди, известные как ""граждане сеньоры"", получают пенсию.",@"Old people, known as ""senior citizens"", receive pensions."),
            (@" Его болезнь серьезна, доктор? - Надеюсь, что нет.",@" Is his illness serious, doctor? - I hope not."),
            (@"Удостоверься, что кровать застелена перед тем, как выйдешь.",@"Make sure that the bed is made before going out."),
            (@"Человек, доход которого слишком низок, может получать (еже)недельное пособие.",@"The person whose income is too low can obtain a weekly allocation."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мужчина, автомобиль которого был украден, может его найти в комиссариате полиции.", "The man [whose ] car has [been stolen] can find it [at] the police-station."),
            ( "Вы не должны проходить воинскую службу в Англии. ", "You [do not have to ] do [military service] in England."),
            ( "Удостоверься, что двери закрыты перед тем, как уйдешь.", "[Make sure ] that [the doors ] are locked [before going out]."),
            ( "Нет ли у тебя намерения посмотреть эту новую пьесу? ", "[Aren't ] you going [to see ] that [new play]?"),
            ( "Чья это ответственность? ", "[Whose ] is the [responsiblity]?"),
        };
    }
}
