using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class objectgrab : Interactable
{
    public bool inHand=false;
    public bool isMagnetic=false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    protected override void OnAttachedToHand(Hand hand)
    {
        inHand = true;
    }

    protected override void OnDetachedFromHand(Hand hand)
    {
        inHand = false;
    }
}
