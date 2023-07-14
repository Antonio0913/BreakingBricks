using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject block;
    public double spawnRate = 1;
    private float timer = 0;
    private float amountSpawned = 0;
    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * 5 * Time.deltaTime);
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else if (amountSpawned > 7)
        {

        }
        else
        {
            Instantiate(block, transform.position, transform.rotation);
            amountSpawned++;
            timer = 0;
        }

    }
}
