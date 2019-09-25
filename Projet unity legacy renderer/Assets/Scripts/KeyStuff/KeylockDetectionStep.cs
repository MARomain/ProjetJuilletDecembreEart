using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeylockDetectionStep : MonoBehaviour
{
    public enum KeylockStep { A1, A2, A3}
    public KeylockStep chip;
    public bool check;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "KeyDetection")
        {
            check = true;
        }
    }
}
