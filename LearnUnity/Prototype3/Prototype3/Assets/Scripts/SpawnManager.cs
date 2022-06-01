using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] ObstaclePrefabs;
    private Vector3 spawnPos;
    private float startDelay = 2f;
    private float repeatRate = 5f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void SpawnObstacle()
    {
        spawnPos= new Vector3(Random.Range(15.0f, 25f), -0.65f, 0);
        int index=Random.Range(0, ObstaclePrefabs.Length);
        if(!playerControllerScript.GameOver)
        {
            Instantiate(ObstaclePrefabs[index], spawnPos, ObstaclePrefabs[index].transform.rotation);
        }
        
    }
   
}
