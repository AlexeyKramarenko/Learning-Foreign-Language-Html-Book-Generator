using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_8 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Чем могу служить [могу я вам (чем-то) помочь]?",@"Can I help you  ?"),
            (@"У вас есть какой-нибудь чай?",@"Have you got any tea ?"),
            (@"Конечно, Вам подать? [Вы хотите немного?]",@"Of course. Do you want some ?"),
            (@"Да, пожалуйста. Дайте мне два фунта и пачку печенья.",@"Yes please. Give me two pounds . And a packet of biscuits."),
            (@"Вы хотите фасоль?",@"Do you want some beans?"),
            (@"Нет, спасибо. У нас есть [мы имеем] немного дома.",@"No thanks. We've got some at home ."),
            (@"Хорошо. Может быть, хлеб?",@"Well, some bread?"),
            (@"Пожалуйста. Две буханки. Да, и (еще) полфунта масла. Это все.",@"Yes please. Two loaves. Oh, and half a pound of butter. That's all."),
            (@"Сколько с меня [сколько (стоит) это]?",@"How much is that ?"),
            (@"Шесть фунтов.",@"That's six pounds."),
            (@"Ой, у меня только пять фунтов.",@"Oh dear, I've only got five pounds."),
            (@"Заплатите [Вы можете заплатить] остальное в следующий раз.",@"You can pay the rest next time."),
            (@"Большое спасибо. До свиданья.",@"Thanks very much. Good-bye."),
            (@"До свиданья, госпожа.",@"Good-bye madam."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Чем могу служить [могу я вам (чем-то) помочь]?",@"Саn I help you?"),
            (@"У вас есть [какое-то] масло?",@"Have you got any butter?"),
            (@"Вам подать хлеб [вы хотите немного хлеба]?",@"Do you want some bread?"),
            (@"Он может заплатить в следующий раз.",@"He can pay next time."),
            (@"Дай мне немного денег.",@"Give me some money."),
            (@"У нее только два фунта.",@"She's only got two pounds."),
        };

    }
}
