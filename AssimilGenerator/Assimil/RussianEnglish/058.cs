using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_58 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"В английском языке есть много оборотов, которые включают в свой состав названия частей тела.",@"There are many words in English which include parts of the body."),
            (@"Например: Когда у меня грипп, я должен иметь [держать] запас бумажных салфеток для носа.",@"For instance: When I have the 'flu, I keep* a supply of paper handkerchiefs."),
            (@"Выглядишь (как будто бы был) очень занятым (работой). Могу я тебе чем-то помочь?",@"You look very busy. Can I give* you a hand?"),
            (@"Мистер Марсден является председателем правления / совета директоров.",@"Mr. Marsden is head of the board of directors."),
            (@"Он слишком любопытный / пронырливый. Интересуется всем, что его не касается.",@"He is too nosy. He is interested in anything that doesn't concern him."),
            (@"Учитель: - Брюки (- это слово) в единственном или множественном числе?",@"Teacher. - Is ""trousers""  singular or plural?"),
            (@"Ученик: - [Пожалуйста,] единственное наверху и множественное внизу.",@"Pupil - Please sir, singular at the top and plural at the bottom."),
            (@"Это был дерзкий ответ.",@"That was a cheeky  answer."),
            (@"Два бегуна были очень близко (друг к другу), почти голова в голову [шея в шею].",@"The two runners were very close, they were almost neck and neck."),
            (@"Когда ездишь автомобилем, всегда имей [держи] (при себе) готовое запасное колесо.",@"When you are driving*, always keep* the spare wheel handy"),
            (@"И конечно, когда пьешь свое пиво, говоришь ""за здоровье"".", @"And, of course, when you are drinking* your beer, you can say* ""Chin chin!"""),
            (@"Другие части тела - это руки, локти, пальцы.",@"Other parts of the body are the arms, the elbows and the fingers."),
            (@"Ниже [имеем] ноги, колени, ступни и пальцы ног.",@"Lower, we have the legs, the knees, the feet and the toes."),
        };

        public override string[] Notes => new[]
        {
            (@"[To supply] - доставить, обеспечить, [a supply] - запас. "),
            (@"[Kerchief] - это платок (на голову), [handkerchief] - носовой платочек."),
            (@"[То give someone а hand] - помочь кому-либо. "),
            (@"[А board of directors] - правление, совет директоров; [to be at the head] - быть руководителем, председателем; [headmaster] - директор школы."),
            (@"Слово [trousers] - брюки - всегда используется во множественном числе, в единственном - оборот [а pair of trousers] - пара брюк. "),
            (@"[А cheek] - щека, [cheeky] - нахальный, наглый, дерзкий. "),
            (@"[Neck and neck] - голова в голову; [neck] значит шея. "),
            (@"[Handy] - (имеющийся) под рукой. "),
            (@"[Chin] - борода. "),
            (@"[Knees, knife, know] - сочетание согласных kn произносится как [n]."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Ты выглядишь очень уставшим, иди спать.",@"You look very tired. Go to bed."),
            (@"Его брюки дырявые [полны дыр].",@"His trousers are full of holes."),
            (@"Пусть лучше купит себе новую пару.",@"He had better buy a new pair."),
            (@"Президент или королева являются главами государства.",@"The President, or the Queen, is Head of State."),
            (@"У тебя есть что-нибудь интересное почитать?",@"Have you anything interesting to read?"),
            (@"Она мыла пол на коленях.",@"She was on her knees washing the floor."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Этот текст очень труден. Можешь мне помочь? ", "This text [is very difficult ]. Can you [give me a hand] ?"),
            ( "(Ищу) [я нуждаюсъ в новой паре] новую пару брюк. У вас есть что-нибудь?", "I [need ] а new [pair of trousers ]. Have you got [any] ?"),
            ( "Наверху страницы напиши дату, а снизу свою фамилию.", "[At the top ] of the page [write the date ] and [at the bottom ], your [  name   ]."),
            ( "Это тебя не касается. Иди (прочь). ", "That [doesn't concern you ]. Go [away ]."),
            ( "Этот мальчик/парень слишком наглый, лучше ему держаться тихо.", "[This ] boy is [too cheeky ], he [had ] better [keep quiet]."),
        };
    }
}
