using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour
{

    public Sprite[] images;
    public int imageCount = 0;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(imageCount +1 >= images.Length) //please ne sors pas de l'array, c'est pas élégant 
            {

            }
            else
            {
                imageCount++;
                image.sprite = images[imageCount];
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (imageCount -1 < 0) //please ne sors pas de l'array, c'est pas élégant 
            {

            }
            else
            {
                imageCount--;
                image.sprite = images[imageCount];
            }
        }

    }
}
