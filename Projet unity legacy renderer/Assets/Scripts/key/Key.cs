using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    public bool activekey;//bool activé quand le bouton de la clef est appuyé,sert pour les autres script
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            activekey = true;

            Debug.Log("inputed");
        }
        else
        {
            activekey = false;
        }
    }
    public void Buttonactivekey()
    {
        activekey = true;
        Debug.Log("inputed via vr" + activekey);
    }
    public void ButtonUNactivekey()
    {
        activekey = false;
         Debug.Log("outputed via vr" + activekey);
    }
}
