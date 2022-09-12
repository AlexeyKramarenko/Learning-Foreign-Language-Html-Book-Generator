using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_69 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Извините, работает ли в этом офисе мой племянник Питер Бейтс?",@"Excuse me, doesn't my nephew Peter Bates work in this office?"),
            (@"Ох, вы его дядя? Он пошел на ваши похороны сегодня утром.",@"Oh, you're his uncle. He went* to your funeral this morning."),
            (@"Дэвид, что делают в подвале эти пустые бутылки из-под виски?",@"David, what are those empty whisky bottles doing in the cellar?"),
            (@"Не знаю, дорогая. Я никогда в своей жизни не покупал пустых бутылок из-под виски.",@"I don't know*, darling. I've never bought* an empty bottle of whisky in my life."),
            (@"Сколько человек работает в вашем офисе?",@"How many people work in your office?"),
            (@"Около половины из них.",@"About half of them."),
            (@"Госпожа Томас и госпожа Джонс встретились в торговом центре.",@"Mrs Thomas and Mrs Jones met* in the shopping centre."),
            (@"Госпожа Джонс толкала коляску со своими двумя мальчиками.",@"Mrs Jones was pushing a pram with her two little boys inside."),
            (@"Добрый день, госпожа Джонс. Какие красивые дети. Скажите мне, пожалуйста, сколько им лет?",@" - Good morning Mrs Jones. What beautiful children! Tell me, how old are they?"),
            (@"Хм, говорит госпожа Джонс, врачу два (года), а юристу три.", @"- Well, said Mrs Jones, the doctor is two and the lawyer is three. "),
            (@"Я забыл о Дне рождения моей жены. - Что она сказала.", @"I forgot my wife's birthday. - What did she say*?"),
            (@"Ничего. - Значит, все в порядке.",@"Nothing. - That's alright then."),
            (@"Да, ничего ... в течение трех недель.",@"Yes, nothing... for three weeks."),
            (@"Не забывайте учить неправильные глаголы, которые мы встречаем.",@"Don't forget* to learn the irregular verbs we meet*."),
        };

        public override string[] Notes => new[]
        {
            (@"[Nephew] - племянник, [niece] - племянница, [cousin] - двоюродный брат, двоюродная сестра."),
            (@"[Lawyer] - юрист, [barrister] - адвокат, защитник, [solicitor] - юрисконсульт."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Мой дядя и моя тетя встретились во время войны.",@"My uncle and aunt met  during the war."),
            (@"Что делает эта книжка посредине стола?",@"What is that book doing in the middle of the table?"),
            (@"Он никогда не тратит денег, но на прошлой неделе купил дом.",@"He never spends money, but last week he bought a house."),
            (@"Ты не говоришь по-немецки? А я думал, что говоришь.",@"Don't you speak German? I thought you did."),
            (@"Сколько вам лет, госпожа? <br> - Это вас не касается.",@"How old are you, madam? <br> - That doesn't concern you."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Она не хочет смотреть телевизор? Нет, не хочет. ", "[Doesn't ] she want [to watch ] the television? - No, [she doesn't]."),
            ( "Что делает собака с почтальоном? Это не имеет значения.", "[What is ] the dog [doing ] with the [postman]? It [doesn't matter. ]"),
            ( "Какая хорошая погода! Давайте возьмем машину и поедем в деревню.", "[What fine ] weather! [Let's take ] the car [and go to] the country."),
            ( "Он купил коляску, которую видел в четверг, но забыл о простынях.", "Не [bought ] the [pram ] he [saw on ] Thursday, but he [forgot ] the sheets."),
            ( "Его жена сердита. He знаю, что произойдет. ", "[His ] wife is [angry ]. I don't know [what ] will [happen]."),
        };
    }
}
