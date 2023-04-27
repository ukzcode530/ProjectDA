using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_audio_scr : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip Forneus_roar;
    public AudioClip Earth_quake;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = Earth_quake;
        audiosource.loop = true;
        audiosource.Play();
        Invoke("Forneus_roar_play", 9f);
    }

    public void Forneus_roar_play()
    {
        audiosource.PlayOneShot(Forneus_roar);
    }
    public void Door_Key_play()
    {
       
    }

    public void LastScene_play()
    {
       
    }

}
