using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemCtrl : MonoBehaviour
{
    public Text itemtext;
    private Transform thisTr;
    private GameObject antlersObj;
    private Doorcontroller doorController1;
    private Doorcontroller doorController2;
    private GameManager manager;
    public GameObject InvenObj;
    public GameObject itemPrefab;
    private ItemInventoryManager inventory; // 인벤토리 매니저 스크립트
    private CanvasGroup inventoryCanvasGroup;

    private void Awake()
    {
        InvenObj = GameObject.Find("Inventory");
        InvenObj.SetActive(true);
    }

    void Start()
    {
       
        thisTr = GetComponent<Transform>();
        antlersObj = GameObject.Find("Antlers");
        GameObject doorObj1 = GameObject.FindGameObjectWithTag("Door1");
        GameObject doorObj2 = GameObject.FindGameObjectWithTag("Door2");
        doorController1 = doorObj1.GetComponent<Doorcontroller>();
        doorController2 = doorObj2.GetComponent<Doorcontroller>();
        itemtext = GameObject.Find("Canvas").transform.GetChild(1).GetComponent<Text>();
        InvenObj = GameObject.Find("Inventory");
        inventoryCanvasGroup = InvenObj.GetComponent<CanvasGroup>();
        inventory = GameObject.Find("Inventory").GetComponent<ItemInventoryManager>();
        inventoryCanvasGroup.alpha = 0f;   // 시작시 알파값으로 UI를 조절
        inventoryCanvasGroup.interactable = false; // 시작시 알파값이 투명임과 동시에 조작도 off
        inventoryCanvasGroup.blocksRaycasts = false; // 시작시 알파값이 투명임과 동시에 조작도 off
        itemPrefab = Resources.Load<GameObject>("Prefebs/Itemkey");
        if (itemPrefab == null)
        {
            Debug.LogError("Item prefab not found at path: Prefebs/Itemkey");
        }


    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

   
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;

                if (obj.CompareTag("Test"))
                {
                    antlersObj.SetActive(false);
                    if (inventory != null && inventory.slots != null)
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            if (inventory.fullCheck[i] == false)
                            {
                                inventory.fullCheck[i] = true;
                                Instantiate(itemPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }
                }
                else if (obj.CompareTag("Door1"))
                {
                    doorController1.PlayAnimation();
                }
                else if (obj.CompareTag("Door2"))
                {
                    doorController2.PlayAnimation();
                }
            }
            Debug.DrawRay(thisTr.position, thisTr.forward * 15f, Color.green);

        }

        if (Physics.Raycast(ray, out hit))
            {
            // 충돌된 오브젝트의 태그로 UI 텍스트 갱신
            if (hit.collider.gameObject.CompareTag("Test"))
            {
                itemtext.text = "잡동사니[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Door1") || hit.collider.gameObject.CompareTag("Door2"))
            {
                itemtext.text = "문[Mouse Left]";
            }
            else
            {
                itemtext.text = "";
            }
            }
            else
            {
                itemtext.text = "";
            }
        }
      

   

      
    
}