using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infobutton : MonoBehaviour
{
    public Text titre;
    public Text text;
   
    //titre 25 lettres max
    public void Procedure1()
    {
        titre.text = ("Boîte de diagnostic");
        text.text = ("ATTENTION - Cette procédure doit être exécutée uniquement dans le cadre d’une défaillance majeure et avéré du bâtiment. L’utilisation d’un dispositif d’analyse et de diagnostic portable à des fins de sabotage ou de piratage est passible de sanctions de niveau 4. -" + "Procédure d’urgence de diagnostic du système par un appareil portable. Cette procédure sera réquisitionnée par le système pour les cas de figure suivants :" + "-Séparation du système concerné de son système administrateur" + "-Avarie majeur de l’ordinateur du système au niveau informatique ou physique" + "-Dans le cas d’un système militaire exposé à une impulsion électro-magnétique volontaire dans le cadre d’une attaque ayant affecté le système principal ou les auxiliaires." + "L’appareil d’interface et de diagnostic portable Mod. systèmes d’administration de bâtiments spaciaux. (Ou boite de diagnostic) a été reconfiguré par NOVA corporation, cette documentation de procédure a également été édité par NOVA pour répondre à ses besoins spécifiques." + "Etape numéro 1 :" + "Munissez vous de la boite de diagnostic." + "Etape numéro 2 :" + "Repérer la prise pour connecter la boite de diagnostic au tableau de bord du vaisseau. La prise correspondante doit se situer sur le tableau de bord central de la salle de contrôle du vaisseau." + "Etape numéro 3 :" + "Attendez que le code d’erreur soit affiché, une fois celui-ci affiché sur l’écran de la boîte, transmettez le à votre supérieur, votre opérateur, ou à une personne disposant d’un terminal informatique avec une banque de donné NOVA." + "Etape numéro 4 :" + "Débranchez la boite de diagnostic et rangez la dans le compartiment où vous l’avez trouvée. Tout matériel manquant après une opération de réparation sera facturé à l’entreprise ayant effectué la dite opération. NOVA corporation se réserve le droit de ne pas rembourser la perte de matériel dans le vide spatial, ou de son absorption dans les turbines ou les systèmes de rejets des déchets du vaisseaux.");
    }
    public void Procedure2()
    {
        titre.text = ("La porte serveur :");
        text.text = ("ATTENTION - Ne pas exécuter cette procédure sans diagnostic au préalable. Un composant manquant ou endommagé peut entraîner la perte de fonctions vitales du bâtiment. -" + "L’exécution de cette procédure est requise en cas de dommage physique ou d’une déconnexion d’un ou plusieurs composants électroniques." + "Etape numéro 1 :" + "Insérer la clé dans la serrure de la porte, un voyant indique la détection de la clé." + "Etape numéro 2 :" + "Le code d’ouverture et le modèle de serrure peut cependant provenir d’une entreprise sous traitante, référez vous au numéro de série pour identifier le code d’ouverture." + "Liste des codes par numéros de séries :" + "ZX789A : 248" + "DZ7Y9G : 268" + "ZX19JP : 187" + "ZX782G : 371" + "ZJ79QS : 356" + "PPO78G : 782" + "ZX743G : 164" + "YU863K : 736" + "Placer la clé sur les bons crans dans l'ordre indiqué et valider chaque cran en appuyant sur le bouton présent sur la porte." + "ATTENTION - Les serrures de série ZX782 comporte une anomalie au niveau du 2eme loquet, un fort son de cliquetis mécanique peut être entendu si le loquet est déverrouiller. Cela peut causer de graves problème de sécurité. Si vous constatez ce problème veuillez le reporter à ERSE Corporation afin que des mesures puissent être engagées. -" + "Pour effectuer une opération sur les composants du serveur veuillez vous référer à l’onglet serveur.");
    }
    public void Procedure3()
    {
        titre.text = ("Remise en état système :");
        text.text = ("Les systèmes du satellite sont géré via un serveur présent à bord. Si le système est défaillant cela provient des cartes du serveur. Pour remettre en état le satellite les systèmes vitaux doivent être fonctionnels. En cas d’urgence les systèmes secondaires peuvent être ignoré." + "Etape numéro 1 :" + "Effectuer une inspection du serveur du satellite et utiliser l’onglet serveur pour évaluer les dégâts." + "Etape numéro 2 :" + "Connecter les cartes fonctionnelles aux système vitaux, les cartes non fonctionnelles peuvent rester sur les systèmes secondaires, elles seront récupérée par NOVA Corporation. Les cartes non interchangeables vitales sont présentes en plusieurs exemplaires dans les satellites pour remplacement en cas de problèmes." + "Etape numéro 3 :" + "Une fois les modifications et remplacements effectué, exécuter la commande de redémarrage du système.");
    }
    public void Erreur1()
    {
        titre.text = ("001C48H7");
        text.text = ("Energie insuffisante pour démarrer le système." + "Opération recommandée : Changer l’axe du panneau solaire pour accroître le gain d’énergie.");
    }
    public void Erreur2()
    {
        titre.text = ("0E22G32D");
        text.text = ("Faille dans la coque." + "Opération recommandée : Effectuer une inspection pour localiser et combler la faille, en cas de dégâts importants procéder à une isolation de la partie endommagée.");
    }
    public void Erreur3()
    {
        titre.text = ("00J2H345");
        text.text = ("Défaillance du module d’oxygène." + "Opération recommandée : Procéder à une analyse rapide du module, si la remise en état du module semble impossible NOVA Corporation recommande d’évacuer le bâtiment.");
    }
    public void Erreur4()
    {
        titre.text = ("0912E73J");
        text.text = ("Composants électroniques serveurs endommagé." + "Opération recommandée : Accéder au compartiment serveur et remplacer les composants.");
    }
    public void Erreur5()
    {
        titre.text = ("004EHG1");
        text.text = ("Action indisponible." + "Opération recommandée : L’action demandée ne peut pas être effectué actuellement. Re lancer l’action plus tard et contacter NOVA Corporation si le problème persiste.");
    }
    public void Erreur6()
    {
        titre.text = ("0T283JS");
        text.text = ("Registre corrompu." + "Opération recommandée : Lancer une réinitialisation du système.");
    }
    public void Erreur7()
    {
        titre.text = ("009DT5");
        text.text = ("Erreur du système de contrôle thermique." + "Opération recommandée : Accéder au contrôle manuel du SCT et rétablir une température acceptable pour les modules.");
    }
    public void Erreur8()
    {
        titre.text = ("0Y8TS7");
        text.text = ("Déconnexion du sous système de contrôle des portes" + "Opération recommandée : Procéder au verrouillage manuel des portes extérieures et  redémarrer le sous système de contrôle des portes.");
    }
}
