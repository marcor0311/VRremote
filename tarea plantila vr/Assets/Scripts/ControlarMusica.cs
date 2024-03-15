using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlarMusica : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void sliderMusica(float Slider){
    audioMixer.SetFloat("CambiarTono", Mathf.Log10(Slider) * 10);
    }
}
