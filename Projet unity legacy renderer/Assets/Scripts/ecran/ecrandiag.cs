using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ecrandiag : MonoBehaviour
{
    public VideoPlayer videoplayer;
    public VideoClip banchemoi;
    public VideoClip chargement;
    public VideoClip erreur;

    public bool branché = false;

    public float tempsdechargementmax = 2f;
    public float tempsdechargement;

    private void Start()
    {
        tempsdechargement = tempsdechargementmax;
        videoplayer.clip = (banchemoi);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "diagprise")
        {
            if (tempsdechargement < 0)
            {
                videoplayer.clip = (erreur);
            }
            else
            {
            videoplayer.clip = (chargement);          
                tempsdechargement = tempsdechargement - Time.deltaTime;
            }
          
        }
    }
    private void OnTriggerExit(Collider other)
    {
        videoplayer.clip = (banchemoi);
        tempsdechargement = tempsdechargementmax;
    }
}
