using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TestScript : MonoBehaviour
{

    // aide via ce lien https://medium.com/@sarthakghosh/a-complete-guide-to-the-steamvr-2-0-input-system-in-unity-380e3b1b3311

    //On crée une variable pour associer l'action set dans les inputs VR (window SteamVR Input)
    //définis dans l'inspector
    public SteamVR_Action_Boolean TestInputOnOff;

    //Besoin de définir une InputScource pour AddOneStateUpListener
    //définis dans l'inspector
    public SteamVR_Input_Sources handType;

    // Start is called before the first frame update
    void Start()
    {
        //On crée un listener Equivalent à Input.GetKeyUp spécifique à notre bouton
        //Par exemple "NotreBouton.GetKeyup"
        TestInputOnOff.AddOnStateUpListener(AppuieLeBouton,handType);
        TestInputOnOff.AddOnStateDownListener(AppuieLeBouton, handType);
        //TestInputOnOff.AddOnUpdateListener(AppuieLeBouton)
    }

    //Fonction listener créer plus haut
    public void AppuieLeBouton(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("LeBouton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
