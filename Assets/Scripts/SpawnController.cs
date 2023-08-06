using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab; // ������ �����
    [SerializeField] private float spawnRadius = 5f; // ������ ����������, �� ������� ����� ���������� �����
    [SerializeField] private float spawnInterval = 1f; // �������� ������ ����� (� ��������)

    private void Start()
    {
        // �������� �������� ����� � �������� ����������
        InvokeRepeating("SpawnZombie", 0f, spawnInterval);
    }

    private void SpawnZombie()
    {
        // ���������� ��������� ���� � ��������
        float angle = Random.Range(0f, Mathf.PI * 2f);

        // ��������� ���������� ������ ����� �� ����������
        float x = transform.position.x + spawnRadius * Mathf.Cos(angle);
        float y = transform.position.y + spawnRadius * Mathf.Sin(angle);

        // ������� ����� � ��������� ��� �� ������������ �����������
        Instantiate(zombiePrefab, new Vector3(x, y, 0f), Quaternion.identity);
    }
}
