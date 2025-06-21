using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScore;
    private int savesStore;




    private void Start()
    {
        savesStore = PlayerPrefs.GetInt("Highest");
        highScore.text = savesStore.ToString();
    }



    public void PlayerScore(int num)

    {
        playerScore += num;
       
        scoreText.text = playerScore.ToString();



        if (playerScore > savesStore)
        {
            PlayerPrefs.SetInt("Highest", playerScore);

            savesStore = PlayerPrefs.GetInt("Highest");
            highScore.text = savesStore.ToString();
        }

    }
}
