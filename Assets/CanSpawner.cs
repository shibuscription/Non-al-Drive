using UnityEngine;

public class CanSpawner : MonoBehaviour
{
    public GameObject[] canPrefabs; // OK缶やNG缶を登録しておく
    public float spawnInterval = 2f;
    public float spawnX = 10f; // 右端のX座標
    public float[] lanesY = { 2f, 0f, -2f };

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnCan();
            timer = 0f;
        }
    }

    void SpawnCan()
    {
        int canIndex = Random.Range(0, canPrefabs.Length);
        int laneIndex = Random.Range(0, lanesY.Length);

        Vector2 spawnPos = new Vector2(spawnX, lanesY[laneIndex]);
        Instantiate(canPrefabs[canIndex], spawnPos, Quaternion.identity);
    }
}
