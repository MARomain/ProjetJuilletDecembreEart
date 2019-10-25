using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyhole : MonoBehaviour
{
    private Rigidbody rb; //rb de la clef ,utilisé pour les contraintes de déplacement.
    public GameObject hole; //le fond du trou

   

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Key>()!= null) //si c'est la clef et pas autre chose
        {
            rb = other.gameObject.GetComponent<Rigidbody>(); //recupere le rigidbody de la clef
            rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ; //la freeze pour ne pas pourvoir l'arracher de façon etrancge
            //!!!!!!!!!!! Possible probleme avec la façon don l'objet est tenue en main
           
            hole.transform.parent= other.gameObject.transform; //attache le fond du trou a la clef
         
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        hole.transform.position = this.gameObject.transform.position; // remet le fond du trou a son endroit initial
        hole.transform.parent = this.gameObject.transform;//retire le fond du trou de la clef


        rb.constraints = RigidbodyConstraints.None;//retire les contraintes de déplacement de la clef
    }
}
