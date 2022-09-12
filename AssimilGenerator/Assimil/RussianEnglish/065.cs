using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_65 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид Вильсон ездит [путешествует] на работу каждое утро на метро.",@"David Wilson travels to work every morning by tube."),
            (@"Метро - или подземка - это нечто такое, как Метро в Париже.",@"The tube - or the Underground - is something like the Metro in Paris."),
            (@"Ho, в отличие от Метро, скорее всего старомодное и довольно [совсем] дорогое.",@"But, unlike  the Metro, it is rather old- fashioned and quite expensive."),
            (@"Платишь в зависимости от расстояния, которое хочешь проехать.",@"You pay  according to  the distance you want to travel."),
            (@"Можно купить временный билет, который позволяет ездить [путешествовать] определенное время за меньшую плату [цену].",@"You can buy* a season ticket , which allows  you to travel for a certain period at a lower price."),
            (@"Несмотря на то, что большая часть метро автоматизирована, все еще есть рабочие, которые проверяют твой талон на выходе.",@"Although most of the tube is automatic, there are still employees who check your ticket at the exit."),
            (@"Поэтому надо сохранять свой талон, пока не закончишь ездить [путешествовать].",@"So you must keep* your ticket until ® you finish your journey."),
            (@"Можно также ездить [путешествовать] на автобусе, который ездит медленнее, но из него открывается [он дает] лучший вид.",@"You can also travel by bus, which is slower but gives* you a better view."),
            (@"Большинство автобусов имеет два этажа и разрешается курить на втором этаже.",@"Most buses are double-deckers and you are allowed to smoke upstairs."),
            (@"В этих автобусах есть водитель и кондуктор, который собирает деньги [оплату за проезд].",@"On these buses, there is a driver and a conductor, who collects your fares"),
            (@"И наконец, есть знаменитые лондонские такси или ""Хакнэй Кэбз"".", @"Finally, there are the famous London taxis, or ""Hackney Cabs"""),
            (@"Эти большие, черные машины с дизельными двигателями [средства транспорта! - это привычный пейзаж Столицы.",@"These large, black, diesel-engined vehicles are a familiar sight in the Capital."),
            (@"Если такси свободно, спереди вы увидите маленькую надпись: ""Свободно"" [сдается]", @"If the cab is free, you will see* a little ""For Hire"" sign in the front."),
            (@"Конечно, лучший способ посмотреть город - это ходьба пешком, но время от времени надо отдыхать.",@"Of course, the best way to see the city is on foot, but you need a rest from time to time."),
        };

        public override string[] Notes => new[]
        {
            (@"[Transport] - имеет значение транспорт, поставка, поставлять"),
            (@"[Unlike] - в отличие, не похоэюе на кого-либо. [It's unlike him to be late] - Это на него не похоже, чтобы он опаздывал."),
            (@"[You pay] - кроме значения ты платишь, вы платите имеет также значение безличной формы глагола - платится или инфинитива платить. "),
            (@"[According to] - соответственно с, согласно чему-либо, в зависимости от чего-либо, по чьему-то мнению. [According to him this restaurant is terrible.] - По его мнению этот ресторан ужасный. "),
            (@"[А season ticket] - проездной, временный билет, талон. "),
            (@"[То allow] - разрешать, допускать возможность; [to be allowed] - разрешается кому-либо; [I am allowed to smoke] - Мне разрешили курить, но you [are not allowed to smoke] - тебе нельзя курить. Антонимом [to allow] являетя глагол to forbid."),
            (@"Часть предложения, которая дается после [until] - пока, до какого-то времени переводится с помощью отрицательной формы: [Until you finish your journey] - пока не закончишь свое путешествие."),
            (@"[Fare] - oплата за проезд. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"В конце поездки надо показать билет.",@"At the end of the journey, you must show your ticket."),
            (@"Это не похоже на него, чтобы он говорил такое [такие вещи].",@"It's unlike him to say things like that."),
            (@"Тебе нельзя курить в этом здании.",@"You are not allowed to smoke in this building."),
            (@"Мой паспорт был проверен полицией.",@"My passport was checked by the police."),
            (@"Время от времени он поглядывал на часы, чтобы проверить время.",@"From time to time, he looked at his watch to check the time."), 
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "По его мнению, нам нельзя здесь парковаться. ", "[According to ] him, we are [not allowed ] to park here."),
            ( "Несмотря на то, что большинство из них не могут прийти.", "[Although most of them ] cannot come."),
            ( "Дэвид и Дэюоэн все еще хотят выйти с нами. ", "David and Joan [still ] want to [come (go) out ] with [us]."),
            ( "Храни свой талон пока не доедешь до выхода. ", "[Keep ] your [ticket ] until you reach the [exit]."),
            ( "Когда я закончу, ты проверишь упражнение? ", "When I have [finished ], will you [check ] the [exercise]?"),
        };
    }
}
