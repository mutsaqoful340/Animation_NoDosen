using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject buttonAnimation, popUp;
    private Animator animator1, animator2;
    // animator1 > popup
    // animator2 > button

    private void Start()
    {
        animator1 = popUp.GetComponent<Animator>();
        animator2 = buttonAnimation.GetComponent<Animator>();
    }

    public void TS_Laptop()
    {
        animator1.Play("");
    }
}
