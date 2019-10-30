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
    public float animation_marge2 = 50;

    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();
        light_animator.SetBool("light_phase1", false);
        light_animator.SetBool("light_phase2", false);
    }

    // Update is called once per frame
    void Update()
    {
        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * rotationMultiplier, Vector3.forward);
        // quand l'angle du panneau est presque en place et que les lumieres doivent ce stabiliser
        if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation - animation_marge && panneauSolaireGo.transform.eulerAngles.z <= minOrientation || panneauSolaireGo.transform.eulerAngles.z >= maxOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation + animation_marge)
        {
            roomLight.SetActive(true);
            light_animator.SetBool("light_phase1", true);
            light_animator.SetBool("light_phase2", true);
        }
        // quand l'angle du panneau est pafaitement ajuster, cela stop les anim et laisse le groupe des lumiere activer
        else if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation)
        {
            light_animator.SetBool("light_phase1", false);
            light_animator.SetBool("light_phase2", false);
        }
        //quand l'angle du panneau commence a se rapprocher mais que les lumieres flickers
        else if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation - animation_marge2 && panneauSolaireGo.transform.eulerAngles.z <= minOrientation - animation_marge || panneauSolaireGo.transform.eulerAngles.z >= maxOrientation + animation_marge && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation + animation_marge2)
        {
            roomLight.SetActive(true);
            light_animator.SetBool("light_phase1", true);
            light_animator.SetBool("light_phase2", false);
        }
        //quand l'angle du panneau n'est pas assez proche pour activer quoi que ce soit
        else
        {
            roomLight.SetActive(false);
            light_animator.SetBool("light_phase1", false);
            light_animator.SetBool("light_phase2", false);
        }
    }
}
