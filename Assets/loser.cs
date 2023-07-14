using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loser : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript Logic;
    public Rigidbody2D Bar;
    public Rigidbody2D Ball;
    private int _lives = 3;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        _lives--;
        if (_lives <= 0)
        {
            Logic.gameOver();
        }
        else
        {
            Instantiate(Ball, new Vector3(Bar.transform.position.x + 0.1f, 14.7f, 0f), Bar.transform.rotation);
        }
    }
}
