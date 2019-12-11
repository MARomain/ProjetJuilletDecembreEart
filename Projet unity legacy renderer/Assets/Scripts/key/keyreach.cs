using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyreach : MonoBehaviour
{
    public Keygeneral keygeneral;//gere la progression de l'enigme
    public Key key;//choppe les input de la clef
    public bool active; //envoye au keygeneral
    public GameObject thelight; //link a la lumiere qui s'active quand la clef est en position

    private void Start()
    {
        thelight.SetActive(false); //de base la lumiere est éteinte quand il n'y a pas de clef dans la serrure
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Key>())
        {
            if (key.activekey)
            {
               
                // en dessous = si la celf est dedans et que le bouton est appuyé
                active = true;
                keygeneral.Inputneedtobecheck(); //trigger le traitement de la solution
                key.activekey = false; 

            }
            //en dessous= si la clef est dedans mais ne fait rien
            thelight.SetActive(true); //si la clef est en face=alume 
           
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.GetComponent<Key>())
        {
            if (keygeneral.finished == false)
            {
                thelight.SetActive(false);//retire la lumiere quand la clef n'est plus la
            }

         
        }
    }
}
