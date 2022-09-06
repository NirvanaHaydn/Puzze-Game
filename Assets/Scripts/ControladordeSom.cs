using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ControladordeSom : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicValue;
    public Slider fxValue;
    public Slider masterVol;
    

    private void Start()
    {
        PlayerPrefs.GetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.GetFloat("musicVolparameter", musicValue.value);
        PlayerPrefs.GetFloat("fxVolparameter", fxValue.value);
    }
    public void MasterVolumChange()
    {
        mixer.SetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.SetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.Save();
    }
    
    public void MusicVolumChange()
    {
        mixer.SetFloat("musicVolparameter", musicValue.value);
        PlayerPrefs.SetFloat("musicVolparameter", musicValue.value);
    }
    public void FxVolumChange()
    {
        mixer.SetFloat("fxVolparameter", fxValue.value);
        PlayerPrefs.SetFloat("fxVolparameter", fxValue.value);
    }
}
