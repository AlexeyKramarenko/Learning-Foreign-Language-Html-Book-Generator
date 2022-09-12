using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_143 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Когда Пьер был в Лондоне, он имел при себе список полезных выражений. Рассмотрим некоторые из них:",@"When Pierre was in London he had with him a list of useful expressions. Let's have a look at them:"),
            (@"Прошу меня извинить - простите - извините, пожалуйста.",@"I beg your pardon - I'm sorry - Please excuse me."),
            (@"Я хотел бы знать, сможете ли Вы мне помочь? -Не могли бы Вы мне сказать...? - Не могли бы Вы повторить это?", @"I wonder   if you could help me? - Could you tell* me...? - Would you repeat that, please?"),
            (@"Спасибо, я премного благодарен. - Это очень мило с вашей стороны.", @"Thank you, I'm very grateful - That is very kind of you."),
            (@"Вы разрешите .,.? Это место занято? - Можно мне сесть?", @"Would you mind...? - Is this seat taken*? - May I sit* down?"),
            (@"Это не имеет значения. - Это неважно. - Я не против. - Конечно. - Конечно, нет.",@"It doesn't matter - It's not important –I don't mind - Of course - Of course not."),
            (@"Я в восторге, что тебя встретил. Передай привет от меня своей жене.",@"I'm delighted to meet* you - Give* my regards ® to your wife,"),
            (@"Как жаль! - Боюсь, что не смогу прийти. - Я бы хотел.",@"What a pity - I'm afraid I won't be able to come* - I'd love to."),
            (@"У вас было хорошее путешествие? - Каким было путешествие на корабле? - Какая была погода?",@"Did you have a good trip? - How was the crossing  ? - How was the weather?"),
            (@"Не могли бы Вы подсказать мне, как пройти [дорогу] к ...? - Есть ли тут поблизости банк? Где?",@"Could you tell* me the way to...? - Is there a bank near here? Where?"),
            (@"Вы не могли бы, пожалуйста, сказать мне, который час? - Сейчас, наверное, поздно. - Мне кажется, что я раньше (времени).",@"Could you tell* me the time, please? - It's rather late - I seem to be early."),
            (@"Вы откуда? - Я из Лиона. - Мы только что приехали.  ", @"Where do you come* from  ? - I'm from Lyon -We've just arrived."),
            (@"знаете (где-нибудь, какой-нибудь) хороший ресторан? - Может быть, какой- нибудь на Оксфорд стрит.", @"Do you know* a good restaurant? - There might be one in Oxford Street."),
            (@"Боюсь, что не могу вам помочь, я", @"I'm afraid I can't help you, I'm a foreigner - I don't know* London."),
        };

        public override string[] Notes => new[]
        {
            (@"[То wonder] - раздумывать, удивляться, быть заинтересованным. [I wonder] - я задумываюсь, мне интересно я хотел бы знать, часто используется в вежливых обращениях. [I wonder if you could come?] - Я хотел бы знать, сможете ли вы прийти. "),
            (@"[To give, gave, given] - давать, дать - используется в выражениях. [Give my love to] - передай привет, поцелуй от...; [give my regards to] - передай от меня привет."), (@"[То cross] - пройти, переходить, перечеркивать, переплывать (море, озеро). [То be cross with] - сердиться на кого-нибудь. [Cross] - крест."),
            (@"[То come from] - происходить/быть/приехать откуда-нибудь. "),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Разреши мне представить тебя Питеру, отец которого – фермер [отец которого является фермером].",@"Let me introduce you to Peter, whose father is a farmer."),
            (@"Вы не против, если я приду со своей женой? - Конечно, нет.",@"Do you mind if I bring my wife? - Of course not."),
            (@"Извините, пожалуйста, что Вы сказали? - Это не имеет значения.",@"Excuse me, what did you say? - It doesn't matter."),
            (@"Мы с нетерпением ожидаем встречи с тобой.",@"We are looking forward to meeting you."),
            (@"Прошло много времени с тех пор, когда я тебя видел в последний раз.",@"It has been a long time since I last saw you."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "He могли бы Вы мне подсказать, как пройти к ближайшему банку?", "[Could ] you [tell ] me the [way ] to the [nearest] bank?"),
            ( "Надеюсь, что у вас обоих все хорошо, давно вас не видел.", "I hope you [are both ] well, I haven't [seen ] you [for] a long time."),
            ( "Ты откуда? - Из Марселя, мы только что приехали. ", "[Where ] do you [come from ]? - From Marseilles, we've [just arrived]."),
            ( "Я напряженно работал целый месяц, но не нашел исчерпывающей информации.", "I [have been ] working hard [for ] а month, but I [haven't found] enough information."),
            ( "Это место занято? - Нет, сэр. - Можно мне сесть? ", "[Is] this seat [taken]? - No, sir - [May] I [sit down]? "),
        };
    }
}
