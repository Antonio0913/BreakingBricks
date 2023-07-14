using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extraLifeScript : MonoBehaviour
{
    public Rigidbody2D ball;
    public GameObject enemy;
    public LogicScript logic;
    private bool started = false;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("enemyBox(Clone)"))
        {
            Destroy(other.gameObject);
            logic.addScore();
        }

    }
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            ball.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            started = true;
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                ball.velocity = new Vector2(15, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                ball.velocity = new Vector2(-15, 0);
            }
            else
            {
                ball.velocity = new Vector2(0, 0);
            }
        }
    }
}
