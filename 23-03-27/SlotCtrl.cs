using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotCtrl : MonoBehaviour
{
    private Item_posi_initial itemPosiInitial;
    private int menu_num = 0;
    private ItemInventoryManager inventory;
    private GameObject keyObj;

    // Start is called before the first frame update

   

    void Start()
    {
        
        itemPosiInitial = GameObject.FindObjectOfType<Item_posi_initial>();
        keyObj = GameObject.FindWithTag("Key");
        inventory = GameObject.FindObjectOfType<ItemInventoryManager>();
        Debug.Log("Current position: " + transform.position);

        // 현재 객체의 위치 벡터를 반환
        Vector3 currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Menu_Move();
        Mnue_Move_Position();

        if (menu_num == 0)
        {
            itemPosiInitial.MoveToUnvisiblePosition();
            GameObject slot = inventory.slots[0];
            if (slot.transform.childCount > 0)
            {
                Transform child = slot.transform.GetChild(0);
                if (child.gameObject.name == "Itemkey(Clone)")
                {
                    itemPosiInitial.MoveToOriginalPosition();
                }
            }
        }
        if (menu_num ==1)
        {

            itemPosiInitial.MoveToUnvisiblePosition();
            GameObject slot = inventory.slots[1];
            if (slot.transform.childCount > 0)
            {
                Transform child = slot.transform.GetChild(0);
                if (child.gameObject.name == "Itemkey(Clone)")
                {
                    itemPosiInitial.MoveToOriginalPosition();
                }
            }

        }
        if (menu_num == 2)
        {

            itemPosiInitial.MoveToUnvisiblePosition();
           
        }
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
            itemPosiInitial.MoveToUnvisiblePosition();
            menu_num++;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            itemPosiInitial.MoveToUnvisiblePosition();
            menu_num--;
        }

        if (menu_num >= 6)
        {
            
            menu_num = 0;
        }
        else if (menu_num < 0)
        {
            
            menu_num = 5;
        }
    }
}