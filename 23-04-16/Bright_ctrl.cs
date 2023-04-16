using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bright_ctrl : MonoBehaviour
{
    public Slider slider;
    public Light sceneLight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sceneLight.intensity = slider.value;
    }
}
