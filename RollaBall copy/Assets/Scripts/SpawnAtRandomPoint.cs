using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnAtRandomPoint : MonoBehaviour
{
    public GameObject pickUp;
    private int boundary = 10;
    private int x;
    private int z;
    private Random rand = new Random();

    void Start() {
        DropPickUp();
    }

    IEnumerator DropPickUp() {
            x = rand.Next(-1 * boundary, boundary);
            z = rand.Next(-1 * boundary, boundary);
            float y = 0.6f;

            Instantiate(pickUp, new Vector3(x, y, z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
    }
}
