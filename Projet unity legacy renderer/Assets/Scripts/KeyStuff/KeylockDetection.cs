using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class KeylockDetection : Interactable
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            Interactable inter = other.gameObject.GetComponent<Interactable>();
            inter.handFollowTransform = false;
        }

    }
}
