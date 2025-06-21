using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeSetting : MonoBehaviour
{

    public GameObject musicStashGameObject;
    public GameObject soundStashObject;
    public GameObject vibrationMode;

    int musicBtnCounter;
    int soundBtnCounter;
    int vibratingCounter;
    public bool isVibrate;
    public AudioClip buttonClick;
    //public AudioSource audioManager;




    public void MusicStashHandler()
    {
        musicBtnCounter++;

        if (musicBtnCounter % 2 != 0)
        {
            musicStashGameObject.SetActive(true);
          //  AudioManager.instance.bgSound.volume = 0f;

        }
        else
        {
            musicStashGameObject.SetActive(false);
           // AudioManager.instance.bgSound.volume = 1f;

        }

    }

    public void SoundStasHandler()
    {
        soundBtnCounter++;

        if (soundBtnCounter % 2 != 0)
        {
            soundStashObject.SetActive(true);
           // AudioManager.instance.eventSound.volume = 0f;

        }

        else
        {
            soundStashObject.SetActive(false);
           // AudioManager.instance.eventSound.volume = 1f;
        }
    }
    /*public void Vibration()
    {
        vibratingCounter++;

        if (vibratingCounter % 2 != 0)
        {
            isVibrate = false;
            vibrationMode.SetActive(true);
        }

        else
        {
            isVibrate = true;
            vibrationMode.SetActive(false);
        }

    }*/
}
