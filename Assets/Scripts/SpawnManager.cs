using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float spawnPosZBottom;
    public float spawnPosZTop;
    public float spawnPosXLeft;
    public float spawnPosXRight;
    public float startDelay;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn an animal at timed intervals
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimalTop()
    {
        // Spawns random animal along the top
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomXPos = Random.Range(spawnPosXLeft, spawnPosXRight);
        Vector3 spawnPos = new Vector3(randomXPos, 0, spawnPosZTop);
        
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        // Spawns random animal along the left
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomZPos = Random.Range(spawnPosZBottom, spawnPosZTop);
        Vector3 spawnPos = new Vector3(spawnPosXLeft, 0, randomZPos);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
    }
}
