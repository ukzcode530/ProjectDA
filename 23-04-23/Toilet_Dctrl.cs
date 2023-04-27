using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet_Dctrl : MonoBehaviour
{
    private Animator doorAnim;
    private SFX_scr sfxscr;

    public bool doorOpen = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
        GameObject SfxMobj = GameObject.FindGameObjectWithTag("Sfxm");
        sfxscr = SfxMobj.GetComponent<SFX_scr>();
    }


    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            sfxscr.Door_Opensound_play();
            doorAnim.Play("T_door_open", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            sfxscr.Door_Opensound_play();
            doorAnim.Play("T_door_close", 0, 0.0f);
            doorOpen = false;
        }
    }
}