using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_122 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Дэвид ждал недалеко от зала прибытия самолётов в первом терминале в Хитроу.",@"David was waiting near the arrival lounge at Heathrow's  Terminal One."),
            (@"Он ждал клиента, который прилетал из Женевы.",@"He was waiting for a client who was coming* from Geneva."),
            (@"Громкоговоритель затрещал и послышался голос, произнесший: ""Британские авиалинии объявляют прибытие рейса 107 из Женевы"".", @"The loudspeaker crackled and he heard* a voice say: ""British Airways announce the arrival of Flight One Oh Seven (107) from Geneva."""),
            (@"Дэвид начал искать своего клиента. Он знал, что у мужчины будет гвоздика в петлице,",@"David started looking for his client. He knew* that the man would be wearing* a carnation in his button-hole,"),
            (@"и под мышкой он будет нести экземпляр ""Сандэй Тайме"".",@"and caiTying a copy of the ""Sunday Times"" under his arm."),
            (@"Он увидел мужчину, который был высокий, седой и с длинными бакенбардами.",@"He caught* sight of the man, who was tall and grey-haired with long side-boards."),
            (@"Он подошел и спросил: ""Вы, должно быть, мистер Легард. Я Дэвид Вилсон. Здравствуйте"".",@"He went forward  and said: ""You must be Mr Legarde? I'm David Wilson. How do you do?"""),
            (@"Они пожали друг другу руки. Дэвид взял чемодан мужчины и сказал:",@"They shook* hands. David picked up the man's case and said:"),
            (@"""Прошу идти за мной, хорошо? Мой автомобиль на стоянке, здесь снаружи"".",@"""Follow me, will you? My car is in the car park, it's just outside."""),
            (@"Когда они ехали в сторону Лондона, Дэвид сказал: ""Сначала я завезу вас в вашу гостиницу, а потом купим какой- нибудь ланч"".",@"When they were driving* towards London, David said: ""I'll take* you to your hotel first, then we'll get some lunch."""),
            (@"Мистер Легард ответил: ""Спасибо. Я остановился в (гостинице) ""Черчиль"".  Моя секретарша забронировала комнату телефаксом"".",@"Mr Legarde replied: ""Thank you. I'm staying at the Churchill. My secretary booked the room by telex."""),
            (@"B гостинице швейцар взял чемодан мистера Легарда, а другой служащий припарковал машину.",@"At the hotel, the doorman took* Mr Legarde's case and another servant parked the car."),
            (@"Оба мужчины подошли к регистратуре: ""Меня зовут Легард, мне забронирована одноместная комната"".", @"The two men went to the reception desk: ""My name's Legarde, I have a single room reserved."""),
            (@"""Да, сэр, комната двести тридцать семь. Швейцар из холла вас проводит"".",@"""Yes sir, room two three seven (237). The hall porter will show you up."""),
        };

        public override string[] Notes => new[]
        {
            (@"[Heathrow] - местность недалеко от Лондона, в которой располоэюен аэропорт. "),
            (@"[То catch sight of] - увидеть. [Sight] - вид; [to catch, caught, caught] - ловить, хватать, поймать."),
            (@"[Hair] - волос, волосы - это существительное не имеет множественного числа. [His hair is long] - Его волосы длинные. [Long haired] - длинноволосый; [grey-haired] - седой; [hair-cut] - стрижка; [to have a hair-cut] - подстричься."), (@"[To go forward] - идти вперед, подходить. "),
            (@"[Single room] - одноместная комната; [double room] - двухместная комната. "),
            (@"[То show up] - показать, указать, проводить. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я знала, что он будет носить серую шляпу.",@"I knew he would be wearing a grey hat."),
            (@"Прошу идти за мной, хорошо? Я провожу вас в вашу гостиницу.",@"Follow me, will you, I'll take you to your hotel."),
            (@"Ты должен был забронировать комнату раньше.",@"You should have booked the room earlier."),
            (@"Он заметил своего друга в толпе.",@"He caught sight of his friend in the crowd."),
            (@"Она не могла слышать голос из громкоговорителя.",@"She couldn't hear the voice of the  loudspeaker."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "He зная его фамилии, я угадала его по [его] одежде. ", "[Without knowing ] his name, I recognised him [because of] his clothes."),
            ( "Возьми мой чемодан, прошу (тебя) и проводи меня в мою комнату.", "Take my case, [will you], and [show me up] to my room."),
            ( "Я помог бы тебе если б мог, но я спешу. ", "I [would help ] you if I [could ] but I am in а [hurry]."),
            ( "Вы, должно быть, мистер Легард? (А) я Дэвид Вилсон. Здравствуйте.", "You [must be ] Mr Legarde? [I'm ] David Wilson, how [do you do]?"),
            ( "Сотни и тысячи людей вылетают и преземляются в Хитроу.", "[Hundreds ] and [thousands ] of [people] take off and land at Heathrow."),
        };
    }
}
