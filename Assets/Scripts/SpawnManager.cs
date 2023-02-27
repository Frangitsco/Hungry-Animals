using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[]animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 10f;

    public float sideSpawnMinZ;
public float sideSpawnMaxZ;
public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() 
    {

    }

   void SpawnRandomAnimal()
     {
    // Randomly generate animal index and spawn position
    Vector3 spawnPosForward = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosForward,
        animalPrefabs[animalIndex].transform.rotation); 
    } 

    void SpawnLeftAnimal()
{
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,
sideSpawnMaxZ));
    Vector3 rotation = new Vector3(0, 90, 0);
    Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
}
}

