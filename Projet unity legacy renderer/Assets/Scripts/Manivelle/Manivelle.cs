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
    public Animator light_animator;
    public float minOrientation = 100f;
    public float maxOrientation = 130f;
    public float animation_marge = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();
        light_animator.SetBool("flicker", false);
    }

    // Update is called once per frame
    void Update()
    {
        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * rotationMultiplier, Vector3.forward);

        if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation - animation_marge && panneauSolaireGo.transform.eulerAngles.z <= minOrientation || panneauSolaireGo.transform.eulerAngles.z >= maxOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation + animation_marge)
        {
            roomLight.SetActive(true);
            light_animator.SetBool("flicker", true);
        }
        else if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation)
        {
            light_animator.SetBool("flicker", false);
        }
        else
        {
            roomLight.SetActive(false);
            light_animator.SetBool("flicker", false);
        }
    }
}
