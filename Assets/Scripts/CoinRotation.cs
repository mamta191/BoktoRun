using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRotation : MonoBehaviour
{

    public float speed;
    public int playerScore;
    
    
    public GameObject manager;



    private void Start()
    {
        
        manager = GameObject.Find("GameManager");
    }
    void FixedUpdate()
    {
        RotationSpeed(speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("coins"))
        {
            gameObject.SetActive(false);
            AudioManager.instance.ScoreSound();

        }
        manager.GetComponent<GameManager>().IncrementScore();
    }
    public void RotationSpeed(float rotationSpeed)
    {
        transform.Rotate(0,0,rotationSpeed);
    }

}

