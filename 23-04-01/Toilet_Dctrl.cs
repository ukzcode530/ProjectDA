using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet_Dctrl : MonoBehaviour
{
    private Animator doorAnim;

    public bool doorOpen = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }


    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("T_door_open", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnim.Play("T_door_close", 0, 0.0f);
            doorOpen = false;
        }
    }
}