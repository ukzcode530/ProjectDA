using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audio_ctrl : MonoBehaviour
{
    public Slider slider;
    public AudioSource asource;
    public GameObject Audio_Manager_obj;
  

    void Start()
    {
        // ����� �ҽ� ���۷����� �����ɴϴ�.
        Audio_Manager_obj = GameObject.Find("Audio_Manager_obj");
        asource = Audio_Manager_obj.GetComponent<AudioSource>();
 

      
      
    }

    void Update()
    {
        // �����̴� ���� ����� �ҽ��� ���� ������ ����
        asource.volume = slider.value;
    }
}