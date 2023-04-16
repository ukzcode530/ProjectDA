using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class UI_Button : MonoBehaviour
{
    public Transform UItr_Imgframe;
    public Transform UItr_Menu;
    private GameObject UIObj;
    public GameObject fpsctrl;


    void Start()
    {
        UIObj = GameObject.Find("Canvas-UI");
        UItr_Imgframe = UIObj.transform.GetChild(0);
        UItr_Menu = UIObj.transform.GetChild(1);
        fpsctrl = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {



    }


    public void Resume_func()
    {
      
        UItr_Imgframe.gameObject.SetActive(false) ;
      
        UItr_Menu.gameObject.SetActive(false);
     
 
       
        fpsctrl.GetComponent<FirstPersonController>().enabled = true;
       



    }
}
