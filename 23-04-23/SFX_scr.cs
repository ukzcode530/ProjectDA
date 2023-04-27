using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SFX_scr : MonoBehaviour
{
    
   
    AudioSource audiosource;
    public AudioClip Door_Locked;
    public AudioClip Door_Keyopen;
    public AudioClip Crowbar_use;
    public AudioClip Flash_onsound;
    public AudioClip MOnster_roar;
    public AudioClip Numb_beep;
    public AudioClip Numb_correct;
    public AudioClip Numb_error;
    public AudioClip radio_cassette;
    public AudioClip Door_Opensound;
    public AudioClip acid_onsound;
    public AudioClip PickupItem;
    public AudioClip Oilwater;
    public AudioClip MonsterScream;

    void Start()
    {
 
        audiosource = GetComponent<AudioSource>();
      
    }

    public void Door_Lock_play()
    {
        audiosource.PlayOneShot(Door_Locked);
    }
    public void Door_Key_play()
    {
        audiosource.PlayOneShot(Door_Keyopen);
    }
    public void Crowbar_use_play()
    {
        audiosource.PlayOneShot(Crowbar_use);
    }
    public void Flash_onsound_play()
    {
        audiosource.PlayOneShot(Flash_onsound);
    }
    public void MOnster_roar_play()
    {
        audiosource.PlayOneShot(MOnster_roar);
    }
    public void Numb_beep_play()
    {
        audiosource.PlayOneShot(Numb_beep);
    }
    public void Numb_correct_play()
    {
        audiosource.PlayOneShot(Numb_correct);
    }
    public void Numb_error_play()
    {
        audiosource.PlayOneShot(Numb_error);
    }
    public void radio_cassette_play()
    {
        audiosource.PlayOneShot(radio_cassette);
    }
    public void Door_Opensound_play()
    {
        audiosource.PlayOneShot(Door_Opensound);
    }
    public void acid_onsound_play()
    {
        Invoke("acid_delay", 2f);  
    }

    public void PickupItem_play()
    {
        audiosource.PlayOneShot(PickupItem);
    }
    public void Oilwater_play()
    {
        Invoke("oil_delay", 2f);
    }
    public void MonsterScream_play()
    {
        audiosource.PlayOneShot(MonsterScream);
    }

    public void acid_delay()
    {
        audiosource.PlayOneShot(acid_onsound);
    }

    public void oil_delay()
    {

        audiosource.PlayOneShot(Oilwater);
    }
}