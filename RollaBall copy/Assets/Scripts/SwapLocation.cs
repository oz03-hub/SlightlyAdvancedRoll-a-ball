using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapLocation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeLocation()
    {
        Vector2 vec = Random.insideUnitCircle * 7;

        Vector3 vec3 = new Vector3(vec.x, 0.6f, vec.y);
        transform.position = vec3;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            ChangeLocation();
        }
    }
}