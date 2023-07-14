using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loser : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    public Rigidbody2D bar;
    public Rigidbody2D ball;
    private int lives = 3;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        lives--;
        if (lives <= 0)
        {
            logic.gameOver();
        }
        else
        {
            Instantiate(ball, new Vector3(bar.transform.position.x + 0.1f, 14.7f, 0f), bar.transform.rotation);
        }
    }
}
