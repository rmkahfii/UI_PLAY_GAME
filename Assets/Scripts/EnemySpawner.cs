using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  public GameObject enemyPrefab;
    public float spawnTime = 3f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = new Vector2(
            Random.Range(-5f, 5f),
            transform.position.y
        );

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
