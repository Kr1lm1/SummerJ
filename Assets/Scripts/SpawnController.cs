using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab; // Префаб зомби
    [SerializeField] private float spawnRadius = 5f; // Радиус окружности, на которой будут спавниться зомби
    [SerializeField] private float spawnInterval = 1f; // Интервал спавна зомби (в секундах)

    private void Start()
    {
        // Начинаем спавнить зомби с заданным интервалом
        InvokeRepeating("SpawnZombie", 0f, spawnInterval);
    }

    private void SpawnZombie()
    {
        // Генерируем случайный угол в радианах
        float angle = Random.Range(0f, Mathf.PI * 2f);

        // Вычисляем координаты спавна зомби на окружности
        float x = transform.position.x + spawnRadius * Mathf.Cos(angle);
        float y = transform.position.y + spawnRadius * Mathf.Sin(angle);

        // Создаем зомби и размещаем его на рассчитанных координатах
        Instantiate(zombiePrefab, new Vector3(x, y, 0f), Quaternion.identity);
    }
}
