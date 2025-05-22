using UnityEngine;

public class SpawnManagerlab : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject powerup;

    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 2f;

    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), startDelay, enemySpawnTime);
        InvokeRepeating(nameof(SpawnPowerup), startDelay, powerupSpawnTime);
    }

    void Update()
    {

    }

    void SpawnEnemy()
    {
        if (Enemies.Length == 0)
        {
            Debug.LogWarning("Nenhum inimigo no array Enemies.");
            return;
        }

        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, Enemies.Length);

        GameObject enemyPrefab = Enemies[randomIndex];

        // Calcula a altura visível do objeto para ajustar o spawn no chão
        float yOffset = 0f;
        Renderer enemyRenderer = enemyPrefab.GetComponentInChildren<Renderer>();
        if (enemyRenderer != null)
        {
            yOffset = enemyRenderer.bounds.extents.y;
        }

        Vector3 spawnPos = new Vector3(randomX, yOffset, zEnemySpawn);
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        Instantiate(powerup, spawnPos, powerup.transform.rotation);
    }
}
