using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIselect : MonoBehaviour
{
    public GameObject Energiepanel;
    public GameObject Systempanel;
    public GameObject Navigationpanel;
    public GameObject Severpanel;
    public GameObject Diagnosticpanel;

    // Start is called before the first frame update
    void Start()
    {
        Hideall();
        Energiepanel.SetActive(true);
    }


   public void Hideall()
    {
        Energiepanel.SetActive(false);
        Systempanel.SetActive(false);
        Navigationpanel.SetActive(false);
        Severpanel.SetActive(false);
        Diagnosticpanel.SetActive(false);
    
    }
    public void Showenergiepanel()
    {
        Hideall();
        Energiepanel.SetActive(true);
    }
    public void ShoweNavigationpanel()
    {
        Hideall();
        Navigationpanel.SetActive(true);
    }
    public void ShoweSystempanel()
    {
        Hideall();
        Systempanel.SetActive(true);
    }
    public void ShoweSeverpanel()
    {
        Hideall();
        Severpanel.SetActive(true);
    }
    public void ShoweDiagnosticpanel()
    {
        Hideall();
        Diagnosticpanel.SetActive(true);
    }
}
