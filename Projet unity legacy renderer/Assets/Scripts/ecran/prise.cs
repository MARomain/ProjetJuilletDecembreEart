using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prise : MonoBehaviour
{
    public objectgrab objectgrab;
    public GameObject aimantpoint;
    private Rigidbody rbecran;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ecran")
        {
            if (objectgrab.inHand == false)
            {
                rbecran = other.gameObject.GetComponent<Rigidbody>();

                other.transform.position = aimantpoint.transform.position; //snap position
                other.transform.rotation = aimantpoint.transform.rotation; //snap rotation
                rbecran.isKinematic = true; //rend kinemetic (n'a plus besoin de recevoir la physique tant qu'il est attaché)
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        rbecran.isKinematic = false;
    }

}
