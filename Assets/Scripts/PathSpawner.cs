using System.Collections;
using System.Collections.Generic;
using Cinemachine.Examples;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
   [SerializeField] private List<GameObject> paths = new List<GameObject>();
   [SerializeField] private GameObject spawnPoint;

   [SerializeField] private PlayerM player;


    [SerializeField] private int nextIndex;
    [SerializeField] private int currentIndex;

    [SerializeField] private GameObject runningPoint;





    // Start is called before the first frame update
   

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
        do
        {
            nextIndex = Random.Range(0, paths.Count);
        }
        while (nextIndex == currentIndex);

        Debug.Log(nextIndex);


        currentIndex = nextIndex;

        paths[nextIndex].transform.position = spawnPoint.transform.position;


        runningPoint = player.currentPath;
        spawnPoint = paths[nextIndex].transform.GetChild(1).gameObject;
    }
}
