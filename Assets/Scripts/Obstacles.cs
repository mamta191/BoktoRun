using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerM bkMove;

    void Start()
    {
       bkMove = GameObject.FindObjectOfType<PlayerM>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            //KillThePlayer
          //bkMove.Die();
        }
    }
   
}
