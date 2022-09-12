using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_9 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"У меня есть немного [какие-нибудь]; Не хочу никаких/никакой.",@"I've got some; I don't want any."),
            (@"У вас есть [какой-нибудь] горошек, пожалуйста?",@"Have you got any peas, please?"),
            (@"Да, у меня есть немного больших банок.",@"Yes, I've got some big tins."),
            (@"Есть ли кто-нибудь дома? Я кого-то слышу [буквально: я могу кого-то слышать].",@"Is anyone at home? I can hear someone."),
            (@"Да, это [-] я. Я [-] на [в] кухне.",@"Yes it's me. I'm in the kitchen."),
            (@"Хочешь чашку чая? - Да, пожалуйста.",@"Do you want a cup of tea? - Yes please."),
            (@"Тогда входи.",@"Come in then."),
            (@"Угощайся сигаретой. [Возьми сигарету.] - Спасибо. У меня нет никаких (сигарет).",@"Have a cigarette. - Thank you, I haven't got any."),
            (@"Эти [-] хорошие! - Да, они [-] турецкие.",@"These are good! - Yes, they're Turkish."),
            (@"У меня есть трубка, но я предпочитаю сигареты.",@"I've got a pipe, but I prefer cigarettes."),
            (@"Трубка не [-] так опасна, как сигареты.",@"A pipe isn't as dangerous as cigarettes."),
            (@"  Я знаю... но и не [-] так хороша!",@"I know... but it isn't as good!"),
            (@"Огонь у тебя есть? - Спасибо.",@"Have you got a light? - Thanks."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Никаких/ого/ой не хочу, спасибо.",@"I don't want any, thank you."),
            (@"На кухне кто-то есть.",@"Someone is in the kitchen."),
            (@"Хочет ли кто-нибудь сигарету?",@"Does anyone want a cigarette?"),
            (@"Мы кого-то видим в саду.",@"We can see someone in the garden."),
            (@"Входи [входите].",@"Come in."),
        };

    };
}
