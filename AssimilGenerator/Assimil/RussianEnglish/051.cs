using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_51 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Он был вчера дома? <br> - Думаю, что да, но я не звонил.",@"Was he at home yesterday ? <br> -I think so, but I didn't phone."),
            (@"Он зашел вчера, но меня не видел. - Он звонил? - Не думаю.",@"He called   yesterday, but he didn't see me. - Did he phone? -I don't think so."),
            (@"Это вопросительные и отрицательные формы в прошедшем времени.",@"These are the interrogative and negative forms in the past."),
            (@"Вы не меняете основной глагол, а меняете только вспомогательный глагол ""do"" на форму прошедшего времени [прошедшую форму] „did'\",@"You do not change the verb, you simply put the auxiliary ""do"" into the past ""did"":"),
            (@"Мне не понравилась эта еда. Он не позвонил. Мы его не полюбили (Он нам не понравился).",@"I did not (didn't) like the food. He did not (didn't) phone. We did not (didn't) like him,"),
            (@"Вопросы тоже легкие: Он полюбил это? (Ему это понравилось) Она позвонила?",@"Questions are easy, too: Did he like it? Did she phone?"),
            (@"Тебе понравилась пьеса вчера вечером? - Я ее не видела.",@"Did you like the play last night? -I didn't see it."),
            (@"Но ты пошла в театр? - Да, но я была такая усталая, что закрыла глаза.",@"But did you go to the theatre?  - Yes, but I was so tired I closed my eyes."),
            (@"Скажи мне, была ли пьеса интересна? - Очень многого я не поняла, она исполнялась по-гречески.",@"Tell me, was the play interesting? -I didn't understand very much, it was in Greek."),
            (@"Тогда почему ты пошла? - Мне нравился актер, играющий главную роль.",@"Then why did you go? - I liked  the main actor."),
            (@"Он хорошо играл? - Я не смотрела на игру. Я смотрела на него.",@"Did he act well? -I didn't watch the acting. I looked at him."),
            (@"Что ты делала после [просмотра] пьесы? - Мечтала об актере.",@"What did you do after the play?  -I dreamed about the actor!"),
            (@"Он не, он не (сокращенная форма).  Ему не понравилась пьеса.",@"He did not, he didn't; he didn't like the play,"),
            (@"Они...? Они звонили тебе?",@"Did they... ?; did they phone you?"),
        };

        public override string[] Notes => new[]
        {
            (@"Это время называется the Past Simple Tense и употребляется для выражения действия в прошлом,   которое известно когда происходило, например  [yesterday] - вчера. "),
            (@"[То call] - это не только звонить, но также зайти, прийти к кому-нибудь. "),
            (@"[To play] - играть, [a play] - театральная пьеса, [a game] - игра. "),
            (@"Глагол [to like] означает любить, нравиться [было вкусно]. [I like you] переводится как ты мне нравишься. "),
            (@"[The main actor] - буквально главный актер. Здесь: актер, играющий главную роль. [Main] - главный, [а main road] - главная дорога. "),
            (@"[То act] - играть, разыгрывать что-нибудь, [an act] - акт. "),
            (@"Глагол [to dream] - мечтать, сниться, имеет две формы  прошедшего времени, правильную [dreamed] [dri:md] и [dreamt] [dremt]. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я не закончил это, потому что мне помешали.",@"I didn't finish it because I was disturbed."),
            (@"Кто тебе помешал?",@"Who disturbed you?"),
            (@"Моя сестра и ее друзья пригласили меня выйти с ними.",@"My sister and her friends invited me to go out with them."),
            (@"Куда вы пошли?",@"Where did you go?"),
            (@"В кино, но фильм мне не понравился.",@"To the cinema, but I didn't like the film."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Почему ты это сказал? Ты зол? ", "Why [did ] you [say ] that? [Are] you angry?"),
            ( "Кого ты видел прошлым вечером? Я не выходил. ", "Who [did ] you [see ] last [night ]? I [didn't] go out."),
            ( "Куда ты полоэюил мою газету? Около дивана. ", "Where [did ] you [put ] my paper? [Near] the sofa."),
            ( "Что ты делал после пьесы? ", "[What ] did you [do ] after the [play]? "),
            ( "Я их спрашивал, но они не хотели разговаривать с нами.", "I [asked them ], but they [did ] not [want to] talk to us. "),
        };
    }
}
