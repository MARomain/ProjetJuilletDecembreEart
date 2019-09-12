using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckTextCode : MonoBehaviour
{
    public int code;
    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckCorrespondingCode()
    {
        int enteredCode = int.Parse(inputField.text.ToString());
        if (enteredCode == code)
        {
            Debug.Log("bon code");
        }
        else Debug.Log("mauvais code");
    }
}
