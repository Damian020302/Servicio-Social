using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] pickUpPrefab = new GameObject[5];
    [SerializeField]
    private float pickUpInterval = 2.0f;
    public Transform player;
    public float speed = 20.0f;
    public float minDist = 1.0f;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        StartCoroutine(spawnPickUp(pickUpInterval, pickUpPrefab));
    }

    IEnumerator spawnPickUp(float interval, GameObject[] pickUp)
    {
        foreach(GameObject pU in pickUp)
        {
            yield return new WaitForSeconds(interval);
            GameObject newPU = Instantiate(pU);
            StartCoroutine(spawnPickUp(interval, pickUp));
        }
    }
}
