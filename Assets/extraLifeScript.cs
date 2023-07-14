using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extraLifeScript : MonoBehaviour
{
    public Rigidbody2D Ball;
    public LogicScript Logic;
    private bool _started = false;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("enemyBox(Clone)"))
        {
            Destroy(other.gameObject);
            Logic.addScore();
        }

    }

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    void Update()
    {
        if (_started)
        {
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            Ball.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            _started = true;
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                Ball.velocity = new Vector2(15, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Ball.velocity = new Vector2(-15, 0);
            }
            else
            {
                Ball.velocity = new Vector2(0, 0);
            }
        }
    }
}
