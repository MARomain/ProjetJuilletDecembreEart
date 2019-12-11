using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonAnim : MonoBehaviour
    {
        public GameObject objectToMove;
        public Animator animator;
        public bool open = false;

        private void Start()
        {
            open = false;
        }

        public void OnButtonDown(Hand fromHand)
        {
            if (open == true)
            {
                animator.SetBool("open", true);
                open = false;
            }
            else
            {
                animator.SetBool("open", false);
                open = true;
            }

        }

        public void OnButtonUp(Hand fromHand)
        {

        }
    }
}