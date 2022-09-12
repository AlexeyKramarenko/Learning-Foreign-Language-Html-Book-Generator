using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_111 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Молодой автор: - Почему Вы поставили мой роман вместе с медицинскими книгами?",@"Young author. - Why have you put* my novel wiith the medical books?"),
            (@"Издатель: - Потому что считаю, что это превосходное снотворное [он превосходен для усыпления людей].",@"Publisher. - Because I found* it excellent for sending* people to sleep"),
            (@"Учитель: - Что неправильно в этом предложении [с этим предложением]: «Конь и корова [находится] в поле»?",@"Teacher, - What is wrong with this sentence : ""The horse and the cow is in the field""?"),
            (@"Маленькая девочка: - Извольте, мисс, дам (надо пропускать) вперед.",@"Little girl.  - Please miss, ladies first"),
            (@"Профессор: - Как Вы защищаете себя от загрязненной воды?", @"Professor. - How do you protect yourself against impure water?"),
            (@"Студент: - Пью пиво.",@"Student, - I drink* beer."),
            (@"Джонни: - Дедушка, ребенок был вскормлен слоновьим молоком и прибавлял в весе по двадцать фунтов в неделю.", @"Johnny. - Grandad, a baby was fed* on elephant's milk and gained twenty pounds in a week. "),
            (@"Дедушка: - Это невозможно. Чей ребенок?", @"Grandfather.  - That's impossible. Whose baby?"),
            (@"Джонни: - Слона.",@"Johnny. - The elephant's."),
            (@"Тетка захотела посмотреть, какая из ее племянниц самая вежливая",@"An aunt wanted to see* which of her nieces was the most polite,"),
            (@"и положила на тарелку одно маленькое и одно большое яблоко.",@"so she put* one small apple and one big one on a plate."),
            (@"Посмотрим, кто обладает наилучшими манерами.",@"Let's see* who has the best manners."),
            (@"Она, сказала Джоэн, взяв самое большое.",@"She has, said Joan, taking* the biggest."),
            (@"Не забывайте время от времени учить по несколько неправильных глаголов.",@"Do not forget* to learn a few irregular verbs from time to time."),
        };

        public override string[] Notes => new[]
        {
            (@"[То send someone to sleep] - усыплять. [To send, sent, sent] - высылать, посылать. "),
            (@"[Ladies first] - дамы вперед, предпочтение отдается дамам. "),
            (@"[То feed, fed, fed] - кормить. [Please feed the cat] - накорми, пожалуйста, кота. [To feed on] - кормить чем-нибудь, жить на чей-то счет. [То be fed up] - быть сытым по . горло, пресыщенным кем/чем-нибудь, не иметь желания к чему I кому-нибудь. [I am fed up] - С меня хватит."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Чья это расческа? - Моей сестры.",@"Whose hairbrush is this? - My sister's."),
            (@"Кто обладает наилучшими манерами? - Я [обладаю].",@"Who has the best manners? - I have."),
            (@"Кто хочет поехать со мной в Шотландию? - Мы хотим.",@"Who wants to go to Scotland with me? - We do."),
            (@"Эта мука превосходна для выпечки пирожных.",@"This flour is excellent for making cakes."),
            (@"Он послал своего сына в магазин купить вина.",@"He sent his son to the shop to buy some wine."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Мой радиоприемник не работает. Что с ним случилось?", "My radio [doesn't work ]. What's [wrong with] it?"),
            ( "Он самый вежливый мальчик, какого я когда-либо встречал.", "[He ] is the [most polite ] boy I have [even] met. "),
            ( "Я никогда не интересовался историей Рима. ", "I have [never] been interested [in Roman] history."),
            ( "Хоть я ему и сказала, чтобы он этого не делал, он настаивал.", "[Although] I [told] him [not to] do it, he insisted."),
            ( "Шариковая ручка превосходна для быстрого писания. ", "А biro is excellent [for writing quickly]."),
        };
    }
}
