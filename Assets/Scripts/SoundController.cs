using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Slider volumeSlider; 
    public AudioSource backgroundMusic; 

    void Start()
    {
        volumeSlider.value = 0.1f;
        backgroundMusic.volume = volumeSlider.value;

        
        volumeSlider.onValueChanged.AddListener(VolumeChanged);
    }

    void VolumeChanged(float newVolume)
    {
        
        backgroundMusic.volume = newVolume;
    }
}
