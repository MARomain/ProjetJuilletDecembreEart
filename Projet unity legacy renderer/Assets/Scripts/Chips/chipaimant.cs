using UnityEngine;
using Valve.VR.InteractionSystem;

public class chipaimant : Interactable
{
    public GameObject aimantpoint;
    public bool occuped =false;
    private GameObject atractdone;
    Rigidbody rb;
    Interactable inter;

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<objectgrab>() != null) //si l'objet en collision est un
        {
            objectgrab chip = other.GetComponent<objectgrab>();
            inter = other.GetComponent<Interactable>();
            rb = other.GetComponent<Rigidbody>();

            if (occuped == false && chip.inHand == false)
            {
                //inter.attachedToHand.DetachObject(other.gameObject);
                other.transform.position = aimantpoint.transform.position;
                other.transform.rotation = aimantpoint.transform.rotation;
                rb.isKinematic = true;
                occuped = true;
                atractdone = other.gameObject;
            }
        }
    }

    public void GrabInSlot()
    {
        rb.isKinematic = false;
        occuped = false;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<objectgrab>() != null) //si l'objet en collision est un
    //    {
    //        inter = other.GetComponent<Interactable>();

    //        inter.attachedToHand.DetachObject(other.gameObject);
    //        Debug.Log("collision aimant, detach from hand");
    //    }
    //}

    private void Update()
    {
        if (atractdone != null)
        {
            if (atractdone.transform.position != aimantpoint.transform.position)
            {
                occuped = false;
                rb.isKinematic = false;
            }
        }

    }

}
