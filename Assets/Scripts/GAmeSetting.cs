using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeSetting : MonoBehaviour
{

    public GameObject musicStashGameObject;
    public GameObject soundStashObject;
    
    static int musicBtnCounter;
    static int soundBtnCounter;

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
   

    
}
