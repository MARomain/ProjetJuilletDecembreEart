using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Manivelle : MonoBehaviour
{
    public GameObject panneauSolaireGo;
    public CircularDrive circular;
    public float rotationMultiplier;
    public GameObject roomLight;
    public float minOrientation = 100f;
    public float maxOrientation = 130f;
    
    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();
    }

    // Update is called once per frame
    void Update()
    {
        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * rotationMultiplier, Vector3.forward);

        if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation)
        {
            roomLight.SetActive(true);
        }
        else
        {
            roomLight.SetActive(false);
        }
    }
}
