using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_89 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Уэльс, в отличие от Шотландии, политически объединен с Англией.",@"Wales, unlike Scotland, is politically united to England."),
            (@"Весь Уэльс расположен в горной местности, и его пейзажи захватывают дыхание.",@"The whole of Wales is mountainous and there is much breathtaking scenery."),
            (@"Главной отраслью промышленности является добыча угля и большинство жителей Уэльса проживает вокруг промышленных городов.",@"The main industry is coalmining and the majority of the Welsh live around the industrial towns."), (@"Они [эти города] находятся на юге.",@"These are in the South."),
            (@"Уэльский язык - кельтский язык - сохранился в большей степени, чем в Шотландии, но на нём трудно говорить.",@"The Welsh language - a Celtic language - survives more than in Scotland, but it is difficult to speak."),
            (@"Жители Уэльса питают глубокую любовь к поэзии и музыке, а международный фестиваль известен во всем мире.",@"The Welsh have a deep love of poetry and music, and the international festival is famous throughout  the world."),
            (@"Уэльс сыграл большую роль [в становлении] языка и политики Англии.",@"Wales has contributed   much to the language and politics  of England."),
            (@"Сын и наследник престола носит титул «Принц Уэльский», но это не имеет политического значения.",@"The son and heir  of the monarch is given* the title: ""The Prince of Wales"", but this has no political significance."), (@"Сейчас ответьте на эти вопросы:",@"Now answer these questions:"),
            (@"Существует ли еще уэльский язык?",@"Does the Welsh language still exist?"),
            (@"Что является главной отраслью промышленности в Уэльсе?",@"What is the main industry in Wales?"),
            (@"Каков ландшафт?",@"What is the scenery like?"),
            (@"Кто является Принцем Уэльским?",@"Who is the Prince of Wales?"),
        };

        public override string[] Notes => new[]
        {
            (@"[Breath] - дыхание, [breath-taking] - захватывающий дыхание. "),
            (@"[Throughout] - через, через весь, насквозь, всюду, с начала до конца, на/во всем. "),
            (@"[То contribute] - сыграть большую роль в чем-то, послужить причиной чему-нибудь, делать вклад, иметь' заслуги перед чем-нибудь. "),
            (@"[Politics] - политика; [economics] - экономика в единственном числе не употребляются. "),
            (@"[Heir] - наследник, преемник. [Н] не произносится, так же как в словах: hour, honour. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Bo всей Англии имеется много великолепных пабов.",@"Throughout England, there are many excellent pubs."),
            (@"Принц Уэльский является наследником престола.",@"The Prince of Wales is heir to the throne."),
            (@"Это твоя расческа? - Нет, это ее (расческа).",@"Is that your comb? - No, it's. hers."),
            (@"Ты был в Китае? Каков он?",@"You have been to China? What's it like?"),
            (@"Не можешь ли ты попробовать помочь мне?	",@"Couldn't you try and help me?"),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "He могла ли она сделать это лучше, чем сделала? ", "[Couldn't ] she [do better ] than [that]? "),
            ( "У него такое хорошее настроение, что он пригласил всех.", "Не is in [such ] а good [mood ] that he [has invited everybody (everyone)]."),
            ( "Мне не понравился первый фильм. И мне тоже. ", "[I didn't like ] the first film. - No, [neither did I]."),
            ( "Ты выглядишь очень усталой. Входи и садись. ", "You [look very tired ]. Come [in ] and [sit down]."),
            ( "Вся семья уехала в деревню. Никого нет. ", "[The whole ] family has [gone to the country ]. There is [no one (nobody)]."),
        };
    }
}
