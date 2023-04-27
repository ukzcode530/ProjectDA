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
        // ����� �ҽ� ���۷����� �����ɴϴ�.
         sfxmobj = GameObject.Find("SFX_Manager_obj");
        asource = sfxmobj.GetComponent<AudioSource>();
    }

    void Update()
    {
        // �����̴� ���� ����� �ҽ��� ���� ������ ����
        asource.volume = slider.value;
    }
}