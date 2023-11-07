using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(spawnRange, spawnRange);
        float spawmPosY = Random.Range(spawnRange, spawnRange);
        Vector2 randomPos = new Vector2(spawnPosX, spawmPosY);
        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
