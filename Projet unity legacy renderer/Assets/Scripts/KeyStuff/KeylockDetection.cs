using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class KeylockDetection : MonoBehaviour
{
    Rigidbody rb;
    public Transform snapPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            Debug.Log("collide");
            rb = other.GetComponent<Rigidbody>();
            other.gameObject.transform.position = snapPoint.position;
            other.gameObject.transform.rotation = snapPoint.rotation;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }

    }
}
