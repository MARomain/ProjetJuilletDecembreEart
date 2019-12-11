using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class Manivelle : MonoBehaviour
{
    public GameObject panneauSolaireGo;
    public CircularDrive circular;
    public float rotationMultiplier;
    public Animator light_animator;
    public float minOrientation = 100f;
    public float maxOrientation = 130f;

    public Circleprogress circleprogess;

    // Start is called before the first frame update
    void Start()
    {
        circular = GetComponent<CircularDrive>();
    }

    // Update is called once per frame
    void Update()
    {
      

        panneauSolaireGo.transform.localRotation = Quaternion.AngleAxis(circular.outAngle * rotationMultiplier, Vector3.forward);
        light_animator.SetFloat("puissance", panneauSolaireGo.transform.eulerAngles.z);
        circleprogess.puissance = Mathf.RoundToInt(panneauSolaireGo.transform.eulerAngles.z);
     
        /* 
            // quand l'angle du panneau est presque en place et que les lumieres doivent ce stabiliser
            if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation - animation_marge && panneauSolaireGo.transform.eulerAngles.z <= minOrientation || panneauSolaireGo.transform.eulerAngles.z >= maxOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation + animation_marge)
            {
                roomLight.SetActive(true);
                light_animator.SetBool("light_phase1", true);
                light_animator.SetBool("light_phase2", false);
            }
            // quand l'angle du panneau est pafaitement ajuster, cela stop les anim et laisse le groupe des lumiere activer
            else if (panneauSolaireGo.transform.eulerAngles.z >= minOrientation && panneauSolaireGo.transform.eulerAngles.z <= maxOrientation)
            {
                roomLight.SetActive(true);
                light_animator.SetBool("light_phase1", false);
                light_animator.SetBool("light_phase2", false);
            }
            */

    }
}
