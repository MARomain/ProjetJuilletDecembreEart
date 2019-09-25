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
        if(other.gameObject.tag == "Key")
        {
            Debug.Log("collide");
            rb = other.GetComponent<Rigidbody>();
            other.gameObject.transform.position = snapPoint.position;
            other.gameObject.transform.rotation = Quaternion.Euler(other.gameObject.transform.rotation.x, snapPoint.rotation.y, snapPoint.rotation.z);
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
