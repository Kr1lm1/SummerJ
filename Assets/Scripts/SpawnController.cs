using UnityEngine;

[System.Serializable]
public class SpawnObject
{
    public GameObject prefab;
    public float rarity;
}

public class SpawnController : MonoBehaviour
{
    public SpawnObject[] spawnObjects;
    public float spawnRadius;
    public int maxSpawnAttempts = 10;

    private void Start()
    {
        SpawnObjectsInRadius();
    }

    private void SpawnObjectsInRadius()
    {
        for (int i = 0; i < maxSpawnAttempts; i++)
        {
            Vector2 randomPosition = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPosition = new Vector3(randomPosition.x, randomPosition.y, 0f);

            Collider2D[] colliders = Physics2D.OverlapCircleAll(spawnPosition, 0.5f);

            bool canSpawn = true;
            foreach (var collider in colliders)
            {
                if (collider.CompareTag("Obstacle") || collider.CompareTag("SpawnedObject"))
                {
                    canSpawn = false;
                    break;
                }
            }

            if (canSpawn)
            {
                float randomRarity = Random.Range(0f, 1f);
                float cumulativeRarity = 0f;

                foreach (var spawnObject in spawnObjects)
                {
                    cumulativeRarity += spawnObject.rarity;

                    if (randomRarity <= cumulativeRarity)
                    {
                        GameObject spawnedObject = Instantiate(spawnObject.prefab, spawnPosition, Quaternion.identity);
                        spawnedObject.tag = "SpawnedObject";
                        break;
                    }
                }
            }
            else
            {
                i--; // Retry the spawn if it was unsuccessful
            }
        }
    }
}
