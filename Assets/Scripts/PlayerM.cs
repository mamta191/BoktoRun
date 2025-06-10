using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class PlayerM : MonoBehaviour
{
    private Animator boktoAnimator;
    private Rigidbody boktoRB;
    public float playerSpeed;
    Vector3 start;
    Vector3 up;
    Vector3 end;
    Vector3 down;
    public float boktoRotate;


   
  

     // Start is called before the first frame update
    void Start()
    {
        boktoAnimator = GetComponent<Animator>();
        boktoRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        boktoRB.velocity = new Vector3(boktoRB.velocity.x, boktoRB.velocity.y, playerSpeed);

        if(Input.GetMouseButtonDown(0))
        {
            start = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            end = Input.mousePosition;
            Swipe();
        }
    }

    void Swipe()
    {
     var xDisplace = start.x - end.x;
     var yDisplace = start.y - end.y;

        if ( Mathf.Abs(xDisplace) > Mathf.Abs(yDisplace)) 
        {

            if (start.x - end.x < 0)
            {
                boktoRB.transform.eulerAngles = new Vector3(0f, 90f, 0f);
                boktoRB.velocity = new Vector3(playerSpeed, boktoRB.velocity.y,0);
                Debug.Log("right");
            }
            else
            {
                boktoRB.transform.eulerAngles = new Vector3(0f, -90f, 0f);
                boktoRB.velocity = new Vector3(-playerSpeed, boktoRB.velocity.y, 0);
                Debug.Log("left");
            }
        }
        else 
        {

            if (start.y - end.y < 0)
            {

                Debug.Log("up");
            }
            else
            {
                Debug.Log("down");
            }
        }
        transform.Rotate(0f, boktoRotate * Time.deltaTime, 0f);
    }
}   
