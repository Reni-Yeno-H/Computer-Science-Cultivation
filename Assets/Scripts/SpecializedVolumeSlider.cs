using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SpecializedVolumeSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public GameObject ObjectMusic;

    //private float MusicVolume = 0f;
    private AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        /*ObjectMusic = GameObject.FindGameObjectWithTag("GameMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
        */

        ObjectMusic = GameObject.FindGameObjectWithTag("GameMusic");
        //AudioSource = ObjectMusic.GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 1);
            Load();
        }
        else{
            Load();
        }
    }

    /*private void Update()
    {
        AudioSource.Volume = MusicVolume;
        PlayerPrefs.SetFloat("Volume", MusicVolume);
    }

    public void VolumeUpdater(float volume){
        MusicVolume = volume;
    }

    public void MusicReset()
    {
        PlayerPrefs.DeleteKey("volume");
        AudioSource.volume = 1;
        volumeSlider.value = 1;
    
    }*/

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
    
}
