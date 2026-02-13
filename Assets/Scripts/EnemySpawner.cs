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
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    void Update()
    {
        enemyNum = GameObject.FindGameObjectsWithTag("Enemy");
        counter = enemyNum.Length;
    }
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
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
