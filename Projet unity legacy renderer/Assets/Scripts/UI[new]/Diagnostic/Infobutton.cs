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
        titre.text = ("Je suis le titre");
        text.text = ("je suis le text et j'aime etre un text mais en plus d'etre un text je suis un test parce je pense que c'est ca le futur " +
            ",un monde ou l'on peut etre plusieur choses a la foix et aspirer au meilleur de chaque monde.");
    }
    public void Procedure2()
    {
        titre.text = ("Souflez dans la cartouche");
        text.text = ("On m'a dit que ca servait a rien ....mais pourquoi ca marche quand je le fait?");
    }
    public void Procedure3()
    {
        titre.text = ("Smashing your face agains the keyboard");
        text.text = ("that should do it");
    }
    public void Erreur1()
    {
        titre.text = ("Je suis une erreur");
        text.text = ("arg nein je bug.");
    }
    public void Erreur2()
    {
        titre.text = ("Je suis une erreur DU FUTUR");
        text.text = ("IL Y A PLUS DE SAUCISSON!");
    }
    public void Erreur3()
    {
        titre.text = ("Construisez plus de puit de lune");
        text.text = ("Des infideles attaque notre ville");
    }
    public void Erreur4()
    {
        titre.text = ("Problematic problem");
        text.text = ("have you think about not doing stupid things?");
    }

 
}
