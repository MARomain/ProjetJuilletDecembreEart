﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Manivelle : MonoBehaviour
{
    public GameObject panneauSolaireGo;
    public Quaternion startAngle;
    public CircularDrive circular;
    public float multiplier;
    public GameObject debugWin;
    
    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();

    }

    // Update is called once per frame
    void Update()
    {
        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * multiplier, Vector3.forward);

        if (panneauSolaireGo.transform.eulerAngles.z >= 42.5f && panneauSolaireGo.transform.eulerAngles.z <= 47.5f)
        {
            debugWin.SetActive(true);
        }
        else
        {
            debugWin.SetActive(false);
        }
    }
}
