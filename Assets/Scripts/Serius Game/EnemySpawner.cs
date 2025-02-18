using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab; // Prefab a instanciar
    public Transform spawnPoint; // Punto de aparición
    public float spawnInterval = 10f; // Intervalo de tiempo entre apariciones

    void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }
    void Update()
    {
        transform.position = new Vector3(Random.Range(-100, 100),0,Random.Range(-50, 100));
    }
    void SpawnPrefab()
    {
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
