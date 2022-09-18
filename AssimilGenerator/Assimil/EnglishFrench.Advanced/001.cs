using Assimil;
using System;

namespace AssimilGenerator.Assimil.EnglishFrench.Advanced
{
    public class Lesson_1 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"You have this book between your hands and you are wondering if it is for you:",
                @"Vous avez ce livre entre les mains et vous vous demandez s'il est pour vous ;"),

            (@"so, turn your back to the salesman for a minute and listen to this dialogue:",
                @"alors, tournez le dos au vendeur un instant écoutez ce dialogue :"),

            (@"What do you mean by ‘the practice of French’?",
                @"dire par «la pratique du français ?"),

            (@"I see what you's going to say. Tell me, do you speak French:",
                @"Je vous vois venir, vous! Dites, parlez-vous français ?"),

            (@"Yes indeed. At least, | make myself understood. I can say what I like and the others...",
                @"Mais oui. Du moins, je me fais comprendre. Je peux dire ce que je veux et les autres..."),

            (@"You mean that the people you are speaking to (4) understand you. — Pardon?",
                @"Vous voulez dire que vos interlocuteurs vous comprennent. — Pardon ?"),

            (@"So, this book is indeed for you. You have a good base in grammar",
                @"Donc, ce livre est en effet pour vous. Vous avez de bonnes bases grammaticales"),

            (@"and a fairly rich vocabulary but you need the ‘little something’.",
                @"et un vocabulaire assez riche, mais il vous manque le « petit quelque chose »."),

            (@"The little what? — The little something which means that you live the language;",
                @"Le petit quoi ? — Le petit quelque chose quifait que vous vivez la langue ;"),

            (@"You know its peculiarities of style, its moods,",
                @"vous connaissez ses particularités de style, ses humeurs,"),

            (@"its idiosyncracies; you know that the language is the reflection of the country and the people who speak it.",
                @"ses « trucs » ; Vous savez que la langue est nn du pays et des gens qui la parlent."),

            (@"In short, you need practice.",
                @"Bref, vous avez besoin de la pratique."),

            (@"It's much more than texts; it’s a journey across France and French that we will make together.",
                @"C'est bien plus que les textes: c’est un voyage à travers la France et le français que nous ferons ensemble."),

            (@"Well, shall we go? But first, let's see what the future has in store for us...",
                @"Alors, on y va ? Mais d'abord, voyons ce que l'avenir nous réserve..."),

        };

        public override string[] Notes => new[]
        {
            (@"Remember that the words for the parts of the body are not usually 
                personalised in French, i.e. the possessive adjective is not generally
                used. Vous avez les yeux rouges: Your eyes are red. Il s’est lavé les
                mains: He washed his hands.
                However, we would use a possessive if the noun is modified by an
                adjective: Il s‘est lavé ses mains sales: He washed his dirty hands.
                A possessive adjective is also used where there may be a confusion
                as to the ‘possessor’: Je connais son visage: I know his/her face."),

            (@"Se demander (literally, to ask oneself) is best rendered as to wonder.
                Parfois, je me demande s‘i! a raison: Sometimes, I wonder whether
                he is right. Vous vous demandez pourquoi je vous ai téléphoné,
                n'est-ce pas?: You are wondering why I ‘phoned, aren't you?
                To wonder at a person or something that takes your breath away
                needs the verb s'émerveiller from which we get the adjective
                merveilleux (marvellous, wonderful)."),

            (@"An idiom meaning: I know what's coming; I know what you're
                getting at. Notice the use of the infinitive both in this idiom and the
                expression in the next line."),

            (@"Je me fais comprendre: I make myself understood. Il y avait un tel
                bruit qu'il ne pouvait pas se faire entendre: There was such a noise
                that he could not make himself heard.
                Where English would use a past participle in such expressions,
                French uses the infinitive."),

            (@"One of the characteristics of French is its use of complicated-look-
                ing nouns or verbs, usually of classical origin, where English would
                use a compound noun, a noun-preposition group or a phrasal verb."),

            (@"Using the correct word - le mot juste - is very important in speaking
                or writing good French.
                Getting the hang of such words is a question of exposure then trial
                and error. The noun un interlocuteur means simply the person one is
                talking to or is in contact with; in good French itis this word and not
                the paraphrase that one should use.
                We look at this question in greater detail in Lesson 33."),

            (@"Manquer is an awkward verb to use correctly. Its basic meaning is
                to miss or to lack. Look at these different constructions: 
                il est 10 heures; il manquera son train: It is 10 o'clock; he will miss
                his train.  
                Il me mangue dix francs: I am ten francs short.  
                if manque deux boutons 4 ma chemise: My shirt has two buttons
                missing.  
                Do you see how the il in the last two examples is impersonal? In
                English we say: I need... or I miss... whereas French uses the dative:
                To me is missing... etc.  
                As we said, this is a rather complex usage. Memorise our examples
                and we will return to the subject later in the book."),

            (@"Un truc is almost a vocabulary in itself. Used familiarly, it means a
                thing, a whatname and so on.  
                You will often hear it (a) when explaining something mysterious; a
                French person will say [Il y a un truc]: There’s something unusual/
                odd/wrong/I| don’t understand; (b) when describing-how to carry
                out a manceuvre or series of operations; here the phrase means:
                There's a knack to it.  
                In sentence 11 we would have to translate it by ‘idiosyncracies’
                which rather makes truc (that indefinable ‘something’) lose its
                charm.  
                Becoming familiar with such words and their uses is what we mean
                by /a pratique du français."),

            (@"Another way of saying [beaucoup plus que]."),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"I have smoked too much; I have a headache.", @"J'ai trop fumé ; j'ai mal à la tête."),
            (@"She wondered why John had telephoned.", @"Elle s'est demandée pourquoi Jean avait téléphoné."),
            (@"He doesn't have enough money; he is ten francs short.", @"Il n'a pas assez d'argent : il lui manque dix francs."),
            (@"I didn't understand how to use it. There must be a knack to it.", @"Je n'ai pas compris comment l'utiliser. Il y a sûrement un truc."),
            (@"It is far more than a simple book of exercises.", @"C'est bien plus qu'un simple livre d'exercices."),
            (@"I saw her through the window.", @"Je l'ai vue à travers la fenêtre."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            (@"He will make himself heard with no problems!", @"Il se [fera entendre] sans problèmes!"),
            (@"He is ten francs short for a taxi", @"Il [lui manque] dix francs pour prendre un taxi,"),
            (@"so he will miss his plane for sure.", @"donc il [manquera] sûrement son avion."),
            (@"There he is as usual, his hands in his pockets.", @"Le voilà comme d'habitude, [les] mains dans [les] poches."),
            (@"She turned her back on me.", @"Elie [m] ‘a [tourné] [le] dos."),
        };

    }
}
