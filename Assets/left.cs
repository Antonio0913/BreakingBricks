using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    public Rigidbody2D Bar;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Bar.velocity = new Vector3(15, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Bar.velocity = new Vector3(-15, 0, 0);
        }
        else
        {
            Bar.velocity = new Vector3(0, 0, 0);
        }
    }
}
