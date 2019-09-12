using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipslot : MonoBehaviour
{
public enum chipnum { A,B,C,D}//quel est la bonne chip a mettre
    public chipnum chip;
    public bool check = false; //retourne true si la bonne chip est dedans

    private void OnTriggerEnter(Collider other)
    {
        switch (chip)
        {
            case chipnum.A:
                {
                    if (other.gameObject.tag == "ChipA")
                    {
                        Debug.Log("ChipA en place");
                        check = true;
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
  //si tu retire la bonne chip ,ca retire check
    private void OnTriggerExit(Collider other)
    {
        check = false;
    }


}
