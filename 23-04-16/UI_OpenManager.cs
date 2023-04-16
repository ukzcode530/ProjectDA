using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class UI_OpenManager : MonoBehaviour
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
      

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            esc_func();
        }

    }

    private void esc_func()
    {
        Cursor.lockState = CursorLockMode.None;
        UItr_Imgframe.gameObject.SetActive(!UItr_Imgframe.gameObject.activeSelf);
        UItr_Menu.gameObject.SetActive(!UItr_Menu.gameObject.activeSelf);
        Cursor.visible = !Cursor.visible;
        fpsctrl.GetComponent<FirstPersonController>().enabled = !fpsctrl.GetComponent<FirstPersonController>().enabled;
    }
}
