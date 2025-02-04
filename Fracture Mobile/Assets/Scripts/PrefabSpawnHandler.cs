using UnityEngine;

public class PrefabSpawnHandler : MonoBehaviour
{
    public PrefabSpawner prefabSpawner;
    public float spawnCooldown = 1f; // Cooldown time in seconds between spawns

    private float lastSpawnTime = 0f;

    public void TrySpawnPrefab()
    {
        Debug.Log("TrySpawnPrefab called at: " + Time.time);

        if (Time.time >= lastSpawnTime + spawnCooldown)
        {
            prefabSpawner.SpawnPrefab();
            lastSpawnTime = Time.time;
            Debug.Log("Prefab spawned at: " + Time.time);
        }
        else
        {
            Debug.LogWarning("Spawn cooldown active. Next spawn available at: " + (lastSpawnTime + spawnCooldown));
        }
    }
}