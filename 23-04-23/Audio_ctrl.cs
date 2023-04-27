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
        // 오디오 소스 레퍼런스를 가져옵니다.
        Audio_Manager_obj = GameObject.Find("Audio_Manager_obj");
        asource = Audio_Manager_obj.GetComponent<AudioSource>();
 

      
      
    }

    void Update()
    {
        // 슬라이더 값을 오디오 소스의 볼륨 값으로 설정
        asource.volume = slider.value;
    }
}