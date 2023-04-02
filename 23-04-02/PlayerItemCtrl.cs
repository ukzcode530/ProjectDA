using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerItemCtrl : MonoBehaviour
{
    public Text itemtext;
    private Transform thisTr;
    private GameObject antlersObj;
    private GameObject PaperObj_0;
    private GameObject keyObj_0;
    private GameObject flightObj;
    private GameObject batteryObj;
    private GameObject crowbarobj;
    private GameObject LockerDoor;
    private GameObject tapeObj;

    private SlotCtrl sctrl;
    private GameObject itemObj; // Item_obj 오브젝트를 참조할 GameObject 변수를 선언합니다.
    private Transform prfKey01; // prf_key_01 오브젝트를 참조할 Transform 변수를 선언합니다.
    private Transform prfCrw;
    public bool Washroom_Door_Loock = false;
    public int Flight_combine;

    //**********************Door Controller
    private Doorcontroller doorController1;
    private Doorcontroller doorController2;
    private Doorcontroller doorController3;
    private Doorcontroller doorController4;
    private Doorcontroller doorController5;
    private Doorcontroller doorController6;
    private Doorcontroller doorController7;
    private Doorcontroller doorController8;
    private Doorcontroller doorController9;
    private Doorcontroller doorController10;
    private SDoorcontroller1 doorController_S_1;
    private Doorcontroller doorController12;
    private Doorcontroller doorController13;
    private Doorcontroller doorController14;
    private Doorcontroller doorController15;
    private Doorcontroller doorController16;
    private Doorcontroller doorController17;
    private Doorcontroller doorController18;
    private Doorcontroller doorController19;
    private Doorcontroller doorController20;
    private SDoorcontroller1 doorController21;
    private Doorcontroller doorController22;

    //**********************Toile Door Controller
    private Toilet_Dctrl Tdoorctrl1;
    private Toilet_Dctrl Tdoorctrl2;
    private Toilet_Dctrl Tdoorctrl3;
    private Toilet_Dctrl Tdoorctrl4;
    private Toilet_Dctrl Tdoorctrl5;
    private Toilet_Dctrl Tdoorctrl6;
    private Toilet_Dctrl Tdoorctrl7;
    private Toilet_Dctrl Tdoorctrl8;
    private Toilet_Dctrl Tdoorctrl9;
    private Toilet_Dctrl Tdoorctrl10;
    private Toilet_Dctrl Tdoorctrl11;
    private Toilet_Dctrl Tdoorctrl12;
    private Toilet_Dctrl Tdoorctrl13;
    private Toilet_Dctrl Tdoorctrl14;
    private Toilet_Dctrl Tdoorctrl15;

    //**********************end
    private GameManager manager;
    public GameObject InvenObj;
    public GameObject KeyPrefab;
    public GameObject FlashPrefab;
    public GameObject BatteryPrefab;
    public GameObject CrowbarPrefab;
    public GameObject TapePrefab;

    private ItemInventoryManager inventory; // 인벤토리 매니저 스크립트
    private CanvasGroup inventoryCanvasGroup;
    private FirstPersonController fpscon;

    private void Awake()
    {
        InvenObj = GameObject.Find("Inventory");
        InvenObj.SetActive(true);
    }

    void Start()
    {
      
        sctrl = GameObject.FindObjectOfType<SlotCtrl>();
        thisTr = GetComponent<Transform>();
        tapeObj = GameObject.Find("tape_01");
        antlersObj = GameObject.Find("Antlers");
        LockerDoor = GameObject.Find("Case_Door_R_S");
        PaperObj_0 = GameObject.Find("PaperObj0");
        keyObj_0 = GameObject.Find("prf_key_01");
        flightObj = GameObject.Find("Flashlight");
        batteryObj = GameObject.Find("PRFB-Battery-AA");
        crowbarobj = GameObject.Find("crowbar");
        itemObj = GameObject.Find("Item_obj"); // Item_obj 오브젝트를 참조하여 itemObj 변수에 할당합니다.
        prfKey01 = itemObj.transform.GetChild(17); // Item_obj 오브젝트의 17번째 자식 오브젝트를 참조하여 prfKey01 변수에 할당합니다. (인덱스는 0부터 시작합니다)
        prfCrw = itemObj.transform.GetChild(7);

        // ******* Door Controller*******************//
        GameObject doorObj1 = GameObject.FindGameObjectWithTag("Door1");
        GameObject doorObj2 = GameObject.FindGameObjectWithTag("Door2");
        GameObject doorObj3 = GameObject.FindGameObjectWithTag("Door3");
        GameObject doorObj4 = GameObject.FindGameObjectWithTag("Door4");
        GameObject doorObj5 = GameObject.FindGameObjectWithTag("Door5");
        GameObject doorObj6 = GameObject.FindGameObjectWithTag("Door6");
        GameObject doorObj7 = GameObject.FindGameObjectWithTag("Door7");
        GameObject doorObj8 = GameObject.FindGameObjectWithTag("Door8");
        GameObject doorObj9 = GameObject.FindGameObjectWithTag("Door9");
        GameObject doorObj10 = GameObject.FindGameObjectWithTag("Door10");
        GameObject doorObj11 = GameObject.FindGameObjectWithTag("Door11");
        GameObject doorObj12 = GameObject.FindGameObjectWithTag("Door12");
        GameObject doorObj13 = GameObject.FindGameObjectWithTag("Door13");
        GameObject doorObj14 = GameObject.FindGameObjectWithTag("Door14");
        GameObject doorObj15 = GameObject.FindGameObjectWithTag("Door15");
        GameObject doorObj16 = GameObject.FindGameObjectWithTag("Door16");
        GameObject doorObj17 = GameObject.FindGameObjectWithTag("Door17");
        GameObject doorObj18 = GameObject.FindGameObjectWithTag("Door18");
        GameObject doorObj19 = GameObject.FindGameObjectWithTag("Door19");
        GameObject doorObj20 = GameObject.FindGameObjectWithTag("Door20");
        GameObject doorObj21 = GameObject.FindGameObjectWithTag("Door21");
        GameObject doorObj22 = GameObject.FindGameObjectWithTag("Door22");
        // ******* Toilet Door Controller************//
        GameObject Tdoorobj1 = GameObject.FindGameObjectWithTag("Tdoor1");
        GameObject Tdoorobj2 = GameObject.FindGameObjectWithTag("Tdoor2");
        GameObject Tdoorobj3 = GameObject.FindGameObjectWithTag("Tdoor3");
        GameObject Tdoorobj4 = GameObject.FindGameObjectWithTag("Tdoor4");
        GameObject Tdoorobj5 = GameObject.FindGameObjectWithTag("Tdoor5");
        GameObject Tdoorobj6 = GameObject.FindGameObjectWithTag("Tdoor6");
        GameObject Tdoorobj7 = GameObject.FindGameObjectWithTag("Tdoor7");
        GameObject Tdoorobj8 = GameObject.FindGameObjectWithTag("Tdoor8");
        GameObject Tdoorobj9 = GameObject.FindGameObjectWithTag("Tdoor9");
        GameObject Tdoorobj10 = GameObject.FindGameObjectWithTag("Tdoor10");
        GameObject Tdoorobj11 = GameObject.FindGameObjectWithTag("Tdoor11");
        GameObject Tdoorobj12 = GameObject.FindGameObjectWithTag("Tdoor12");
        GameObject Tdoorobj13 = GameObject.FindGameObjectWithTag("Tdoor13");
        GameObject Tdoorobj15 = GameObject.FindGameObjectWithTag("Tdoor15");
        //*************ETC***************************//
        GameObject fpsctrlobj = GameObject.FindGameObjectWithTag("Player");
        // **********Door Controller********************//
        doorController1 = doorObj1.GetComponent<Doorcontroller>();
        doorController2 = doorObj2.GetComponent<Doorcontroller>();
        doorController3 = doorObj3.GetComponent<Doorcontroller>();
        doorController4 = doorObj4.GetComponent<Doorcontroller>();
        doorController5 = doorObj5.GetComponent<Doorcontroller>();
        doorController6 = doorObj6.GetComponent<Doorcontroller>();
        doorController7 = doorObj7.GetComponent<Doorcontroller>();
        doorController8 = doorObj8.GetComponent<Doorcontroller>();
        doorController9 = doorObj9.GetComponent<Doorcontroller>();
        doorController10 = doorObj10.GetComponent<Doorcontroller>();
        doorController_S_1 = doorObj11.GetComponent<SDoorcontroller1>();
        doorController12 = doorObj12.GetComponent<Doorcontroller>();
        doorController13 = doorObj13.GetComponent<Doorcontroller>();
        doorController14 = doorObj14.GetComponent<Doorcontroller>();
        doorController15 = doorObj15.GetComponent<Doorcontroller>();
        doorController16 = doorObj16.GetComponent<Doorcontroller>();
        doorController17 = doorObj17.GetComponent<Doorcontroller>();
        doorController18 = doorObj18.GetComponent<Doorcontroller>();
        doorController19 = doorObj19.GetComponent<Doorcontroller>();
        doorController20 = doorObj20.GetComponent<Doorcontroller>();
        doorController21 = doorObj21.GetComponent<SDoorcontroller1>();
        doorController22 = doorObj22.GetComponent<Doorcontroller>();
        //***************ETC**********************************//
        fpscon = fpsctrlobj.GetComponent<FirstPersonController>();
        //***********Toilet Door Controller*******************//
        Tdoorctrl1 = Tdoorobj1.GetComponent<Toilet_Dctrl>();
        Tdoorctrl2 = Tdoorobj2.GetComponent<Toilet_Dctrl>();
        Tdoorctrl3 = Tdoorobj3.GetComponent<Toilet_Dctrl>();
        Tdoorctrl4 = Tdoorobj4.GetComponent<Toilet_Dctrl>();
        Tdoorctrl5 = Tdoorobj5.GetComponent<Toilet_Dctrl>();
        Tdoorctrl6 = Tdoorobj6.GetComponent<Toilet_Dctrl>();
        Tdoorctrl7 = Tdoorobj7.GetComponent<Toilet_Dctrl>();
        Tdoorctrl8 = Tdoorobj8.GetComponent<Toilet_Dctrl>();
        Tdoorctrl9 = Tdoorobj9.GetComponent<Toilet_Dctrl>();
        Tdoorctrl10 = Tdoorobj10.GetComponent<Toilet_Dctrl>();
        Tdoorctrl11 = Tdoorobj11.GetComponent<Toilet_Dctrl>();
        Tdoorctrl12 = Tdoorobj12.GetComponent<Toilet_Dctrl>();
        Tdoorctrl13 = Tdoorobj13.GetComponent<Toilet_Dctrl>();
        Tdoorctrl15 = Tdoorobj15.GetComponent<Toilet_Dctrl>();
        //****************************************************//

      
        itemtext = GameObject.Find("Canvas").transform.GetChild(1).GetComponent<Text>();
        InvenObj = GameObject.Find("Inventory");
        inventoryCanvasGroup = InvenObj.GetComponent<CanvasGroup>();
        inventory = GameObject.Find("Inventory").GetComponent<ItemInventoryManager>();
        inventoryCanvasGroup.alpha = 0f;   // 시작시 알파값으로 UI를 조절
        inventoryCanvasGroup.interactable = false; // 시작시 알파값이 투명임과 동시에 조작도 off
        inventoryCanvasGroup.blocksRaycasts = false; // 시작시 알파값이 투명임과 동시에 조작도 off
        KeyPrefab = Resources.Load<GameObject>("Prefebs/Itemkey");
        FlashPrefab = Resources.Load<GameObject>("Prefebs/Itemflash");
        BatteryPrefab = Resources.Load<GameObject>("Prefebs/Itembattery");
        CrowbarPrefab = Resources.Load<GameObject>("Prefebs/Itemcrowbar");
        TapePrefab = Resources.Load<GameObject>("Prefebs/Itemtape");


    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

   
        if (Input.GetMouseButtonDown(0))            // if 마우스 왼쪽을 누르면
        {
            if (Physics.Raycast(ray, out hit))      // if 레이캐스트 감지
            {
                GameObject obj = hit.collider.gameObject;

                if (obj.CompareTag("Key"))       //  if  그중 태그를 판별
                {
                    prfKey01.gameObject.SetActive(false);                      //  선택되었으니 오브젝트 아이템 제거
                    if (inventory != null && inventory.slots != null)          //  if 슬롯체크 
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            if (inventory.fullCheck[i] == false)           //  if 슬롯이 비어있으면
                            {
                                inventory.fullCheck[i] = true;        //슬롯을 true로하고, 그슬롯에 아이템 프리팹을 생성.
                                Instantiate(KeyPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }
                }
                //******************************************* 문 22개에 관련한 동작 애니메이션 
                else if (obj.CompareTag("Door1")) doorController1.PlayAnimation();
                else if (obj.CompareTag("Door2")) doorController2.PlayAnimation();
                else if (obj.CompareTag("Door3")) doorController3.PlayAnimation();
                else if (obj.CompareTag("Door4")) doorController4.PlayAnimation();
                else if (obj.CompareTag("Door5")) doorController5.PlayAnimation();
                else if (obj.CompareTag("Door6")) doorController6.PlayAnimation();
                else if (obj.CompareTag("Door7")) doorController7.PlayAnimation();
                else if (obj.CompareTag("Door8"))      // 화장실문. 기본적으로 잠궈져있어야함.
                {
                   
                    if (sctrl.Item_state == 3) 
                    {
                        Washroom_Door_Loock = true;
                        sctrl.Key_Use_Destroy();
                       
                    }

                    if (Washroom_Door_Loock == true)
                    {// 트루일때(열렸을때)
                        doorController8.PlayAnimation();
                    }
                }
                else if (obj.CompareTag("Door9")) doorController9.PlayAnimation();
                else if (obj.CompareTag("Door10")) doorController10.PlayAnimation();
                else if (obj.CompareTag("Door11")) doorController_S_1.PlayAnimation();
                else if (obj.CompareTag("Door12")) doorController12.PlayAnimation();
                else if (obj.CompareTag("Door13")) doorController13.PlayAnimation();
                else if (obj.CompareTag("Door14")) doorController14.PlayAnimation();
                else if (obj.CompareTag("Door15")) doorController15.PlayAnimation();
                else if (obj.CompareTag("Door16")) doorController16.PlayAnimation();
                else if (obj.CompareTag("Door17")) doorController17.PlayAnimation();
                else if (obj.CompareTag("Door18")) doorController18.PlayAnimation();
                else if (obj.CompareTag("Door19")) doorController19.PlayAnimation();
                else if (obj.CompareTag("Door20")) doorController20.PlayAnimation();
                else if (obj.CompareTag("Door21")) doorController21.PlayAnimation();
                else if (obj.CompareTag("Door22")) doorController22.PlayAnimation();
                //*********************************************** 화장실문 관련 동작 애니메이션 
                else if (obj.CompareTag("Tdoor1")) Tdoorctrl1.PlayAnimation();
                else if (obj.CompareTag("Tdoor2")) Tdoorctrl2.PlayAnimation();
                else if (obj.CompareTag("Tdoor3")) Tdoorctrl3.PlayAnimation();
                else if (obj.CompareTag("Tdoor4")) Tdoorctrl4.PlayAnimation();
                else if (obj.CompareTag("Tdoor5")) Tdoorctrl5.PlayAnimation();
                else if (obj.CompareTag("Tdoor6")) Tdoorctrl6.PlayAnimation();
                else if (obj.CompareTag("Tdoor7")) Tdoorctrl7.PlayAnimation();
                else if (obj.CompareTag("Tdoor8")) Tdoorctrl8.PlayAnimation();
                else if (obj.CompareTag("Tdoor9")) Tdoorctrl9.PlayAnimation();
                else if (obj.CompareTag("Tdoor10")) Tdoorctrl10.PlayAnimation();
                else if (obj.CompareTag("Tdoor11")) Tdoorctrl11.PlayAnimation();
                else if (obj.CompareTag("Tdoor12")) Tdoorctrl12.PlayAnimation();
                else if (obj.CompareTag("Tdoor13")) Tdoorctrl13.PlayAnimation();
                else if (obj.CompareTag("Tdoor15")) Tdoorctrl15.PlayAnimation();

                //*******************************************로커

                else if (obj.CompareTag("Locker_S"))
                {
                    if (sctrl.Item_state == 4)
                    {
                        LockerDoor.SetActive(false);
                        sctrl.Crow_Use_Destroy();
                    }
                }

                //*********************************************손전등
                        else if (obj.CompareTag("Flashlight"))
                {
                    Flight_combine += 1;
                    if (Flight_combine >= 2) fpscon.FLight_Get = true;
                    flightObj.SetActive(false);

                    if (inventory != null && inventory.slots != null)          //  if 슬롯체크 
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            if (inventory.fullCheck[i] == false)           //  if 슬롯이 비어있으면
                            {
                                inventory.fullCheck[i] = true;        //슬롯을 true로하고, 그슬롯에 아이템 프리팹을 생성.
                                Instantiate(FlashPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }
                }
                else if (obj.CompareTag("Battery"))
                {
                    Flight_combine += 1;
                    if (Flight_combine >= 2) fpscon.FLight_Get = true;
                    batteryObj.SetActive(false);
                    if (inventory != null && inventory.slots != null)          //  if 슬롯체크 
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            GameObject slot = inventory.slots[i];
                            if (inventory.fullCheck[i] == false)           //  if 슬롯이 비어있으면
                            {

                                inventory.fullCheck[i] = true;        //슬롯을 true로하고, 그슬롯에 아이템 프리팹을 생성.
                                Instantiate(BatteryPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }

                        }
                    }

                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }

                }
                else if (obj.CompareTag("Paper0"))
                {

                    if (Flight_combine >= 2)
                    {
                        PaperObj_0.SetActive(false); 
                        prfKey01.gameObject.SetActive(true);
                    } // 손전등 조건2개 채웠을경우(배터리,손전등)  해당 이벤트발생가능.

                }
                else if (obj.CompareTag("Crowbar"))
                {
                   
                   prfCrw.gameObject.SetActive(false);
                    if (inventory != null && inventory.slots != null)          //  if 슬롯체크 
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            GameObject slot = inventory.slots[i];
                            if (inventory.fullCheck[i] == false)           //  if 슬롯이 비어있으면
                            {

                                inventory.fullCheck[i] = true;        //슬롯을 true로하고, 그슬롯에 아이템 프리팹을 생성.
                                Instantiate(CrowbarPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }

                        }
                    }


                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }

                }
                else if (obj.CompareTag("Tape"))
                {

                    tapeObj.SetActive(false);
                    if (inventory != null && inventory.slots != null)          //  if 슬롯체크 
                    {
                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            GameObject slot = inventory.slots[i];
                            if (inventory.fullCheck[i] == false)           //  if 슬롯이 비어있으면
                            {

                                inventory.fullCheck[i] = true;        //슬롯을 true로하고, 그슬롯에 아이템 프리팹을 생성.
                                Instantiate(TapePrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                                break;
                            }

                        }
                    }


                    else
                    {
                        Debug.LogError("Inventory or Inventory Slots are null.");
                    }

                }
            }
            Debug.DrawRay(thisTr.position, thisTr.forward * 15f, Color.green);

        }

        if (Physics.Raycast(ray, out hit))
        {
            // 충돌된 오브젝트의 태그로 UI 텍스트 갱신
            if (hit.collider.gameObject.CompareTag("Key"))
            {
                itemtext.text = "열쇠[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Door1") || hit.collider.gameObject.CompareTag("Door2") ||
                     hit.collider.gameObject.CompareTag("Door3") || hit.collider.gameObject.CompareTag("Door4") ||
                     hit.collider.gameObject.CompareTag("Door5") || hit.collider.gameObject.CompareTag("Door6") ||
                     hit.collider.gameObject.CompareTag("Door7") || hit.collider.gameObject.CompareTag("Door8") ||
                     hit.collider.gameObject.CompareTag("Door9") || hit.collider.gameObject.CompareTag("Door10") ||
                     hit.collider.gameObject.CompareTag("Door11") || hit.collider.gameObject.CompareTag("Door12") ||
                     hit.collider.gameObject.CompareTag("Door13") || hit.collider.gameObject.CompareTag("Door14") ||
                     hit.collider.gameObject.CompareTag("Door15") || hit.collider.gameObject.CompareTag("Door16") ||
                     hit.collider.gameObject.CompareTag("Door17") || hit.collider.gameObject.CompareTag("Door17") ||
                     hit.collider.gameObject.CompareTag("Door18") || hit.collider.gameObject.CompareTag("Door19") ||
                     hit.collider.gameObject.CompareTag("Door20") || hit.collider.gameObject.CompareTag("Door20") ||
                     hit.collider.gameObject.CompareTag("Door21") || hit.collider.gameObject.CompareTag("Door22"))

            {
                itemtext.text = "문[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Tdoor1") || hit.collider.gameObject.CompareTag("Tdoor2") ||
                     hit.collider.gameObject.CompareTag("Tdoor3") || hit.collider.gameObject.CompareTag("Tdoor4") ||
                     hit.collider.gameObject.CompareTag("Tdoor5") || hit.collider.gameObject.CompareTag("Tdoor5") ||
                     hit.collider.gameObject.CompareTag("Tdoor6") || hit.collider.gameObject.CompareTag("Tdoor7") ||
                     hit.collider.gameObject.CompareTag("Tdoor8") || hit.collider.gameObject.CompareTag("Tdoor9") ||
                     hit.collider.gameObject.CompareTag("Tdoor10") || hit.collider.gameObject.CompareTag("Tdoor11") ||
                     hit.collider.gameObject.CompareTag("Tdoor12") || hit.collider.gameObject.CompareTag("Tdoor13") ||
                     hit.collider.gameObject.CompareTag("Tdoor15"))
            {
                itemtext.text = "화장실문[Mouse Left]";
            }
            else if(hit.collider.gameObject.CompareTag("Flashlight"))
            {
                itemtext.text = "손전등[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Battery"))
            {
                itemtext.text = "건전지[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Paper0"))
            {
                itemtext.text = "메모[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Crowbar"))
            {
                itemtext.text = "지렛대[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Locker_S"))
            {
                itemtext.text = "로커[Mouse Left]";
            }
            else if (hit.collider.gameObject.CompareTag("Tape"))
            {
                itemtext.text = "카세트 테이프[Mouse Left]";
            }
            else
            {
                itemtext.text = "";
            }
        }
        }
      

   

      
    
}