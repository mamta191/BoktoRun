using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{

    public float speed;


    void FixedUpdate()
    {
        RotationSpeed(speed);

    }
    public void RotationSpeed(float rotationSpeed)
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("coins"))
        {
            gameObject.SetActive(false);
        }
    }       
}
