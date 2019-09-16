using UnityEngine;


public class chipaimant : MonoBehaviour
{
    public GameObject aimantpoint;
    public bool occuped =false;
    private GameObject atractdone;
    Rigidbody rb;

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<objectgrab>() != null) //si l'objet en collision est un
        {
            objectgrab chip = other.GetComponent<objectgrab>();
            rb = other.GetComponent<Rigidbody>();

            if ((chip.inHand == false) && (occuped == false))
            {
                other.transform.position = aimantpoint.transform.position;
                other.transform.rotation = aimantpoint.transform.rotation;
                rb.isKinematic = true;
                occuped = true;
                atractdone = other.gameObject;
            }
        }
    }

    private void Update()
    {
        if(atractdone != null)
        {
            if (atractdone.transform.position != aimantpoint.transform.position)
            {
                occuped = false;
                rb.isKinematic = false;
            }
        }
        
    }

}
