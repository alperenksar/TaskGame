using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject PowerUpPrefab;   
    private float Rangex = 9;
    private float Rangez = 9;
    public int enemyCount;
    private int WaveNumber;
   
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(WaveNumber);
        Instantiate(PowerUpPrefab, GenerateSpawnPos(), PowerUpPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            WaveNumber++;
            SpawnEnemyWave(WaveNumber);
            Instantiate(PowerUpPrefab, GenerateSpawnPos(), PowerUpPrefab.transform.rotation);
        }

    }
    void Spawner()
    {
       
        Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        
    }
    void SpawnEnemyWave(int enemyiestospawn)
    {
        for (int i = 0; i < enemyiestospawn; i++)
        {
            Spawner();
        }
    }
    public Vector3 GenerateSpawnPos()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-Rangex, Rangex), 0, Random.Range(-Rangez, Rangez));
        return SpawnPosition;
    }
}

