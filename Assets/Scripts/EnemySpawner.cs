using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyPrefab;
    [SerializeField]
    private float enemyInterval = 2.0f;
    public int counter;
    public GameObject[] enemyNum;
    public Transform player;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    void Update()
    {
        enemyNum = GameObject.FindGameObjectsWithTag("Enemy");
        counter = enemyNum.Length;
    }

    IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        if(counter <= 4)
        {
            GameObject newEnemy = Instantiate(enemy);
            StartCoroutine(spawnEnemy(interval, enemy));
        }
    }
}
