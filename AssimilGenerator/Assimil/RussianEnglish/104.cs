using Assimil;
using System;

namespace AssimilGenerator.Assimil.RussianEnglish
{
    public class Lesson_104 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"Не критикуйте (свет) общество: это делают только те, кто не может в него попасть.",@"Don't criticise society:  only those who can't get* into it do that."),
            (@"Единственный способ избавиться от искушения - поддаться ему.",@"The only way to get* rid of  a temptation is to yield to it."),
            (@"Бывший президент снова проведывая Белый Дом (сказал): ""Это приятное место для посещения, но я предпочитаю тут жить""",@"An ex-President, re-visiting the White House: ""It's a nice place to visit, but I prefer to live here."""),
            (@"Самый лучший способ забыть о своих заботах - носить тесную обувь.",@"The best way to forget* your troubles is to wear* tight shoes."),
            (@"Полный энтузиазма молодой священник: ""Какой прекрасный месяц! И это все в моем приходе"".",@"An enthusiastic young priest: ""What a beautiful moon! And it's in my parish!"""),
            (@"Деньги не могут тебе купить друзей, но могут купить тебе высшего [лучшего] класса врагов.",@"Money cannot buy* you friends, but it can buy* you a better class of enemy."),
            (@"Мужчина женщине, которая обвинила его в том, что он пьяный:",@"Man, to a woman who accused him of being drunk:"),
            (@"""Мадам, вы безобразны, а я завтра буду трезвым""" ,@"""Madam, you are ugly - but tomorrow I will be sober."""),
            (@"Не то, чтобы деньги делали все хорошим, но отсутствие денег делает все плохим.",@"It's not that money makes* everything good; it's that no money makes* everything bad."),
            (@"Единственный способ вести себя по отношению к женщине: заигрывать с ней, когда она прекрасна, и с кем-то другим, когда она не очень красива.",@"The only way to behave to a woman is to make* love to her if she is beautiful, and to someone else if she is plain"),
            (@"Твое здоровье важнее всего, повеситься можешь позже.",@"Your health comes* first, you can hang yourself later."),
            (@"Глуп тот, кто входит в антикварный магазин своего друга и кричит: ""Что нового?""",@"A fool is someone who walks into his friend's antique shop and shouts: ""What's new?"""),
        };

        public override string[] Notes => new[]
        {
            (@"[Society] - (избранное) общество, светское общество. "),
            (@"[То get rid of] - избавиться, выбросить. "),
            (@"[Tight] - тесный, плотный; [to be in a tight situation] - быть в трудной ситуации; [to be tight] - быть в напряжении, "),
            (@"[Plain] - обычный, нормальный, не очень красивый; [а plain tie] - однотонный галстук; [а striped tie] - галстук в полоску. "),
            (@"Этот глагол выступает в правильных и неправильных формах: [to hang, hung, hung] - повесить что-то и [to hang, hanged, hanged] - повесить кого-то."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Ты прочитал (то), что он написал?",@"Have you read what he has written?"),
            (@"Я никогда в действительности не читал его книг, но слышал о них.",@"I've never actually read his books but I've heard of them."),
            (@"С нас попросили тридцать пенсов за чашечку чая.",@"We were charged thirty pence for a cup of tea."),
            (@"Его завтра здесь не будет, он едет в командировку.",@"He won't be here tomorrow, he's going on a business trip."),
            (@" Осторожней! Этот пистолет заряжен.",@"Be careful! That gun is loaded."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            ( "Она хотела бы видеть специалиста, но они берут слишком дорого.", "She [would like ] to [see ] а specialist, but they [charge ] too [much]."),
            ( "В настоящее время он работает в банке, но хотел бы сменить (работу).", "[At present ], he [is working ] in а bank, but [he would ] like [to change]."),
            ( "Это путешествие было бы слишком изнурительным, поэтому мы и не поехали.", "That [trip ] would [have been] too exhausting, that's [ why ] we [didn't] go."),
            ( "Я не мог видеть, что происходило, я был слишком далеко от экрана.", "I [couldn't ] see [what ] was happening, I was [too far from] the screen."),
            ( "Его дом выглядит как замок, он (хозяин дома), долэюно быть, очень богатый.", "His house [looks like ] а castle. Не [must be] very rich."),
        };
    }
}
