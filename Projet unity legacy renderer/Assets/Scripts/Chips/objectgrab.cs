using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class objectgrab : MonoBehaviour
{
    public bool inHand=false;
    
    // ** Hold version avait besoin que la classe objectgrab hérite d'interactable **
    //protected override void OnAttachedToHand(Hand hand)
    //{
    //    inHand = true;
    //}

    //protected override void OnDetachedFromHand(Hand hand)
    //{
    //    inHand = false;
    //}


    // Est déclenché avec l'event OnPickUp() de throwable (attaché à notre objet)
    public void SetInhandTrue()
    {
        inHand = true;
    }

    // Est déclenché avec l'event OnDetachFromhand() de throwable (attaché à notre objet)
    public void SetInhandFalse()
    {
        inHand = false;
    }
}
