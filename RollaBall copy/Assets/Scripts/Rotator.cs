using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {
        int weight = Random.Range(0, 1) * 2 - 1;

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up,  90 * Time.deltaTime);
    }
}
