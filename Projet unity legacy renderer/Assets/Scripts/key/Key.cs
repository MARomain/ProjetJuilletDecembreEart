using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool keyinhand; //evite de pouvoir l'activer quand on ne l'a pas dans la main,passe en true quand la clef est ramassé.
    public bool activekey;//bool activé quand le bouton de la clef est appuyé,sert pour les autres script.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyinhand)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                activekey = true;
    
            }else
            {
                activekey = false;
            }
        }
       
    }
}
