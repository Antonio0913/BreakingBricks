using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject Block;
    private double _spawnRate = 1;
    private float _timer = 0;
    private float _amountSpawned = 0;
    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * 5 * Time.deltaTime);
        if (_timer < _spawnRate)
        {
            _timer = _timer + Time.deltaTime;
        }
        else if (_amountSpawned > 7)
        {
            Destroy(Spawner);
        }
        else
        {
            Instantiate(Block, transform.position, transform.rotation);
            _amountSpawned++;
            _timer = 0;
        }
    }
}
