using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class KeylockDetection : MonoBehaviour
{
    Rigidbody rb;
    public Transform snapPoint;
    public bool globalValidation;
    public KeylockDetectionStep keylockDetectionStep1;
    //public KeylockDetectionStep keylockDetectionStep2;
    //public KeylockDetectionStep keylockDetectionStep3;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT! :" + other.gameObject);
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Key")
        {
            Debug.Log("You collided with a Key");
            rb = other.GetComponentInParent<Rigidbody>();
            other.gameObject.transform.position = snapPoint.position;
            other.gameObject.transform.localRotation = Quaternion.Euler(other.gameObject.transform.eulerAngles.x, 0f, 90f);
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }

    }

    private void Update()
    {
        if(keylockDetectionStep1 == true /*&& keylockDetectionStep2 == true && keylockDetectionStep3 == true*/)
        {
            globalValidation = true;
            //Ouvre le panneau etc
        }
    }
}
