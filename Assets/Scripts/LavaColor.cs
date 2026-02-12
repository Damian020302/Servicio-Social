using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaColor : MonoBehaviour
{
    public Color defaultColor = Color.red;
    public Color[] arrayColor = new Color[]
        {
            Color.red,
            Color.yellow,
            Color.blue
        };

    void Start()
    {

        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);
            defaultColor = Random.ColorHSV();
            GetComponent<Renderer>().material.color = defaultColor;
        }
        
    }
}
