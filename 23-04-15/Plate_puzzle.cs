using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Plate_puzzle : MonoBehaviour
{
    public GameObject fpsctrl;
    public Image imageComponent1;
    public Image imageComponent2;
    public Image imageComponent3;
    public Image imageComponent4;
    public Image imageComponent5;
    public Image imageComponent6;
    public Image imageComponent7;
    public int activeStat = 0;
    private int Slotposition1 = 6;
    private int Slotposition2 = 1;
    private int Slotposition3 = 5;
    private int Slotposition4 = 2;
    private int Slotposition5 = 4;
    private int Slotposition6 = 3;
    private int Slotposition7 = 7;
    public int p_temp = 0;
    public int p_temp2 = 0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;

    [SerializeField]
    private bool doubble_check = false;

    void Start()
    {
        fpsctrl = GameObject.FindGameObjectWithTag("Player");
        fpsctrl.GetComponent<FirstPersonController>().enabled = false;

       
        sprite1 = Resources.Load<Sprite>("puzzle1_rs");
        sprite2 = Resources.Load<Sprite>("puzzle2_rs");
        sprite3 = Resources.Load<Sprite>("puzzle3_rs");
        sprite4 = Resources.Load<Sprite>("puzzle4_rs");
        sprite5 = Resources.Load<Sprite>("puzzle5_rs");
        sprite6 = Resources.Load<Sprite>("puzzle6_rs");
        sprite7 = Resources.Load<Sprite>("puzzle7_rs");

        //imageComponent.sprite = sprite1;

        GameObject imageObject1 = GameObject.Find("Button-slot1");
        GameObject imageObject2 = GameObject.Find("Button-slot2");
        GameObject imageObject3 = GameObject.Find("Button-slot3");
        GameObject imageObject4 = GameObject.Find("Button-slot4");
        GameObject imageObject5 = GameObject.Find("Button-slot5");
        GameObject imageObject6 = GameObject.Find("Button-slot6");
        GameObject imageObject7 = GameObject.Find("Button-slot7");

        imageComponent1 = imageObject1.GetComponent<Image>(); 
        imageComponent2 = imageObject2.GetComponent<Image>();
        imageComponent3 = imageObject3.GetComponent<Image>();
        imageComponent4 = imageObject4.GetComponent<Image>();
        imageComponent5 = imageObject5.GetComponent<Image>();
        imageComponent6 = imageObject6.GetComponent<Image>();
        imageComponent7 = imageObject7.GetComponent<Image>();

    }

    void Update()
    {

        switch(Slotposition1)
        {
            case 1 :
                imageComponent1.sprite = sprite1;
                break;
            case 2:
                imageComponent1.sprite = sprite2;
                break;
            case 3:
                imageComponent1.sprite = sprite3;
                break;
            case 4:
                imageComponent1.sprite = sprite4;
                break;
            case 5:
                imageComponent1.sprite = sprite5;
                break;
            case 6:
                imageComponent1.sprite = sprite6;
                break;
            case 7:
                imageComponent1.sprite = sprite7;
                break;

        }

        switch (Slotposition2)
        {
                    case 1:
                        imageComponent2.sprite = sprite1;
                        break;
                    case 2:
                        imageComponent2.sprite = sprite2;
                        break;
                    case 3:
                        imageComponent2.sprite = sprite3;
                        break;
                    case 4:
                        imageComponent2.sprite = sprite4;
                        break;
                    case 5:
                        imageComponent2.sprite = sprite5;
                        break;
                    case 6:
                        imageComponent2.sprite = sprite6;
                        break;
                    case 7:
                        imageComponent2.sprite = sprite7;
                        break;

                }
                switch (Slotposition3)
                {
                    case 1:
                        imageComponent3.sprite = sprite1;
                        break;
                    case 2:
                        imageComponent3.sprite = sprite2;
                        break;
                    case 3:
                        imageComponent3.sprite = sprite3;
                        break;
                    case 4:
                        imageComponent3.sprite = sprite4;
                        break;
                    case 5:
                        imageComponent3.sprite = sprite5;
                        break;
                    case 6:
                        imageComponent3.sprite = sprite6;
                        break;
                    case 7:
                        imageComponent3.sprite = sprite7;
                        break;

                }
        switch (Slotposition4)
        {
            case 1:
                imageComponent4.sprite = sprite1;
                break;
            case 2:
                imageComponent4.sprite = sprite2;
                break;
            case 3:
                imageComponent4.sprite = sprite3;
                break;
            case 4:
                imageComponent4.sprite = sprite4;
                break;
            case 5:
                imageComponent4.sprite = sprite5;
                break;
            case 6:
                imageComponent4.sprite = sprite6;
                break;
            case 7:
                imageComponent4.sprite = sprite7;
                break;

        }
        switch (Slotposition5)
        {
            case 1:
                imageComponent5.sprite = sprite1;
                break;
            case 2:
                imageComponent5.sprite = sprite2;
                break;
            case 3:
                imageComponent5.sprite = sprite3;
                break;
            case 4:
                imageComponent5.sprite = sprite4;
                break;
            case 5:
                imageComponent5.sprite = sprite5;
                break;
            case 6:
                imageComponent5.sprite = sprite6;
                break;
            case 7:
                imageComponent5.sprite = sprite7;
                break;

        }

        switch (Slotposition6)
        {
            case 1:
                imageComponent6.sprite = sprite1;
                break;
            case 2:
                imageComponent6.sprite = sprite2;
                break;
            case 3:
                imageComponent6.sprite = sprite3;
                break;
            case 4:
                imageComponent6.sprite = sprite4;
                break;
            case 5:
                imageComponent6.sprite = sprite5;
                break;
            case 6:
                imageComponent6.sprite = sprite6;
                break;
            case 7:
                imageComponent6.sprite = sprite7;
                break;

        }

        switch (Slotposition7)
        {
            case 1:
                imageComponent7.sprite = sprite1;
                break;
            case 2:
                imageComponent7.sprite = sprite2;
                break;
            case 3:
                imageComponent7.sprite = sprite3;
                break;
            case 4:
                imageComponent7.sprite = sprite4;
                break;
            case 5:
                imageComponent7.sprite = sprite5;
                break;
            case 6:
                imageComponent7.sprite = sprite6;
                break;
            case 7:
                imageComponent7.sprite = sprite7;
                break;

        }


        Cursor.visible = true;
    }

    public void exitfunc()
    {
        Cursor.visible = false;
        fpsctrl.GetComponent<FirstPersonController>().enabled = true;
    }

    public void selected_func1()
    {
        if (activeStat > 0 && doubble_check == true)
        {
            doubble_check = false;
            p_temp2 = Slotposition1;
            Slotposition1 = p_temp;
            Invoke("All_button_initial", 0.5f);
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;

                    break;
                case 2:
                    Slotposition2 = p_temp2;

                    break;
                case 3:
                    Slotposition3 = p_temp2;

                    break;
                case 4:
                    Slotposition4 = p_temp2;

                    break;
                case 5:
                    Slotposition5 = p_temp2;

                    break;
                case 6:
                    Slotposition6 = p_temp2;

                    break;
                case 7:
                    Slotposition7 = p_temp2;

                    break;
            }



        }


        if (activeStat < 1)
        {
            p_temp = Slotposition1;
    // 이미지 컴포넌트의 색상을 빨간색으로 변경합니다.
    imageComponent1.color = Color.red;
            activeStat = 1;
            doubble_check = true;
        }

       
    }
    public void selected_func2()
    {

        if (activeStat > 0 && doubble_check == true)
        {
            doubble_check = false;
            p_temp2 = Slotposition2;
            Slotposition2 = p_temp;
            Invoke("All_button_initial", 0.5f);
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;

                    break;
                case 2:
                    Slotposition2 = p_temp2;

                    break;
                case 3:
                    Slotposition3 = p_temp2;

                    break;
                case 4:
                    Slotposition4 = p_temp2;

                    break;
                case 5:
                    Slotposition5 = p_temp2;

                    break;
                case 6:
                    Slotposition6 = p_temp2;

                    break;
                case 7:
                    Slotposition7 = p_temp2;

                    break;
            }



        }


        if (activeStat < 1)
        {
            p_temp = Slotposition2;
            // 이미지 컴포넌트의 색상을 빨간색으로 변경합니다.
            imageComponent2.color = Color.red;
            activeStat = 1;
            doubble_check = true;
        }


    }
    public void selected_func3()
    {
        if (activeStat < 1)
        {
            p_temp = Slotposition3;
            imageComponent3.color = Color.red;
            activeStat = 3;
        }

        if (activeStat > 0)
        {
            p_temp2 = Slotposition3;
            Slotposition3 = p_temp;
 
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;
                    break;
                case 2:
                    Slotposition2 = p_temp2;
                    break;
                case 3:
                    Slotposition3 = p_temp2;
                    break;
                case 4:
                    Slotposition4 = p_temp2;
                    break;
                case 5:
                    Slotposition5 = p_temp2;
                    break;
                case 6:
                    Slotposition6 = p_temp2;
                    break;
                case 7:
                    Slotposition7 = p_temp2;
                    break;
            }

           
           
        }

    }
    public void selected_func4()
    {
        if (activeStat < 1)
        {
            p_temp = Slotposition4;
            imageComponent4.color = Color.red;
            activeStat = 4;
        }

        if (activeStat > 0)
        {
            p_temp2 = Slotposition4;
            Slotposition4 = p_temp;
      
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;
                    break;
                case 2:
                    Slotposition2 = p_temp2;
                    break;
                case 3:
                    Slotposition3 = p_temp2;
                    break;
                case 4:
                    Slotposition4 = p_temp2;
                    break;
                case 5:
                    Slotposition5 = p_temp2;
                    break;
                case 6:
                    Slotposition6 = p_temp2;
                    break;
                case 7:
                    Slotposition7 = p_temp2;
                    break;
            }

           
          
        }

    }
    public void selected_func5()
    {
        if (activeStat < 1)
        {
            p_temp = Slotposition5;
            imageComponent5.color = Color.red;
            activeStat = 5;
        }

        if (activeStat > 0)
        {
            p_temp2 = Slotposition5;
            Slotposition5 = p_temp;
        
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;
                    break;
                case 2:
                    Slotposition2 = p_temp2;
                    break;
                case 3:
                    Slotposition3 = p_temp2;
                    break;
                case 4:
                    Slotposition4 = p_temp2;
                    break;
                case 5:
                    Slotposition5 = p_temp2;
                    break;
                case 6:
                    Slotposition6 = p_temp2;
                    break;
                case 7:
                    Slotposition7 = p_temp2;
                    break;
            }

        
          
        }

    }
    public void selected_func6()
    {
        if (activeStat < 1)
        {
            p_temp = Slotposition6;
            imageComponent6.color = Color.red;
            activeStat = 6;
        }

        if (activeStat > 0)
        {
            p_temp2 = Slotposition6;
            Slotposition6 = p_temp;
       
            switch (activeStat)
            {
                case 1:
                    Slotposition1 = p_temp2;
                    break;
                case 2:
                    Slotposition2 = p_temp2;
                    break;
                case 3:
                    Slotposition3 = p_temp2;
                    break;
                case 4:
                    Slotposition4 = p_temp2;
                    break;
                case 5:
                    Slotposition5 = p_temp2;
                    break;
                case 6:
                    Slotposition6 = p_temp2;
                    break;
                case 7:
                    Slotposition7 = p_temp2;
                    break;
            }

           
           
        }

    }
    public void selected_func7()
    {
        if (activeStat < 1)
        {
            p_temp = Slotposition7;
            imageComponent7.color = Color.red;
            activeStat = 7;
        }

           if(activeStat > 0)
        {
            p_temp2 = Slotposition7;
            Slotposition7 = p_temp;
         
            switch (activeStat)
            {
                case 1:
                 Slotposition1  = p_temp2;
                    break;
                case 2:
                 Slotposition2 = p_temp2;
                    break;
                case 3:
                 Slotposition3 = p_temp2;
                    break;
                case 4:
                 Slotposition4 = p_temp2;
                    break;
                case 5:
                 Slotposition5 = p_temp2;
                    break;
                case 6:
                 Slotposition6 = p_temp2;
                    break;
                case 7:
                 Slotposition7 = p_temp2;
                    break;
            }

          
           
        }
       
    }

    public void All_button_initial()
    {
        activeStat = 0;
        p_temp = 0;
        p_temp2 = 0;
        doubble_check = false;
        imageComponent1.color = Color.white;
        imageComponent2.color = Color.white;
        imageComponent3.color = Color.white;
        imageComponent4.color = Color.white;
        imageComponent5.color = Color.white;
        imageComponent6.color = Color.white;
        imageComponent7.color = Color.white;
    }

}