using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnRangeZ = 25.0f;
    private float spawnPosZ = 20.0f;
    private float spawnPosX = 25.0f;
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalVert", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalHori", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimalVert()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
     void SpawnRandomAnimalHori()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0,90,0));
    }
}
