using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public Text subtitle;
    public GameObject back;
    private string[] dialogs;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogs = new string[89];
        dialogs[0] = "";
        dialogs[1] = "Quelle ignoble crapule";
        dialogs[2] = "ose perturber mon roupillon ?!";
        dialogs[3] = "Oh ! Oh !";
        dialogs[4] = "C’est vous";
        dialogs[5] = "de la maréchaussée motoportée !";
        dialogs[6] = "Quelle surprise que voilà.";
        dialogs[7] = "Oh, oui, oui oui.";
        dialogs[8] = "Vous pouvez enquêter et enquérir";
        dialogs[9] = "sur mes effets personnels.";
        dialogs[10] = "Je n’ai rien à me reprocher";
        dialogs[11] = "en tant que grand coordinateur,";
        dialogs[12] = "couronné depuis peu";
        dialogs[13] = "grand purificateur,";
        dialogs[14] = "et empereur d’Eauxfolles.";
        dialogs[15] = "Bienvenue sur mon secrétaire visiophonique,";
        dialogs[16] = "Un objet de simple divertissement, bien sûr.";

        dialogs[17] = "L’alerte inondation !";
        dialogs[18] = "Mais que machinez-vous dans mes appartements ?!";
        dialogs[19] = "J’espère que vous n’abimez pas mon sol ciré.";
        dialogs[20] = "Mon sol ciré !";
        dialogs[21] = "L’eau va s’infiltrer !";
        dialogs[22] = "Mon sol ciré !!!";

        dialogs[23] = "Mon sol ciré....";
        dialogs[24] = "Dans quel état vous l’avez laissé ?...";
        dialogs[25] = "Mon sol ciré…!";

        dialogs[26] = "Impossible…";
        dialogs[27] = "Qui- Qui diable a colporté mon code secret ?";
        dialogs[28] = "Oh ! Maître !";
        dialogs[29] = "Oh c’est vous !... c’est vous...";
        dialogs[30] = "Euh- Oh, ce n’était qu’une erreur";
        dialogs[31] = "Je… je…";

        dialogs[32] = "Oh, oh, oui ! Euh...";
        dialogs[33] = "Ça me sert un peu d’écran de surveillance";
        dialogs[34] = "également.";
        dialogs[35] = "Point de voyeurisme ici";
        dialogs[36] = "Je m’inquiète uniquement";
        dialogs[37] = "de la quiétude de mon royaume.";

        dialogs[38] = "Oh ! Sapristi !";
        dialogs[39] = "Oh !";
        dialogs[40] = "Oh, c’est le roy !";
        dialogs[41] = "Mais pourquoi est-il prisonnier dans ce cach-";
        dialogs[42] = "chochoch…";
        dialogs[43] = "...Dans ce chausse-trape";
        dialogs[44] = "impossible à localiser ?";
        dialogs[45] = "Je n’en sais rien du tout.";
        dialogs[46] = "Rien du tout.";

        dialogs[47] = "Mon tiroir !";
        dialogs[48] = "Vous l’avez esquinté, misérables !";

        dialogs[49] = "Ma cordelette de service domestique !";
        dialogs[50] = "Avez-vous fini";
        dialogs[51] = "de réduire à néant mes précieuses babioles ?!";

        dialogs[52] = "Mais !";
        dialogs[53] = "La belle Chlorenthe et le fou !";
        dialogs[54] = "Ils étaient là depuis le début !";
        dialogs[55] = "Non ! Les marauds !";
        dialogs[56] = "Ils ne doivent pas s’échapper !";
        dialogs[57] = "Ils…";
        dialogs[58] = "Oh c’est vrai…";
        dialogs[59] = "Je- je… Euh… ";
        dialogs[60] = "Euh, vous savez ?";
        dialogs[61] = "Le programme impérial est plutôt chargé !";
        dialogs[62] = "Il est justement l’heure";
        dialogs[63] = "de ma petite virée matinale en élastomobile, tiens !";

        dialogs[64] = "Utilisez votre tête !";
        dialogs[65] = "Oui, c’est moi";
        dialogs[66] = "la princesse Chlorenthe.";
        dialogs[67] = "Dites,";
        dialogs[68] = "Si vraiment vous désirez me sortir de là,";
        dialogs[69] = "activez-vous !";
        dialogs[70] = "Cette gerbille galopeuse ne se réveillera";
        dialogs[71] = "que si vous jouez les notes spécifiques.";
        dialogs[72] = "Na na naaa...";
        dialogs[73] = "Quelque chose comme ça…!";

        dialogs[74] = "Réveillez le rongeur galopeur";
        dialogs[75] = "avec les notes !";

        dialogs[76] = "Oh, débrouillez-vous seuls, un peu.";

        dialogs[77] = "Arthur n’a pas à s’inquiéter.";
        dialogs[78] = "Je vais pas mourir non plus !";
        dialogs[79] = "Il faut échapper à ces sinistres automates.";
        dialogs[80] = "Guidez-le jusqu’à la nacelle d’évacuation.";

        dialogs[81] = "Chlo !";
        dialogs[82] = "Elle ne se réveille pas !";
        dialogs[83] = "Je ne sais même pas si elle peut m’entendre !";

        dialogs[84] = "Par ici.";

        dialogs[85] = "Que me vaut cette visite impromptue,";
        dialogs[86] = "Ambroise ?";
        dialogs[87] = "Je sens une présence";
        dialogs[88] = "dans les souterrains.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dialog(int value)
    {
        subtitle.text = dialogs[value];
        if (value == 0)
        {
            back.SetActive(false);
        } else
        {
            back.SetActive(true);
        }
    }

}
