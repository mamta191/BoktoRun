using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
   [SerializeField] private List<GameObject> paths = new List<GameObject>();
   [SerializeField] private GameObject spawnPoint;

   [SerializeField] private PlayerM player;


    private int nextIndex;
    private int currentIndex;

    private GameObject runningPoint;


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

        var CoinHolder = runningPoint.transform.GetChild(2);
        
        for(int i = 0; i<CoinHolder.childCount; i++)
        {
         CoinHolder.GetChild(i).gameObject.SetActive(true);   
        }
    }
}
