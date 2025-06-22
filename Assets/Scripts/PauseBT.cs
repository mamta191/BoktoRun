using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBT : MonoBehaviour
{

    public GameObject pauseUI;
    public GameObject homeUI;
    public GameObject playBT;
    public GameObject gameC;




    public void Hello()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
        gameC.SetActive(false);
    }
    public void Play()
    {
        AudioManager.instance.ButtonSound();
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        gameC.SetActive(true);
    }

    public void Home()
    {
        AudioManager.instance.ButtonSound();
        homeUI.SetActive(true);
        pauseUI.SetActive(false);
    }
    public void play()
    {
        AudioManager.instance.ButtonSound();
        Time.timeScale = 0;
        playBT.SetActive(true);
    }

}
