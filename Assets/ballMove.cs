using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    public Rigidbody2D Ball;
    public LogicScript Logic;
    private float _start = 4;
    private float _timer = 0;
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
        else if (_timer > _start && Input.GetKeyDown(KeyCode.Space))
        {

            Ball.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            _started = true;
        }
        else
        {
            _timer = _timer + Time.deltaTime;
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
