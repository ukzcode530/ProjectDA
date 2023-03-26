using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemInventory_Ctrl : MonoBehaviour
{
    public GameObject InvenObj;
    private CanvasGroup inventoryCanvasGroup;
    private bool inv_on = false;

    void Start()
    {
        InvenObj = GameObject.Find("Inventory");
        inventoryCanvasGroup = InvenObj.GetComponent<CanvasGroup>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
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
    }
}