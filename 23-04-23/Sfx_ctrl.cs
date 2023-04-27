using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sfx_ctrl : MonoBehaviour
{
    public Slider slider;
    public AudioSource asource;
    public GameObject sfxmobj;

    void Start()
    {
        // 오디오 소스 레퍼런스를 가져옵니다.
         sfxmobj = GameObject.Find("SFX_Manager_obj");
        asource = sfxmobj.GetComponent<AudioSource>();
    }

    void Update()
    {
        // 슬라이더 값을 오디오 소스의 볼륨 값으로 설정
        asource.volume = slider.value;
    }
}