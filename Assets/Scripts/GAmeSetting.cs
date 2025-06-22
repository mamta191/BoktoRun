using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeSetting : MonoBehaviour
{

    public GameObject musicStashGameObject;
    public GameObject soundStashObject;
    public GameObject vibrationMode;

   static int musicBtnCounter;
   static int soundBtnCounter;
  static  int vibratingCounter;
    public bool isVibrate;
    public AudioClip buttonClick;
    public AudioSource audioManager;


    private void Start()
    {
        if (musicBtnCounter % 2 != 0)
        {
            musicStashGameObject.SetActive(true);
           

        }
        else if(musicBtnCounter % 2 == 0)
        {
            musicStashGameObject.SetActive(false);
          

        }
        if (soundBtnCounter % 2 != 0)
        {
            soundStashObject.SetActive(true);
          

        }

        else if (soundBtnCounter % 2 == 0)

        {
            soundStashObject.SetActive(false);
           
        }
        if (vibratingCounter % 2 != 0)
        {
            isVibrate = false;
            vibrationMode.SetActive(true);
        }

        else if (vibratingCounter % 2 == 0)

        {
            isVibrate = true;
            vibrationMode.SetActive(false);
        }



    }


    public void MusicStashHandler()
    {
        musicBtnCounter++;

        if (musicBtnCounter % 2 != 0)
        {
            musicStashGameObject.SetActive(true);
            AudioManager.instance.bgSound.volume = 0f;

        }
        else
        {
            musicStashGameObject.SetActive(false);
            AudioManager.instance.bgSound.volume = 1f;

        }

    }



    public void SoundStasHandler()
    {
        soundBtnCounter++;

        if (soundBtnCounter % 2 != 0)
        {
            soundStashObject.SetActive(true);
            AudioManager.instance.eventSound.volume = 0f;

        }

        else
        {
            soundStashObject.SetActive(false);
            AudioManager.instance.eventSound.volume = 1f;
        }
    }
    public void Vibration()
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

    }
}
