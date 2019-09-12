using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/* This class patches the dual display issue introduced after 5.4 where Display -> None was being overwritten by the VR Display
 * which meant that assymetrical play/display was no longer possible.
 * it turns out there is a programmatic setting that must be toggled to enable and disable this feature
 * this class automatically detects if you have a second camera for main display or not and toggles the setting
 * which effectively makes newer versions of Unity act just a 5.4 did, which I find more intuitive as this should really be automatic
 * @LordOfTheStack
 * */
public class VRDualDisplay : MonoBehaviour
{

    private static VRDualDisplay instance;

    void Awake()
    {
        //this class should be global, set it up on your first scene and it will persist forever
        if (instance)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
        instance = this;
    }

    void Update()
    {
        //check if you have a camera that is trying to render something different to the main monitor display
        bool async = false;
        foreach (Camera cam in Camera.allCameras)
        {
            if (cam.stereoTargetEye == StereoTargetEyeMask.None && cam.isActiveAndEnabled)
                async = true;
        }
        bool DuplicateDisplay = !async;
        if (DuplicateDisplay != UnityEngine.XR.XRSettings.showDeviceView)
        {
            Debug.Log("MIRROR VR DISPLAY " + DuplicateDisplay);
            UnityEngine.XR.XRSettings.showDeviceView = DuplicateDisplay;
        }

    }
}

            