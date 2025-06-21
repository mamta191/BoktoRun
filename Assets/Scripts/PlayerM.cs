using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class PlayerM : MonoBehaviour
{
    bool Alive = true;
    private Animator boktoAnimator;
    private Rigidbody boktoRB;
    private CapsuleCollider playerCollider;
    public float playerSpeed;
    public bool isJumping;

    Vector3 start;
    Vector3 end;

    public Vector3 jump;

    public GameObject currentPath;




    // Start is called before the first frame update
    void Start()
    {
        boktoAnimator = GetComponent<Animator>();
        boktoRB = this.GetComponent<Rigidbody>();
        playerCollider = GetComponent<CapsuleCollider>();

      
    }
  


    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * playerSpeed);
        // boktoRB.velocity = new Vector3(boktoRB.velocity.x, boktoRB.velocity.y, playerSpeed);
       /* Vector3 x = transform.forward * playerSpeed;
        boktoRB.velocity = new Vector3(x.x, boktoRB.velocity.y, x.z);
*/

        if (!Alive) return;
        var x = Vector3.forward + Vector3.up * boktoRB.velocity.y;
        transform.Translate(x * playerSpeed * Time.deltaTime);


        /*if (transform.position.y < -5)
        {
                Die();
        }*/
        

        if (Input.GetMouseButtonDown(0))
        {
            start = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            end = Input.mousePosition;
            Swipe();
        }
    }

    void Swipe()
    {
        var xDisplace = start.x - end.x;
        var yDisplace = start.y - end.y;

        if (Mathf.Abs(xDisplace) > Mathf.Abs(yDisplace))
        {

            if (start.x - end.x < 0)
            {
                boktoAnimator.transform.Rotate(new Vector3(0, 90,0));   
               //boktoRB.transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y + 90f, 0f);
               // boktoRB.velocity = new Vector3(playerSpeed, boktoRB.velocity.y, 0);
                Debug.Log("right");
            }
            else
            {
                boktoAnimator.transform.Rotate(new Vector3(0, -90, 0));
                // boktoRB.transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y + -90f, 0f);
                //boktoRB.velocity = new Vector3(-playerSpeed, boktoRB.velocity.y, 0);
                Debug.Log("left");
            }
        }
        else
        {

            if (start.y - end.y < 0)
            {
                boktoRB.velocity = new Vector3(boktoRB.velocity.x, jump.y, boktoRB.velocity.z);

                if (isJumping)
                {
                    Debug.Log("up");
                    boktoRB.AddForce(jump, ForceMode.Impulse);
                    isJumping = false;
                }

            }
            else
            {
               Debug.Log("down");
               boktoAnimator.SetTrigger("Slide");
                  
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {   
            isJumping = true;
            currentPath = collision.transform.parent.parent.gameObject;
            Debug.Log(currentPath);
           
        }
       /* if(collision.gameObject.CompareTag("obstacles"))
        {
          //boktoAnimator.SetTrigger("die");
           // Die();
            
        }*/

       
    }
     
    public void Collider()
    {
        playerCollider.height = 0.03f;
        playerCollider.center = new Vector3(0, 0.02f, 0);

    }
    public void NormalCollider()
    {
        playerCollider.height = 0.1056027f;
        playerCollider.center = new Vector3(0, 0.05698607f, 0);
    }

   /* public void Die()
    {
        Alive = false;
       // boktoAnimator.SetBool("die", true);
        boktoAnimator.SetTrigger("die");
        Invoke("Restart", 3f);
    }*/
    void Restart()
    {
        
        StartCoroutine(DelayAction());
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator DelayAction()
    {
        yield return new WaitForSeconds(3f);
    }
} 