using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jauge_red_blink : MonoBehaviour
{
    public Circleprogress circle;
    public Image reddot;
    [Range(0, 99)]
    public int feedbackactive;
    public float alphamax;
    public float alpha;
    public float speedblink;
 
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (circle.puissance < feedbackactive)
        {
          
            alpha = (Mathf.PingPong(Time.time*speedblink, alphamax));
            reddot.color = new Color(reddot.color.r, reddot.color.g, reddot.color.b, alpha);
        }
        else
        {
            reddot.color = new Color(reddot.color.r, reddot.color.g, reddot.color.b, 0);
        }
    }
}
