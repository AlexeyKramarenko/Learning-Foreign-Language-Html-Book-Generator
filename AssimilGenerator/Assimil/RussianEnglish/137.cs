using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_137 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"После часа ходьбы и часа культуры я проголодался.", @"After an hour's walking and an hour's culture, I felt* hungry."),
            (@"Я напрасно искал английский ресторан, но поблизости не было ни одного.",@"I looked in vain for an English restaurant but there wasn't one in sight."),
            (@"Я мог съесть пиццу, блины, гамбургер, но не английскую еду.",@"I could have eaten* pizza, crepes, hamburgers, but no English food."),
            (@"Поэтому я пошел в паб, выпил пинту пива и съел сендвич.",@"So I went into a pub and had a pint of beer and a sandwich."),
            (@"Потом я продолжал свои открытия. Одна вещь меня потрясла.",@"Then I continued my explorations. One thing struck* me:"),
            (@"Bсe театры и кино были дешевле, чем дома.",@"The theatres and cinemas were all cheaper than at home."),
            (@"Хорошее место в театре стоило около десяти фунтов.",@"A good seat in a theatre was about ten pounds."),
            (@"Я решил пойти и посмотреть пьесу перед отъездом.",@"I made* up my mind to go and see a play before leaving*."),
            (@"Мой первый день был утомительным. Я видел так много, что всего не помню.",@"My first day was exhausting  . I saw* so much that I can't remember everything."),
            (@"Я обратил внимание, что жители Лондона, которых я видел, казались более спокойными, даже в пять часов в час пик.",@"I noticed how the Londoners I saw seemed calmer, even at five o'clock during the rush hour."),
            (@"Другой вещью, которая меня поразила, было количество парков.",@"Another thing that impressed me was the number of parks:"),
            (@"Сент Джеймс, Гайд парк, Грин парк – и  было можно ходить по траве.",@"St James, Hyde Park, Green Park - and you were allowed to walk on the grass."),
            (@"Я пошел к Спикере Конеру и слушал, как кто-то произносил речь об иммиграции.",@"I went to Speaker's Corner and listened to somebody talking about immigration."),
            (@"Он сказал, что в стране полно иностранцев, поэтому я тихо ушел.",@"He said the country was full of foreigners, so I went away quietly."),
        };

        public override string[] Notes => new[]
        {
            (@"[То be in sight] - быть близко, около чего-нибудь, близким, недалеким, в поле зрения. [Sight] - зрение. "),
            (@"[Exhausting] - мучительный, утомительный, изматывающий; [exhausted] - истощенный, утомленный, измученный, выбившийся из сил. [То exhaust] - вытаскивать, выкачивать, высасывать. [An exhaust pipe] - выхлопная труба."),
            (@"[Grass] - трава; [lawn] - газон. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Я чувствую себя немного больным. Будьте добры, можно мне сесть?",@"I feel a bit ill. May I sit down please?"),
            (@"Я выбился из сил, ходил весь день.",@"I’m exhausted, I have been walking all day."),
            (@"Что меня поразило, так это количество парков.",@"What struck me was the number of parks."),
            (@"Можешь выбрать либо пиццу, либо гамбургер, но не и то, и другое.",@"You can choose either pizza or hamburger, but not both."),
            (@"Онa любит жить за границей; встречает много разных людей.",@"She likes living abroad: she meets many different people."),
        };

        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Oн ходил целый час под дождем и очень устал. ", "Не [has been ] walking [for ] an hour [in ] the rain and he [feels] tired."),
            ( "Они искали наобум будки с телефоном; не было ни одной.", "[They ] looked [in vain ] for а telephone box: there [wasn't] one."),
            ( "Oн вздохнул, когда ему сказали, что не смогли забронировать для него места.", "Не [sighed ] when [they ] told him he [couldn't book ] his [seats]."),
            ( "Жители Лондона являются преимущественно спокойными, но лсители Лондона, которых я видел, были шумными.", "[Londoners ] are [generally ] calm, but  [the] Londoners I [saw ] were [noisy]."),
            ( "Метро дорогое, возьми такси; не будет [есть] стоить значительно больше.", "The tube is [dear/expensive ], so take a taxi; [it's ] not [much more]."),
        };
    }
}
