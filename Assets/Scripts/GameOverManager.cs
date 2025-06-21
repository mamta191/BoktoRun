using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{

    public Rigidbody2D playerRB;
    public int expectedIndex;
    public GameObject reStartUI;

    [SerializeField] private Scores playerScore;
    private bool isPerfectScore;
    public GAmeSetting _gameSetting;



    private void Start()
    {
        isPerfectScore = true;
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            Debug.Log("GameOver");
            gameObject.SetActive(false);
           // AudioManager.instance.DeadSound();
            reStartUI.SetActive(true);
        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerRB.velocity.y < 0)
        {


            collision.transform.parent.GetComponent<BoxCollider2D>().enabled = false;
            collision.GetComponent<BoxCollider2D>().enabled = false;

            if (isPerfectScore == false)
            {
                playerScore.PlayerScore(1);
            }

            else
            {
                if (_gameSetting.isVibrate)
                {
                    Handheld.Vibrate();
                }

                playerScore.PlayerScore(2);
            }
            isPerfectScore = true;
        }

        else
        {

            gameObject.SetActive(false);
            reStartUI.SetActive(true);

        }

    }
}
