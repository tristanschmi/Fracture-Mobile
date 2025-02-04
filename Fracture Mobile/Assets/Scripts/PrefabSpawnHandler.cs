using UnityEngine;

public class PrefabSpawnHandler : MonoBehaviour
{
    public PrefabSpawner prefabSpawner;
    public float spawnCooldown = 1f; // Cooldown time in seconds between spawns
    public float newSpeed = 10f; // New speed value to set for the prefabs

    private float lastSpawnTime = 0f;

    public void TrySpawnPrefab()
    {
        Debug.Log("TrySpawnPrefab called at: " + Time.time);

        if (Time.time >= lastSpawnTime + spawnCooldown)
        {
            GameObject spawnedPrefab = prefabSpawner.SpawnPrefab();
            if (spawnedPrefab != null)
            {
                // Set the speed of the newly instantiated prefab
                MoveAlongZAxis moveScript = spawnedPrefab.GetComponent<MoveAlongZAxis>();
                if (moveScript != null)
                {
                    moveScript.SetSpeed(newSpeed);
                }
            }
            lastSpawnTime = Time.time;
            Debug.Log("Prefab spawned at: " + Time.time);
        }
        else
        {
            Debug.LogWarning("Spawn cooldown active. Next spawn available at: " + (lastSpawnTime + spawnCooldown));
        }
    }

    public void UpdateSpeed(float speed)
    {
        newSpeed = speed;
        Debug.Log("Speed updated to: " + newSpeed);
    }
}