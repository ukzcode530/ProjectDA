using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BGM_scr : MonoBehaviour
{
    
   
    AudioSource audiosource;
    public AudioClip wind;
    public AudioClip Hstrings;

    void Start()
    {
 
        audiosource = GetComponent<AudioSource>();
       audiosource.clip = wind;
        audiosource.loop = true;
        audiosource.Play();
    }

    public void StopPlaying()
    {
        audiosource.Stop();
    }

    public void WIndon()
    {
        audiosource.clip = wind;
        audiosource.loop = true;
        audiosource.Play();
    }
    public void Hstring_on()
    {
        audiosource.clip = Hstrings;
        audiosource.loop = false;
        audiosource.Play();

    }




}