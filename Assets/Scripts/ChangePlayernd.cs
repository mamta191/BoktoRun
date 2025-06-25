using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayernd : MonoBehaviour
{
    [SerializeField] private GameObject boktoP;
    [SerializeField] private GameObject barrelP;
 
    [SerializeField] private CameraM cam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == barrelP)
        {
            boktoP.transform.position =  barrelP.transform.position;
            barrelP.SetActive(false);
            boktoP.SetActive(true);
            cam.target = boktoP.transform;
        }
    }
}
