using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDoorcontroller1 : MonoBehaviour
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
            doorAnim.Play("S_door_open_Right", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            sfxscr.Door_Opensound_play();
            doorAnim.Play("S_door_cose_Right", 0, 0.0f);
            doorOpen = false;
        }
    }
}