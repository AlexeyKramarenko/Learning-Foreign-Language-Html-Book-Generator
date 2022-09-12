using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_73 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Полиция допрашивал солдата, который подозревался в ограблении.",@"The police were interviewing a soldier suspected of robbery"),
            (@"Я не знаю этого ресторана. Никогда в [своей] жизни я там не был, сказал подозреваемый.",@"I don't know* the restaurant. I've never been there in my life, said* the suspect."),
            (@"Но люди говорят, что солдат, похожий на тебя, ограбил ресторан и ранил хозяина, ответил детектив.",@"- Well, people say* that a soldier like you robbed the restaurant and wounded  the owner, replied the detective."),
            (@"Но в этом городе есть, наверное, тысячи солдат.",@"- But there must be thousands of soldiers   in this town."),
            (@"Да, но только один, который находился рядом с местом преступления.",@"- Yes, but only one who was near the scene of the crime."),
            (@"Послушайте. Я шел себе спокойно по улице,",@"- Listen. I was walking quietly down the street  ,"),
            (@"когда кто-то пробежал по улице, крича: ""Он ограбил кассу!!!""",@"when someone ran* down the street shouting: ""He robbed the till!!!"""),
            (@"поэтому я остановился и вернулся в ресторан,",@"So, I stopped and went* back to the restaurant"),
            (@"а свидетели сказали, что я и есть тот грабитель, судя по моей форме.",@"and the witnesses said* I was the robber because of my uniform."),
            (@"Итак, полиция задержала меня и вот - я перед вами.",@"So the police arrested me and here I am."),
            (@"Ты говоришь, что раньше ты никогда не видел этого ресторана.",@"- You say* you never saw* the restaurant before?"),
            (@"Да, так оно и есть, сказал солдат, нервничая.",@"- Yes, that's right, said* the soldier nervously."),
            (@"Я арестую тебя за вооружённое ограбление, сказал детектив.",@"- Then I arrest you for armed robbery, said* the detective. "),
            (@"Какова ошибка солдата? (Ответ дается в повторительном уроке.)",@"What was the soldier's mistake? (The answer is in the revision lesson.)"),
        };

        public override string[] Notes => new[]
        {
            (@"[The police were] - несмотря на то, что это существительное в единственном числе, после него стоит глагол во множественном числе, так как [police] это  собирательное существительное, то есть означает группу полицейских как одно целое - полицию. "),
            (@"[То rob] - грабить, [robbery] - ограбление, [robber] - вор, грабитель, [to steal, stole, stolen] - красть, [theft] - кража, [thief, thieves] вор, воры. "),
            (@"[То wound] - ранить оружием, [to injure, to hurt] - ранить. "),
            (@"[Two thousand], но [thousands of soldiers]. В выражениях, называющих сотни, тысячи, миллионы слова [а hundred, thousand, million] употребляются во множественном числе - смотри урок 39; [hundreds of thousands] - сотни тысяч. "),
            (@"[То walk down the street] - гулять [прогуливаться] по . улице. Слово [down] не переводится на русский язык."),
            (@"[Because] - потому что, так как; [because of] - no поводу. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я никогда не был в Англии. - Какая она [есть]?",@"I have never been to England. What's it like?"),
            (@"Это, наверное, ошибка, Я тебя не знаю.",@"There must be a mistake, I don't know you."),
            (@"Она бежала по улице и  кричала: ""На помощь"".",@"She ran down the street shouting ""Help!""."),
            (@"Мой самолет опоздал из-за забастовки.",@"Му plane was late because of a strike."),
            (@"Я работал(а), когда позвонил телефон.",@"I was working when the telephone rang."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oh хозяин трех домов отдыха и квартиры. ", "Не is [the owner of] three [country] - [houses] and а flat."),
            ( "Не задавая вопросов, он знал, что солдат совершил ограбление.", "[Without asking ] any questions, he [knew ] the soldier [had done] the robbery."),
            ( "Сотни и тысячи людей купили машины. ", "[Hundreds ] and [thousands ] of [people bought] cars."),
            ( "Она никогда в [своей] жизни не была за границей. ", "She [has ] never [been abroad ] in [her life]."),
            ( "Из-за дождя мы опоздаем на двадцать минут. ", "[Because of] the [rain ] we will [be ] twenty minutes [late]."),
        };
    }
}
