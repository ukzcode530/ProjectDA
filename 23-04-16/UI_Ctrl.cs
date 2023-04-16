using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ctrl : MonoBehaviour
{
   
    public GameObject fpsctrl;
   
    void Start()
    {
        fpsctrl = GameObject.FindGameObjectWithTag("Player");
        Cursor.visible = true;
        fpsctrl.GetComponent<FirstPersonController>().enabled = false;
    }

   
    void Update()
    {
     
    }
}
