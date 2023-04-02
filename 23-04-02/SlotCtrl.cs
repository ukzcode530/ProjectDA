using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SlotCtrl : MonoBehaviour
{
    private int menu_num = 0;
    private ItemInventoryManager inventory;

    private ItemInventory_Ctrl ictrl;
    private PlayerItemCtrl pctrl;

    public Item_posi_initial flashlightScript;
    public Item_posi_initial batteryScript;
    public Item_posi_initial keyScript;
    public Item_posi_initial crowbarScript;
    public Item_posi_initial tapeScript;

    public int Item_state = 0;
    // 아이템 STate 에따라  아이템트리거 판별
    // 0. 아무것도없음
    // 1. 배터리
    // 2. 손전등
    // 3. 열쇠 
    // 4. 크로우바
    // 5. 테이프

    // Start is called before the first frame update



    void Start()
    {
      

        ictrl = GameObject.FindObjectOfType<ItemInventory_Ctrl>();
        pctrl = GameObject.FindObjectOfType<PlayerItemCtrl>();

        GameObject keyObject = GameObject.FindWithTag("IKey"); 
        GameObject flashlightObject = GameObject.FindWithTag("IFlash");
        GameObject batteryObject = GameObject.FindWithTag("IBattery");
        GameObject crowbarObject = GameObject.FindWithTag("ICrowbar");
        GameObject tapeObject = GameObject.FindWithTag("ITape");


        keyScript = keyObject.GetComponent<Item_posi_initial>();
        batteryScript = batteryObject.GetComponent<Item_posi_initial>();
        flashlightScript = flashlightObject.GetComponent<Item_posi_initial>();
        crowbarScript = crowbarObject.GetComponent<Item_posi_initial>();
        tapeScript = tapeObject.GetComponent<Item_posi_initial>();

        inventory = GameObject.FindObjectOfType<ItemInventoryManager>();
        Debug.Log("Current position: " + transform.position);

        // 현재 객체의 위치 벡터를 반환
        Vector3 currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 특수한 이벤트용.배터리 + 손전등 얻었을경우 인벤토리에서 두 아이템을 제거하는 코드.
        for (int idx = 0; idx < inventory.slots.Length; idx++)       // 슬롯의 idx를 모두반환하여 탐색
        {
            GameObject slot = inventory.slots[idx];         // slot 게임오브젝트에  인벤토리 슬롯의 해당값을 1~6까지 모두 탐색 반환

            if (slot.transform.childCount > 0)          // Slot이 0이 아닌 1 즉 True일때 (슬롯이 차있다면)
            {
                Transform child = slot.transform.GetChild(0);        // 슬롯안에 아이템 값(child) child로 
                if (pctrl.Flight_combine >= 2)    // 배터리,손전등을 둘다 얻었을경우
                {
                    if (child.gameObject.name == "Itembattery(Clone)" || child.gameObject.name == "Itemflash(Clone)")
                    {
                        Destroy(child.gameObject); 
                        All_ITEM_Initailize();
                    }
                }


            }

        }

       

        if (ictrl.inv_on == true)
        {
            Menu_Move();
            Mnue_Move_Position();

            if (menu_num == 0)
            {
                All_ITEM_Initailize();
                GameObject slot = inventory.slots[0];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    { 
                       flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }

                }
            }
            if (menu_num == 1)
            {


                GameObject slot = inventory.slots[1];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }

            }
            if (menu_num == 2)
            {

                GameObject slot = inventory.slots[2];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }
            }
            if (menu_num == 3)
            {


                GameObject slot = inventory.slots[3];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }
            }
            if (menu_num == 4)
            {


                GameObject slot = inventory.slots[4];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }
            }
            if (menu_num == 5)
            {


                GameObject slot = inventory.slots[5];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }
            }
            if (menu_num == 6)
            {


                GameObject slot = inventory.slots[6];
                if (slot.transform.childCount > 0)
                {
                    Transform child = slot.transform.GetChild(0);
                    if (child.gameObject.name == "Itemkey(Clone)")
                    {
                        keyScript.MoveToOriginalPosition();
                        Item_state = 3;
                    }
                    if (child.gameObject.name == "Itembattery(Clone)")
                    {
                        batteryScript.MoveToOriginalPosition();
                        Item_state = 1;
                    }
                    if (child.gameObject.name == "Itemflash(Clone)")
                    {
                        flashlightScript.MoveToOriginalPosition();
                        Item_state = 2;
                    }
                    if (child.gameObject.name == "Itemcrowbar(Clone)")
                    {
                        crowbarScript.MoveToOriginalPosition();
                        Item_state = 4;
                    }
                    if (child.gameObject.name == "Itemtape(Clone)")
                    {
                        tapeScript.MoveToOriginalPosition();
                        Item_state = 5;
                    }
                }
            }

        }

    }

    public void Key_Use_Destroy()
    {
        for (int idx = 0; idx < inventory.slots.Length; idx++)       // 슬롯의 idx를 모두반환하여 탐색
        {
            GameObject slot = inventory.slots[idx];         // slot 게임오브젝트에  인벤토리 슬롯의 해당값을 1~6까지 모두 탐색 반환

            if (slot.transform.childCount > 0)          // Slot이 0이 아닌 1 즉 True일때 (슬롯이 차있다면)
            {
                Transform child = slot.transform.GetChild(0);        // 슬롯안에 아이템 값(child) child로 
                if (child.gameObject.name == "Itemkey(Clone)")
                {
                    Destroy(child.gameObject);
                    All_ITEM_Initailize();
                }

            }

        }
    }

    public void Crow_Use_Destroy()
    {
        for (int idx = 0; idx < inventory.slots.Length; idx++)       // 슬롯의 idx를 모두반환하여 탐색
        {
            GameObject slot = inventory.slots[idx];         // slot 게임오브젝트에  인벤토리 슬롯의 해당값을 1~6까지 모두 탐색 반환

            if (slot.transform.childCount > 0)          // Slot이 0이 아닌 1 즉 True일때 (슬롯이 차있다면)
            {
                Transform child = slot.transform.GetChild(0);        // 슬롯안에 아이템 값(child) child로 
                if (child.gameObject.name == "Itemcrowbar(Clone)")
                {
                    Destroy(child.gameObject);
                    All_ITEM_Initailize();
                }

            }

        }
    }
    public void Tape_Use_Destroy()
    {
        for (int idx = 0; idx < inventory.slots.Length; idx++)       // 슬롯의 idx를 모두반환하여 탐색
        {
            GameObject slot = inventory.slots[idx];         // slot 게임오브젝트에  인벤토리 슬롯의 해당값을 1~6까지 모두 탐색 반환

            if (slot.transform.childCount > 0)          // Slot이 0이 아닌 1 즉 True일때 (슬롯이 차있다면)
            {
                Transform child = slot.transform.GetChild(0);        // 슬롯안에 아이템 값(child) child로 
                if (child.gameObject.name == "Itemtape(Clone)")
                {
                    Destroy(child.gameObject);
                    All_ITEM_Initailize();
                }

            }

        }
    }



    private void All_ITEM_Initailize()
    {
        Item_state = 0;
        keyScript.MoveToUnvisiblePosition();
        flashlightScript.MoveToUnvisiblePosition();
        batteryScript.MoveToUnvisiblePosition();
        crowbarScript.MoveToUnvisiblePosition();
        tapeScript.MoveToUnvisiblePosition();
    }

    private void Mnue_Move_Position()
    {
        switch (menu_num)
        {
            case 0:
                transform.position = new Vector3(68, 75, 0);
                break;
            case 1:
                transform.position = new Vector3(168, 75, 0);
                break;
            case 2:
                transform.position = new Vector3(268, 75, 0);
                break;
            case 3:
                transform.position = new Vector3(368, 75, 0);
                break;
            case 4:
                transform.position = new Vector3(468, 75, 0);
                break;
            case 5:
                transform.position = new Vector3(568, 75, 0);
                break;
        }
    }

    private void Menu_Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            All_ITEM_Initailize();
            menu_num++;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            All_ITEM_Initailize();
            menu_num--;
        }

        if (menu_num >= 6)
        {
            All_ITEM_Initailize();
            menu_num = 0;
        }
        else if (menu_num < 0)
        {
            All_ITEM_Initailize();
            menu_num = 5;
        }
    }
}