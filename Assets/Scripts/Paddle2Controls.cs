using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Controls : MonoBehaviour
{
    static int score = 0;
    //Set keys to move paddles
    public KeyCode paddleUp = KeyCode.I;
    public KeyCode paddleDown = KeyCode.K;

    //Set speed and screen limits for paddles
    public float paddleSpeed = 10.0f;
    public float screenLimit = 4.25f;

    private Rigidbody2D paddle2;

    // Start is called before the first frame update
    void Start()
    {
        paddle2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = paddle2.velocity;

        if (Input.GetKey(paddleUp))//Use keys to move paddle up/down
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
        paddle2.velocity = vel;

        var pos = transform.position;
        if (pos.y > screenLimit)//Keeps paddle from traveling offscreen
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
