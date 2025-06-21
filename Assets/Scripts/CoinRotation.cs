using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{

    public float speed;
    public int playerScore;
    private int savesStore;
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

        }
        manager.GetComponent<GameManager>().IncrementScore();
    }
    public void RotationSpeed(float rotationSpeed)
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

    }

}

