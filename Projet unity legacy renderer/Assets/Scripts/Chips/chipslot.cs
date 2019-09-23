using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipslot : MonoBehaviour
{
public enum chipnum { A,B,C,D}//quel est la bonne chip a mettre
    public chipnum chip;
    public bool check = false; //retourne true si la bonne chip est dedans

    public GameObject aimantpoint;
    public bool occuped = false;
    Rigidbody chipRb;

    private void OnTriggerEnter(Collider other)
    {
        switch (chip)
        {
            case chipnum.A: //Si notre chipslot est un chipslot A
                {
                    if (other.gameObject.tag == "ChipA") // Et si le chip quand rentre en collision est LE chip A
                    {
                        Debug.Log("ChipA en place");
                        check = true; //Check en true
                        Debug.Log(" chipslot check return "+check);
                    }
                        break;
                }
            case chipnum.B:
                {
                    if (other.gameObject.tag == "ChipB")
                    {
                        Debug.Log("ChipB en place");
                        check = true;
                        Debug.Log(" chipslot check return " + check);
                    }
                    break;
                }
            case chipnum.C:
                {
                    if (other.gameObject.tag == "ChipC")
                    {
                        Debug.Log("ChipC en place");
                        check = true;
                        Debug.Log(" chipslot check return " + check);
                    }
                    break;
                }
            case chipnum.D:
                {
                    if (other.gameObject.tag == "ChipD")
                    {
                        Debug.Log("ChipD en place");
                        check = true;
                        Debug.Log(" chipslot check return " + check);
                    }
                    break;
                }
        }
      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<objectgrab>() != null) //si l'objet en collision est un Chip
        {
            objectgrab chip = other.GetComponent<objectgrab>();
            chipRb = other.GetComponent<Rigidbody>();

            if (occuped == false && chip.inHand == false) //si le slot n'est pas déjà occupé et que le chipn n'est pas tenu en main
            {
                other.transform.position = aimantpoint.transform.position; //snap position
                other.transform.rotation = aimantpoint.transform.rotation; //snap rotation
                chipRb.isKinematic = true; //rend kinemetic (n'a plus besoin de recevoir la physique tant qu'il est attaché)
                // l'objet peut cependant bougé quand le joueur va l'attraper car il est set en tant qu'enfant de la main et déplacé avec le transform et non la
                // physique, bien avoir "parent to hand" dans les attachments flags de "throwable"
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Quand on retire une chip
        if (other.GetComponent<objectgrab>() != null)
        {
            occuped = false; //le slot est également plus occupé
            check = false; //check est du coup faux aussi

            chipRb.isKinematic = false;
        }
    }

}
