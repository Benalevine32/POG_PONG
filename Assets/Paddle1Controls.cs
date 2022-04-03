using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1Controls : MonoBehaviour
{
    //Set keys to move paddles
    public KeyCode paddleUp = KeyCode.W;
    public KeyCode paddleDown = KeyCode.S;

    //Set speed and screen limits for paddles
    public float paddleSpeed = 10.0f;
    public float screenLimit = 4.25f;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(paddleUp))
        {
            vel.y = paddleSpeed;
        }
        else if (Input.GetKey(paddleDown))
        {
            vel.y = -paddleSpeed;
        }
        else
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > screenLimit)
        {
            pos.y = screenLimit;
        }
        else if (pos.y < -screenLimit)
        {
            pos.y = -screenLimit;
        }
        transform.position = pos;
    }
}
