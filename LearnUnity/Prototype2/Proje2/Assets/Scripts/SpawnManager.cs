using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRangeX=20;
    private float SpawnRangeY = 20;
    private float SpawnTime = 2;
    private float RepeatTimeSpawn = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", SpawnTime, RepeatTimeSpawn);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
       
            Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeY);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], SpawnPosition, animalPrefabs[animalIndex].transform.rotation);
        
    }
}
