using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAtRandomLoc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 vec = Random.insideUnitCircle * 7;

        while (vec.x == 0 && vec.y == 0) {
            vec = Random.insideUnitCircle * 7;
        }

        Vector3 vec3 = new Vector3(vec.x, 0.6f, vec.y);
        transform.position = vec3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
