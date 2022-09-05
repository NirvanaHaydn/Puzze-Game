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

    public void MasterVolumChange()
    {
        mixer.SetFloat("masterVolparameter", masterVol.value);
    }
    
    public void MusicVolumChange()
    {
        mixer.SetFloat("musicVolparameter", musicValue.value);
    }
    public void FxVolumChange()
    {
        mixer.SetFloat("fxVolparameter", fxValue.value);
    }
}
