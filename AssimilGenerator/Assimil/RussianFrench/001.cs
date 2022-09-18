using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianFrench
{
    public class Lesson_1 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Простите, мадам. Где метро Сен-Мишель?", @"Pardon, madame. Où est le métro Saint-Michel ?"),
            (@"Метро Сен-Мишель? Подождите минутку...",@"Le métro Saint-Michel ? Attendez une minute..."),
            (@"Мы на бульваре Сен-Мишель. Фонтан там.",@"Nous sommes au boulevard Saint-Michel. La fontaine est là-bas."),
            (@"Да, хорошо. Но где метро, (скажите) пожалуйста?",@"Oui, d’accord. Mais où est le métro, s’il vous plaît?"),
            (@"Ну конечно! Вот Сена, а вот мост.",@"Mais bien sûr ! Voilà la Seine, et voici le pont."),
            (@"Прекрасно; но (скажите) пожалуйста...",@"C’est joli ; mais s’il vous plaît..."),
            (@"Это не слева, значит это справа.",@"Ce n’est paswà gauche, alors c’estwà droite."),
            (@"Вот. Метро справа.",@"Voilà. Le métro estwà droite !"),
            (@"А вы уверены?",@"Mais vous^êtes sûre ?"),
            (@"Нет. Я тоже туристка.",@"Non. Je suis touriste aussi !"),            
        };

        public override string[] Notes => new[]
        {
            (@"Où est le métro ? - дословно “Где есть метро?” В
                русском языке глагол-связка “быть” в настоящем
                времени опускается, а во французском он
                обязателен. Обратите на это внимание в
                последующих фразах и постарайтесь сразу
                запомнить это важное правило."),
            (@"Спрашивая дорогу, добавьте s’il vous plaît к
                объекту ваших поисков, и вопрос готов: Où est le
                boulevard Saint-Michel, s’il vous plaît ? или даже:
                Le boulevard Saint-Michel, s’il vous plaît ? - Где
                бульвар Сен-Мишель, скажите пожалуйста? s’il
                vous plaît —» si il vous plaît (дословно: если вам
                нравится). Для более удобного произношения
                гласный “i” сокращается, т. е. выпадает перед
                таким же гласным."),
            (@"Mais - “но”, иногда “а” - при противопоставлении;
                “ну” - при подтверждении очевидного."),
            (@"Когда указывают на кого или что-либо: voici - “вот”,
                voilà - “вон”. В строке 8 voilà выполняет
                идиоматическую функцию в значении “ага, нашёл”."),
            (@"c’est (это (есть)) ^ ce n ’est pas (это не (есть)). Не
                забывайте о глаголе-связке и в отрицательном
                предложении. Отрицательная форма образуется
                путём введения отрицательных частиц: ne - перед
                глаголом, pas - после. С гласными та же история:
                c’est = ce est; n ’est = ne est."), 
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я в Париже; мы в Париже.",@"Je suis à Paris ; nous sommes à Paris."),
            (@"Вы уверены?",@"Vous êtes sûr ?"),
            (@"Подождите минуту, пожалуйста.",@"Attendez une minute, s’il vous plaît."),
            (@"Вон фонтан, а вот метро.",@"Voilà la fontaine et voici le métro."),
            (@"Ну конечно!",@"Mais bien sûr !"), 
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            (@"Вы в Париже.", @"Vous [êtes] à Paris."),
            (@"Мы на бульваре Сен-Мишель.", @"Nous [sommes] au boulevard Saint-Michel."),
            (@"Да, хорошо, но где метро, скажите пожалуйста?", @"Oui, [d]’[accord], mais où est le métro, s’il vous [plaît]?"),
            (@"Фонтан слева.", @"La fontaine [est] à gauche."),
            (@"Это не справа.", @"Ce [n]’est [pas] [à] droite."),
        };
      
    }
}
