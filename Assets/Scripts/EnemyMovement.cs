using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(4.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
