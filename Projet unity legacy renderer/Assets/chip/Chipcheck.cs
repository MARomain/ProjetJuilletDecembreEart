using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chipcheck : MonoBehaviour
{
    public chipslot chipA;
    public chipslot chipB;
    public chipslot chipC;
    public chipslot chipD;

    public bool correct = false;

    public GameObject validatecube; //feedback de réussite a virer hors du test

    // Update is called once per frame
    void Update()
    {
        if ((chipA.check == true)&& (chipB.check == true) && (chipC.check == true) && (chipD.check == true))
        {
            correct = true;
            validatecube.SetActive(true);// feedback de réussite a virer hors du test
        }
        else
        {
            correct = false;
        }
    }
}
