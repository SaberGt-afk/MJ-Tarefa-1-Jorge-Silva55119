using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{

    public GameObject[ ] animalPrefabs;
    private float spawnRangeX = 11;
    private float spawnPosZ = 5;
    private float startDelay = 2;      
    private float spawnInterval = 1.5f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
