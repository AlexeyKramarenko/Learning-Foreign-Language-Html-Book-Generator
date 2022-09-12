using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_99 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Урок девяносто девятый напоминает мне о полиции.",@"The ninety-ninth lesson reminds  me of the police."),
            (@"Почему? - Потому, что если случается чрезвычайное происшествие, и нужна полиция,",@"Why?  - Because, if there is an emergency and you need the"),
            (@"или скорая помощь, или пожарная охрана,",@"or an ambulance or the fire-brigade,"),
            (@"просто набирается девять-девять-девять. Телефонистка отвечает немедленно.",@"you simply dial   nine-nine-nine.  The operator replies immediately:"),
            (@"Чрезвычайные происшествия.  Какую помощь вы xoтитe?",@"Emergency. Which service do you require?"),
            (@"Извините, я иностранец. Можете ли вы показать мне, как пользоваться телефоном?", @"Excuse me, I’m a foreigner. Could you show me how to use the phone?"),
            (@"Конечно, сэр. Номер у вас есть?",@"Of course, sir. Have you got your number?"),
            (@"Если нет, можем поискать в телефонной книге.",@"If not, we can look it up   in the directory."),
            (@"Хорошо. Теперь, сперва вы поднимаете трубку и ждете гудка.",@"Right. Now first, you lift the receiver and wait for the tone."),
            (@"Далее, набираете номер и ждете сигналов звонка.",@"Next, you dial your number and wait until it rings."),
            (@"Вы должны иметь наготове десять пенсов.",@"You must have ten pence ready."),
            (@"Когда абонент ответит, вы бросаете свою монету в отверстие и говорите.",@"When the person answers, you push your coin into the slot and talk."),
            (@"Вот видите? Это совсем несложно.",@"You see?  It's not at all complicated."),
            (@"Да, вижу. Спасибо, вы очень любезны.",@"Yes, I see. Thank you, you're very kind."),
            (@"Не за что. До свидания.",@"Not at all. Good-bye."),
        };

        public override string[] Notes => new[] 
        {
            (@"[Emergency] - чрезвычайное происшествие, внезапное решение; [а state of emergency] - чрезвычайное положение; [to be ready for every emergency] - быть готовым ко всему (на все). "),
            (@"[То remind] - напоминать что-нибудь, кого-нибудь, кому- нибудь. [This reminds me of him].-Это мне напоминает о  нем. [Please remind me to post the letter.] - Напомни мне, пожалуйста, [что нужно] отправить письмо.  [То remember] - за/помнить, вспоминать; [I remember   when I was young.] - Я помню, когда я был молод. "),
            (@"[То dial] - набирать, [to dial а number] - набрать номер, [а dial] - циферблат."),
            (@"[А foreigner] - иностранец; [а stranger] - чужой; [а foreign car] - иностранный автомобияь: [а strange car] - странный автомобиль."),
            (@"[То look up] - искать, поискать, проверить в чем-нибудь; [to look for] - искать; [to look at] - смотреть. "),
            (@"[To push] - толкать, подталкивать; [to push into] - вбрасывать, вкладывать. "),
        }; 

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Эта фотография напоминает мне мой родной город.",@"This photograph reminds me of my home town."),
            (@"Набери свой номер и жди гудка.",@"Dial your number and wait for the tone."),
            (@"Вложи свою монету в отверстие и говори.",@"Push your coin into the slot and speak."),
            (@"Простите меня, я иностранец.",@"Please excuse me, I'm a foreigner."),
            (@"Не можете ли вы показать мне, как этим пользоваться?",@"Could you show me how to use it?"), 
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Ты помнишь [можешь помнить], куда ты положил мой кошелек?", "[Can ] you [remember where ] you [put] my wallet? "),
            ( "Кажется, я напоминаю ему его внука. ", "It [seems ] that I [remind him of] his grand-son."),
            ( "Мне нужна была отвертка, но я должен был воспользоваться ножом.", "I [needed ] а screwdriver but I [had to use ] а [knife]."),
            ( "Он пользуется/пользовался той же самой ручкой в течении почти десяти лет.", "Не [has been using ] the [same ] pen [for] almost ten years."),
            ( "У тебя есть адрес? Если нет, моэюем у кого-нибудь спросить.", "[Have you got/do you have ] the address? [If not] we can [someone/somebody]."),
        };
    }
}
