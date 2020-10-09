using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public GameObject target;
    public bool abled = false;
    Animator[] animators;

    private void Start()
    {
            animators = GetComponentsInChildren<Animator>();
    }

    private void OnMouseOver()
    {
        foreach (Animator animator in animators) {
            animator.SetBool("mouse", true);
        }
    }

    private void OnMouseExit()
    {
        foreach (Animator animator in animators)
        {
            animator.SetBool("mouse", false);
        }
    }

    private void OnMouseDown()
    {
        if (target.GetComponent<Machine>().abled == true)
        {
            foreach (Animator animator in animators)
            {
                animator.SetBool("abled", true);
            }
            abled = true;
        }
    }

}
