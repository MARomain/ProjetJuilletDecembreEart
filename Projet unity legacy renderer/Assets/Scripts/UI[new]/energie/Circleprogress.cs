using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circleprogress : MonoBehaviour
{
    public bool glitch;
    public Animator animator;
    public Animator cerlerint;
    public Animator cerleext;
    public GameObject messagederreur;
    [Range(0, 99)]
    public int puissance;
    public Text valuetext;
    public string bugtext;
    public Image energiecenter;
    public Sprite energienormal;
    public Sprite energieglitch;

    void Update()
    {
        if (glitch == false)
        {
            energiecenter.sprite = energienormal;
            cerleext.SetBool("glitch", false);
            animator.SetFloat("Frame", puissance * (0.01f));
            if (puissance != 0)
            {
                valuetext.text = (puissance + 1) + "%".ToString();
            }
            else
            {
                valuetext.text = puissance + "%".ToString();
            }
            if (puissance == 99)
            {
                cerleext.enabled = true;
                cerlerint.enabled = true;
                messagederreur.SetActive(false);
            }
            else
            {
                cerleext.enabled = false;
                cerlerint.enabled = false;
                messagederreur.SetActive(true);
            }
        }
        else
        {
            //glithc
            valuetext.text = bugtext ;
            cerleext.SetBool("glitch", true);
            cerlerint.enabled = false;
            energiecenter.sprite = energieglitch;
        }
   

    
    }
   
}
