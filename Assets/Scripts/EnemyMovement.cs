using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform playerPosition;
    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
        speed = Random.Range(4.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPosition != null)
        {

        }
    }
}
