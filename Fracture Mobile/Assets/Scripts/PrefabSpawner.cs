using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PrefabSpawner")]
public class PrefabSpawner : ScriptableObject
{
    public GameObject prefab;
    public Vector3 spawnLocation;

    public void SpawnPrefab()
    {
        if (prefab != null)
        {
            Instantiate(prefab, spawnLocation, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Prefab is not assigned.");
        }
    }
}