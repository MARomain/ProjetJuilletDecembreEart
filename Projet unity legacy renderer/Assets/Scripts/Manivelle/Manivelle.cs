using System.Collections;
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
    public GameObject roomLight;
    
    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();

    }

    // Update is called once per frame
    void Update()
    {
        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * multiplier, Vector3.forward);

        if (panneauSolaireGo.transform.eulerAngles.z >= 100f && panneauSolaireGo.transform.eulerAngles.z <= 130f)
        {
            debugWin.SetActive(true);
            roomLight.SetActive(true);
        }
        else
        {
            debugWin.SetActive(false);
            roomLight.SetActive(false);
        }
    }
}
