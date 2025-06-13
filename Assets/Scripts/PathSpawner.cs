using System.Collections;
using System.Collections.Generic;
using Cinemachine.Examples;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
   [SerializeField] private List<GameObject> paths = new List<GameObject>();
   [SerializeField] private GameObject spawnPoint;

   [SerializeField] private PlayerM player;


   private int nextIndex;

  private GameObject runningPoint;





    // Start is called before the first frame update
    void Start()
    {
        paths[1].transform.position =  spawnPoint.transform.position;
    }

    private void Update()
    {
        if (runningPoint == player.currentPath)
        {
            return;
        }
        PathChanger();
    }

    public void PathChanger()
   {
        nextIndex = Random.Range(0, paths.Count);
        paths[nextIndex].transform.position = spawnPoint.transform.position;

       
        runningPoint  =  player.currentPath;
        spawnPoint = paths[nextIndex].transform.GetChild(1).gameObject;
   }
}
