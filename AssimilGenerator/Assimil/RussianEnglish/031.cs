using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_31 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Иногда Дэвид и Джоэн едят не дома (выходят, чтобы что-нибудь поесть).",@"Sometimes, David and Joan go out to eat."),
            (@"Там, где они живут, очень мало английских ресторанов.",@"There are very few English restaurants where they live."),
            (@"Большинство из них - это или индийские, или китайские (рестораны), а также несколько итальянских.",@"Most of them are either Indian or Chinese, with a few Italian ones,"),
            (@"Они любят индийскую еду, хотя она для Джоэн слишком острая.",@"They Hke Indian food, though Joan finds it very hot ®."),
            (@"Блюда вполне дешевы и обильны [в них есть много съестного].",@"The meals are quite cheap and there is a lot to eat."),
            (@"Они едят рис с карри и фруктами, - и Джоэн пьет много воды.",@"They eat curry and rice and fruit - and Joan drinks a lot of water."),
            (@"Английские блюда можно найти в пабах, так же, как и пиво, но пабы рано закрываются.",@"You can find English food in pubs, as well as beer, but they shut quite early."),
            (@"Здравствуй, дорогой. - Здравствуй, любимая.",@"Hello, darling. - Hello love."),
            (@"Хочешь пойти [выйти] в ресторан сегодня вечером?",@"Do you want to go out to a restaurant tonight?"),
            (@"Нет. Я приготовила жаркое. Поедим дома,",@"No, I've cooked a roast. We're going to eat ® in."),
            (@"О'кей. Пойду куплю немного вина в магазине [пабе].",@"Okay, I'll go and buy some wine at the off-licence ®."),
            (@"Хорошо, только не задерживайся, чтобы поиграть в ""дротики"".",@"Yes, but don't stop to play darts."),
            (@"Нет. Матч игры в дротики был вчера вечером.",@"No. The darts match was last night."),
        };

        public override string[] Notes => new[]
        {
            (@"[Few] смотри урок 22 объяснение "),
            (@"[Most] - большинство, [most of them] - большинство из них. "),
            (@"[Either... or] переводим как или .... или. "),
            (@"[English, German, Indian, Chinese] названия  национальностей, так же, как и производные от них  прилагательные, пишем с большой буквы. "),
            (@"[То find] означает найти, находить. В этом предложении мы, однако, переводим его описательно, а в предложении [7 you can find] - переводим, как можно/можешь купить, приобрести. "),
            (@"[Hot] - горячее/чий/чая - это также острое, пикантное, с большим количеством приправ. "),
            (@"Выражение [quite] - совсем, полностью, в целом, вполне, употребляется перед прилагательными с целью подчёркивания последнего: [quite cheap] - вполне дешевый. "),
            (@"[Fruit] так же, как [information], употребляется в единственном числе, хотя все чаще встречается fruits во множественном числе."),
            (@"Англичане очень любят пользоваться такими выражениями, как: [darling, love, baby, honey,] которые можно перевести, как дорогой/ая, любимый/ая, "),
            (@"Выражение [to be going to] означает намерение что-то сделать, то есть выражает будущие действия: [We're going to eat in] - поедим [намереваемся поесть] дома."),
            (@"[Licence] - разрешение, лицензия. [Driving licence] - это водительские права, а [off-licence] означает часть магазина или паба, где разрешено продавать алкогольные напитки. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Можешь взять или бифштекс, или рыбу.",@"You can take either the steak or the fish."),
            (@"В Лондоне много туристов. Большинство и них - немцы,",@"There are many tourists in London. Most of them are German."),
            (@"Он мне нравится, хотя он производит много шума.",@"I like him, though he makes a lot of noise. "),
            (@"Вчера была среда.",@"Yesterday was Wednesday."),
            (@"Пойду купить немного шоколада.",@"I’ll go and buy some chocolate."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Хотя сейчас поздно, я хочу выйти. ", "[Though ] it is late, I [want] to go out."),
            ( "В моем городе очень мало китайских ресторанов. ", "There [are ] very [few ]. Chinese restaurants in my [town]."),
            ( "Можно купить [найти] как еду, так и напитки. ", "[You ] саn find food [as well as] drinks. "),
            ( "Мой муж: пьет много пива, моэюет, слишком много.", "My [husband ] drinks а [lot of] beer, perhaps [too much]."),
            ( "Есть много ресторанов, но большинство из них китайские.", "There are [many ] restaurants and [most of them ] are [Chinese]."),
        };
    }
}
