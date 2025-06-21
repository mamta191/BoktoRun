using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;
    public Text scoreText;
    public GameObject homeMenu;
    public GameObject settingMenu;
    public GameObject pauseMenu;
    public GameObject gamePlay;
    public GameObject settBack;
    public GameObject soundSlash;
    public GameObject musicSlash;
    public static bool reStartUi;
    public GameObject reStartB;
    public GameObject homeB;


    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

   

    public void Start()
    {
        if (reStartUi == true)
        {

           // AudioManager.instance.ButtonSound();
            homeMenu.SetActive(false);
            settingMenu.SetActive(false);
            pauseMenu.SetActive(false);
            gamePlay.SetActive(true);
        }
        else
        {

           // AudioManager.instance.ButtonSound();
            homeMenu.SetActive(true);
            settingMenu.SetActive(false);
            pauseMenu.SetActive(false);
            gamePlay.SetActive(false);
        }
    }

    public void StartGame()
    {
        //AudioManager.instance.ButtonSound();
        homeMenu.SetActive(false);
        settingMenu.SetActive(false);
        pauseMenu.SetActive(false);
        gamePlay.SetActive(true);
    }

    public void SettingButtons()
    {
        // AudioManager.instance.ButtonSound();
        homeMenu.SetActive(false);
        settingMenu.SetActive(true);
    }

    public void QuitGame()
    {
        //AudioManager.instance.ButtonSound();
        Application.Quit();
    }
    public void SettingUI()
    {
        //AudioManager.instance.ButtonSound();
        homeMenu.SetActive(false);
        settingMenu.SetActive(true);
        pauseMenu.SetActive(false);
        gamePlay.SetActive(false);
    }
    public void SettingBack()
    {

        settBack.SetActive(true);
        // AudioManager.instance.ButtonSound();
        settingMenu.SetActive(false);
        homeMenu.SetActive(true);
    }



    public void MusicOn()
    {
        musicSlash.SetActive(false);


    }
    public void MusicOff()
    {

        musicSlash.SetActive(true);

    }
    public void SoundOn()
    {
        soundSlash.SetActive(false);

    }

    public void SoundOff()
    {
        soundSlash.SetActive(true);

    }

    public void Restarting()
    {
        // AudioManager.instance.ButtonSound();
        Time.timeScale = 1f;
        reStartUi = true;
        var sc = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sc);
    }
    public void GoHome()
    {
        reStartUi = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
