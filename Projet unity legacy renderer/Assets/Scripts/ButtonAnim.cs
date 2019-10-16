using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonAnim : MonoBehaviour
    {
        public GameObject objectToMove;
        public Animation anim;


        public void OnButtonDown(Hand fromHand)
        {
            anim = objectToMove.GetComponent<Animation>();
            anim.Play();
        }

        public void OnButtonUp(Hand fromHand)
        {

        }
    }
}