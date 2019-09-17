using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class THE_TEST_SCRIPT : Interactable
{

    Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DropAll();
    }

    protected override void OnAttachedToHand(Hand hand)
    {
        
    }

    public void DropAll()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("detach all");
            while (hand.AttachedObjects.Count > 0)
            {
                hand.DetachObject(hand.AttachedObjects[0].attachedObject);
            }
        }
    }
}
