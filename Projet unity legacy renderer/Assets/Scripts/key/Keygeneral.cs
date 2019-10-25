using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keygeneral : MonoBehaviour
{
    public keyreach keyreach1; //chaque zone de détection de la clef
    public keyreach keyreach2;
    public keyreach keyreach3;
    public keyreach keyreach4;
    public keyreach keyreach5;
    public keyreach keyreach6;
    public keyreach keyreach7;
    public keyreach keyreach8; //chaque zone de détection de la clef

    public bool finished = false; // Pour la progression general du jeu

    public Animator animator; //animation du lock

    public int step=1; //Progrerssion de l'épreuve


    private float badtimemax=0.7f; //temps de lumiere "bad" quand il y a une erreur
    private float badtime; //utile pour le décompte
    public Material lightmat; //j'utilise un material pour les light,changeable
    public Color good; //dans ma tete c'est vert
    public Color bad; // dans ma tete c'est rouge
    private bool red = false; //check si la lumiere "bad" est allumé
 
    // 1 6 5 7 3

    // Update is called once per frame
    public void Inputneedtobecheck() //input de la zone de détexion
    {
    switch (step)
        {
            case 1:
                if (keyreach1.active == true)
                {
                    Debug.Log("good result,step " + step + " complete" +" 16573");//qu'est ce que tu veux,c'est un debug mec
                    Resetallkeyreach();
                    step++;
                    animator.SetInteger("step", step);
                }
                else
                {
                
                    Resetallkeyreach();
                    Failed();
                }
                break;
            case 2:
                if (keyreach6.active == true)
                {
                    Debug.Log("good result,step " + step + " complete" + " 16573");
                    Resetallkeyreach();
                    step++;
                    animator.SetInteger("step", step);
                }
                else
                {
                    Resetallkeyreach();
                    Failed();
                }
                break;
            case 3:
                if (keyreach5.active == true)
                {
                    Debug.Log("good result,step " + step + " complete" + " 16573");
                    Resetallkeyreach();
                    step++;
                    animator.SetInteger("step", step);
                }
                else
                {
                    Resetallkeyreach();
                    Failed();
                }
                break;
            case 4:
                if (keyreach7.active == true)
                {
                    Debug.Log("good result,step " + step + " complete" + " 16573");
                    Resetallkeyreach();
                    step++;
                    animator.SetInteger("step", step);
                }
                else
                {
                    Resetallkeyreach();
                    Failed();
                }
                break;
            case 5:
                if (keyreach3.active == true)
                {
                    Debug.Log("good result,step " + step + " complete" + " 16573");
                    step++;
                    animator.SetInteger("step", step);
                    Resetallkeyreach();
                    keyreach1.thelight.SetActive(true);
                    keyreach2.thelight.SetActive(true);
                    keyreach3.thelight.SetActive(true);
                    keyreach4.thelight.SetActive(true);
                    keyreach5.thelight.SetActive(true);
                    keyreach6.thelight.SetActive(true);
                    keyreach7.thelight.SetActive(true);
                    keyreach8.thelight.SetActive(true);
                    finished = true;
                    Debug.Log("end");
                }
                else
                {
                    Resetallkeyreach();
                    Failed();
                }
                break;
       

        }
    }
    public void Resetallkeyreach() //remet a zero
    {
        keyreach1.active = false;
        keyreach2.active = false;
        keyreach3.active = false;
        keyreach4.active = false;
        keyreach5.active = false;
        keyreach6.active = false;
        keyreach7.active = false;
        keyreach8.active = false;
    }
    public void Failed()
    {
        Debug.Log("back to the first step");
        badtime = badtimemax;
        lightmat.SetColor("_EmissionColor", bad);
        red = true;
        step = 1;
        animator.SetInteger("step", step);
    }
    private void Update()
    {
        if (red == true)
        {

            if (badtime <= 0)
            {
                red = false;
                lightmat.SetColor("_EmissionColor", good);
            }
            else
            {
                badtime = badtime - Time.deltaTime;
            }
          

        }
    }
}
