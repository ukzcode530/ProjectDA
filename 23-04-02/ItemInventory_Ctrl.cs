using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ItemInventory_Ctrl : MonoBehaviour
{
    public GameObject InvenObj;
    private CanvasGroup inventoryCanvasGroup;
    public bool inv_on = false;
    public bool ispaused;
  

    void Start()
    {
        InvenObj = GameObject.Find("Inventory");
        inventoryCanvasGroup = InvenObj.GetComponent<CanvasGroup>();
     
       

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Pause_func();
            if (inv_on == false)
            {
                inventoryCanvasGroup.alpha = 1f;
                inventoryCanvasGroup.interactable = true;
                inventoryCanvasGroup.blocksRaycasts = true;
                inv_on = true;
            }
            else if (inv_on == true)
            {
                inventoryCanvasGroup.alpha = 0f;
                inventoryCanvasGroup.interactable = false;
                inventoryCanvasGroup.blocksRaycasts = false;
                inv_on = false;
            }
           
        }

        if (inv_on == true && Input.GetMouseButtonDown(0))
        {
            Pause_func();
            inventoryCanvasGroup.alpha = 0f;
            inventoryCanvasGroup.interactable = false;
            inventoryCanvasGroup.blocksRaycasts = false;
            inv_on = false;

        }
    }

    public void Pause_func()
    {
        ispaused = !ispaused;
        Time.timeScale = (ispaused) ? 0.0f : 1.0f;
        GameObject fpsController = GameObject.FindGameObjectWithTag("Player"); // FPSController 오브젝트 찾기
        fpsController.GetComponent<FirstPersonController>().enabled = !ispaused; // FirstPersonController 스크립트 비활성화


    }
}