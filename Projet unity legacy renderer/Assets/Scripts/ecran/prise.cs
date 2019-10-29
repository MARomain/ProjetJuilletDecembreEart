using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prise : MonoBehaviour
{
    public objectgrab objectgrab;
    public GameObject aimantpoint;
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
                other.gameObject.transform.position = aimantpoint.transform.position;
            }
        }
    }
  
}
