using Assimil;
using System;

namespace AssimilGenerator.Assimil.FrenchGerman.Advanced
{
    public class Lesson_1 : LessonBase
    {
        public override ValueTuple<string, string>[] TranslationExample => new[]
        {
            (@"(Mais) Vous parlez vraiment déjà très bien l'allemand!",
                 @"Sie sprechen aber wirklich schon sehr gut deutsch!"),

            (@"C'est un gentil compliment, mais vous exagérez certainement un peu. Je sais trég bien que j'ai encore de grandes difficultés.",
                 @"Das ist ein nettes Kompliment, aber Sie Ubertreiben sicher etwas. Ich wei genau, da& ich noch gro&e Schwierigkeiten habe.  (1) (2) (3)"),

            (@"Des difficultés ? (Alors) J'aimerais bien parler votre langue comme vous [parlez] la mienne !",
                 @"Schwierigkeiten? Also ich wurde gerne Ihre Sprache so gut sprechen wie Sie meine."),

            (@"Cela, vous le pourriez trés vite. Faites (le) comme moi: chaque jour une petite lecon! Par ailleurs, ma langue est bien plus facile que la vétre.",
                @"Das kénnten Sie sehr schnell. Machen Sie es so wie ich: Jeden Tag eine kleine Lektion!  AuBerdem ist meine Sprache viel einfacher als Ihre."),

            (@"L'allemand serait difficile? Je ne peux pas le croire. Chaque enfant ici parle (vous le savez bien) allemand.",
                @"Deutsch soll schwer sein? Das kann ich nicht glauben. Jedes Kind hier spricht doch deutsch."), (@"C'est exact et je me demande comment ils ont fait pOur apprendre toutes ces règles compliquées.",@"Das stimmt, und ich frage mich, wie die alle diese komplizierten Regeln gelernt haben."),

            (@"Des régies? Je n'ai pas appris de règles et pourtant je parle |'allemand (le ‘‘haut-allemand”) correctement, [du moins] |'espêre.",
                @"Regeln? Ich habe keine Regeln gelernt, und ich spreche trotzdem hochdeutsch, hoffe ich."),

            (@"Mais alors, comment savez-vous toujours ou il faut placer le verbe dans une phrase ?",
                @"Woher wissen Sie denn dann immer, wohin man in einem Satz das Verb stellen mu?"),

            (@"Mais ce n'est pas difficile, cela se sent (on le sent, vous savez bien) !",
                @"Das ist doch nicht schwierig, das fuhlt man doch!"),

            (@"Pas moi, malheureusement ! Je sen$ le verbe la ou il se trouve dans ma langue [& moi]; et la plupart du temps, il se trouve a une autre place.",
                @"Ich leider nicht! Ich filhle das Verb dort, wo es in meiner Sprache steht; und es steht meistens an einem anderen Platz."), (@"Ca doit étre une drdle de langue, si on peut placer le verbe a une mauvaise (fausse) place.",@"Das muf§ aber eine komische Sprache sein, wenn man das Verb an einen falschen Platz stellen kann."),

            (@"Non pas (a une) mauvaise, (a une) différente |",
                @"Nicht an einen falschen, an einen anderen!"),

            (@"Et ou se trouve le verbe dans votre langue, si je peux me permettre la question (de demander) ?",
                @"Und wo steht es in |hrer Sprache, wenn ich fragen darf?"),

            (@"Eh bien, c’est assez difficile a expliquer.",
                @"Nun, das ist ziemlich schwierig zu erklaren."),

            (@"C’est ce que je me disais (je l'ai pensé) Je comprends maintenant, pourquoi vous apprenez ma langue et non pas moi la vôtre | Elle doit étre drôlement compliquée.",
                @"Das habe ich mir gedacht. Ich verstehe jetzt, warum Sie meine Sprache lernen und nicht ich Ihre! Die muf& ja ganz schon kompliziert sein."),
        };

        public override string[] Notes => new[]
        {
            (@"Ubertreiben (verbe a particule inséparable) = exagérer, Uber- peut
&tre particule séparable ou inséparable. Elle est séparable lorsque
la signification de Uber reste proche de celle de la préposition de
lieu Uber comme dans dber/aufen (déborder). La particule porte
alors l'accent {dberlaufen), Das Wasser fauft uber = L'eau déborde
{sous-entendu ber den Rand = ‘eau coule par-dessus le bord).
Au contraire, elle est inséparable pour les verbes tels que dber-
legen (réfléchir), dbersetzen (traduire), dberholen (dépasser). Ici,
c'est le verbe qui porte I'accent (ex.: ubersetzen, eatc.)."),

            (@"GroBe Schwierigkeiten haben = avoir de grandes difficultés. Et
voila une difficulté en moins pour ceux qui apprennent I'allemand: il
n'y a pas dvarticle partitif (J’achéte du pain = Ich kaufe Brot) ni
d'article indéfini au pluriel (J'ai rencontré des amis = /ch habe
Freunde getroffen)."),

            (@"Genau = précis: leh brauche genaue Informationen = J'ai besoin
d'informations précises. Genaues wei& man nicht = On ne sait
rien de précis."),

            (@"ich wiirde gern Ihre Sprache sprechen = J'aimerais bien parler
votre langue... Oui, certainement, s'il pouvait y arriver sans effort!
Warde + l'infinitif du verbe remplace très souvent la forme
originale du Kenjunktiv | [ich spraéche), employe ici pour exprimer
un souhait/regret."),

            (@"La comparaison: |'égalité/la ressemblance {ou sa négation) se
marquent par “so... wie”: Machen Sie es (nicht) so wie ich =
Faites-le (ne je faites pas) comme moi. La difference est marquée
par Kamparativ = a/s: Meine Sprache ist (nicht) einfacher als ihre
= Ma langue (n’) est (pas) plus facile que ja vôtre."),

            (@"AuBerdem: en outre, par ailleurs, d'ailleurs - selon le contexte.
Au®er (préposition avec le datif) = sauf, en dehors de...: Alle
Sprachen sind schwer, auBer meiner Muttersprache = Toutes les
langues sont difficiles sauf ma langue maternelle."),

            (@"Deutsch soll schwer sein? = L'allemand serait (d’aprés quelqu’un)
difficile? Soien siqnifie ici ‘on dit que’. Nous reparlerons des
verbes de modalisation a la lecon 7. Notez au passage que ,,/edes
Kind” est souvent utilisé dans le sens de ‘tout le monde’. Das
weil doch jedes Kind: tout le monde sait ca.."),

            (@"..., wie die alle diese ... Regeln lernen. Vous avez bien raison, le die
n’est pas l'article de Rege/n, mais tient la place de diese Kinder ou
Sie. Dans la langue courante, article défini remplace souvent a lui
tout seul un nom ou uN pronom personnel: Veux-tu voir ce film?
Non, je l'ai déjà vu = Nein, den (a la place de ihn, ou den Film)
habe ich schon gesehen."),

            (@"Trotzdem \adverbe) = malgré cela, tout de méme, pourtant: Ou
hast recht, aber ich bin tratzedem nicht einverstanden = Tu as
raison mais je ne suis tout de méme pas d’accord."),

            (@"Hochdeutsch = |e ‘‘haut-allemand’, terme qui désigne aujourd'hui
l'allemand prononcé et écrit selon la norme officielle, en opposition
au terme de platideutsch (initialement les dialectes au nord d'une
frontière linguistique partageant allemand) = allemand dialectal.
C'est une narme un peu articifielle: fe Hochdeutsch est la langue
enseignée aux acteurs et speakers de radio/télévision, et selon les
régions, l'allemand parlé comporte des déviations plus ou moins
importantes. Mais ne vous inquiétez pas, on vous comprendra
partout!"),

            (@"Ich leider nicht! Rappelez-vous que les Allemands n‘ont qu'un seul
pronom: “ich” (et ses différentes formes: mich, mir, meiner) la ou
les Francais en ont deux - je et moi (idem pour du = tu et toi, er =
il et lui...), Ne croyez pas que ce soit seulement pour combler ce
manque que Freud s'est autant intéressé a la dualité entre le “/ch’”
(moi) et le “Uber-tch” {sur moi)!"),

            (@"An einem anderen Platz stehen mais an einen anderen Platz
stellen. Subtile, cette différence entre verbes indiquant une
position dans l’espace fstehen) et ceux exprimant une action / un
mouvement (stellen, non? N'oubliez pas que les premiers
imposent le datif aprés la préposition du complément de lieu fan
einem Platz stehen), les seconds |'accusatif {an einen Platz stellen)
pour autant que !a préposition permette ce choix!"),

            (@"Ganz schon kompliziert = ziemlich kompliziert = assez compii- quée, mais ganz schdn y ajoute de l'ironie, donne un accent de reproche: C’est bien compliqué. C’est du joli, ca!"),
        };

        public override ValueTuple<string, string>[] TranslationExercise => new[]
        {
            (@"Il aime bien exagérer ses difficuités, mais il fait peu de fautes.",
                @"Er Ubertreibt gerne seine Schwierigkeiten, doch er macht wenig Fehler."),

            (@"Je suis plus riche que toi. Malheureusement je ne suis pas vraiment aussi heureux (que toi).",
                @"Ich bin reicher als du. Leider bin ich nicht wirklich so glicklich wie du."),

            (@"Nous aimerions bien parler votre langue, mais (d'aprés ce qu'on dit) elle doit étre trés difficile.",
                @"Wir wurden gern eure Sprache sprechen, aber sie soll sehr schwer sein."),

            (@"Il n’était (encore) jamais [allé] en Allemagne. Pourtant, il parle déjà assez bien allemand.",
                @"Er war noch nie in Deutschland. Er spricht trotzdem schon ziemlich gut deutsch."),

            (@"La plupart du temps on sent ou le verbe doit se trouver.",
                @"Meistens filhit man, wo das Verb stehen muf."),
        };


        public override ValueTuple<string, string>[] ExerciseOnSentenceCompletion => new[]
        {
            (@"Je ne sais pas pourquoi le verbe doit se trouver a cette place.",
                @"Ich wei8 nicht, warumdas Verb [an diesem] Platz [stehen muB]."),

            (@"Il aimerait bien apprendre aussi vite que les autres, mais if a moins de temps qu'eux.",
                @"Er [ wlirde] gern’ [so] ‘schnelllernen [wie] die anderen, aber er hat [weniger] Zeit [als sie]."),

            (@"Il aurait appris la langue en deux mois ? Je ne le crois pas.",
                @"Er [soll ] die Sprache [in] zwei Monaten [gelernt haben]? Das glaube ich nicht."),

            (@"J'ai matheureusement assez peu de temps, mais j‘aimerais bien venir tout de méme.",
                @"Ich habe [leider ziemlich] wenig Zeit, aber ich [wirde trotzdem] gern kommen."),

            (@"Je ne mets jamais ma voiture dans cette rue, car on n'a pas le droit d'y stationner.",
                @"[Ich stelle] mein Auto nie in [diese ] Strae, denn man [darf ] hier nicht parken."),
        };

    }
}
