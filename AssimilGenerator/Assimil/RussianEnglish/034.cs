using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_34 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Увидимся с тобой завтра вечером в половине восьмого.",@"We'll see you tomorrow night at half-past seven."),
            (@"Мне нечего делать - и это меня утомляет [делает меня уставшим].",@"I've got nothing to do - and it makes me tired."), (@"Ее муж пьет слишком много - или это она так считает [это ее мнение].",@"Her husband drinks too much - or that is her opinion."),
            (@"Расходы [его] жены волнуют его.",@"His wife's spending worries him."),
            (@"Встретишься с его сыном на следующей неделе. Он придет проведать нас.",@"You'll meet his son next week. He's coming to visit us,"),
            (@"Проигрыватель его сына слишком громкий [шумный].",@"His son's record-player is much too noisy."),
            (@"Моя дочь всегда жалуется, что я слишком много работаю.",@"My daughter always complains that I work too much."),
            (@"Человек, на которого я работаю, очень скуп. Он платит мне недостаточно [не платит мне достаточно].",@"The man for whom I work is very mean. He doesn't pay me enough."),
            (@"Прошу меня простить, это не моя вина.",@"Please excuse me, it is not my fault."),
            (@"Я не хочу идти домой. Могу я пойти с тобой?",@"I don't want to go home. May I come with you?"),
            (@"Далеко ли [находится] до станции метро? -- Нет, около пяти минут пути прогулочным шагом [прогулки].",@"Is it far to the tube station? - No, about five minutes' walk."),
            (@"Каково максимальное наказание за двоежёнство [бигамию]?",@"What is the maximum penalty for bigamy?"),
            (@"Две тещи.",@"Two mothers-in-law."),
        };

        public override string[] Notes => new[]
        {
            (@"Глагол [to make] значит делать, выполнять. В этом предложении переводим его как: приводит меня к тому, что (я устаю), утомляет. "),
            (@"[He's coming] - переводится в этом предложении как он придет, т.е. как действие в будущем, несмотря на то, что глагол в предложении стоит в настоящем времени.  Эту временную конструкцию употребляем также для выражения действий в будущем, которые отражают намерения говорящего или его планы. "),
            (@"[For whom] - для которого, которой, [for which] - для > которого, которой (урок 33, упражнение 1). [Whom] относится к людям, [which]-к неодушевленным понятиям. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Когда он позвонит, скажу ему, что ты здесь.",@"When he phones, I'll tell him you are here."),
            (@"Мужчина, которому она дает деньги - ее брат.",@"The man to whom she gives the money is her brother."),
            (@"Я живу в Харроу, далеко ли это? - Нет, десять минут ходьбы.", @"I live in Harrow, is it far? - No, ten minutes* walk."),
            (@"Не беспокойся, я уверен(а), что он придет.",@"Don’t worry, I’m sure he’ll come,"),
            (@"Моя теща приезжает (приходит) в следующий вторник.",@"My mother-in-law is coming next Tuesday."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Это в двух часах езды на автомобиле. ", "It is а [two hours'] drive [by] car."),
            ( "Женщина, с которой она говорит, ее не слушает. ", "The woman to [whom] she [is ] talking is not [listening ] to [her]."),
            ( "Я слишком занята, чтобы с ним увидеться. ", "I [am much too busy] to see [him]."),
            ( "Человек, для которого она работает, является редактором.", "The person [for whom] she works [is the editor]."),
            ( "Прошу прощенья. Я ужасно устал(а). ", "[Please excuse] me. I'm [extremely tired]."),
        };
    }
}
