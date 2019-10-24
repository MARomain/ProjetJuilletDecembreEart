using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    //buttons
    public Color baseColor = Color.white;
    public Color selectedColor = Color.yellow;

    private GameObject[] mainButtons;
    private Image[] mainButtonsImages;
    private Image selectedButton;

    //background
    public Image backgroundImage;

    private GameObject[] backgrounds;


    private bool doOnce = true;

    

    private void Start()
    {
        GetReferences();
    }

    public void ChangeOnClick()
    {
        ResetButtonsColor();
        SwapColor();
        SwapBgImage();
        

    }

    

    public void SwapBgImage()
    {

        //disable all bg 
        foreach (GameObject bg in backgrounds)
        {
            bg.SetActive(false);
        }

        backgroundImage.gameObject.SetActive(true);
    }

    public void SwapColor()
    {
        selectedButton = this.gameObject.GetComponent<Image>();
        selectedButton.color = selectedColor;
    }

    public void ResetButtonsColor()
    {
        for (int i = 0; i < mainButtons.Length; i++)
        {
            mainButtonsImages[i].color = baseColor;
        }
    }

    private void GetReferences()
    {
        
        if (doOnce == true)
        {
            //get buttons
            mainButtons = GameObject.FindGameObjectsWithTag("MainUIButtons");
            mainButtonsImages = new Image[mainButtons.Length];  //set the size of mainButtonsImages array to the lenght we got with the line above

            for (int i = 0; i < mainButtons.Length; i++)
            {
                mainButtonsImages[i] = mainButtons[i].GetComponent<Image>();
            }

            //get backgrounds
            backgrounds = GameObject.FindGameObjectsWithTag("MainUIBackgrounds");
            

            doOnce = false;
        }

        


    }
}
