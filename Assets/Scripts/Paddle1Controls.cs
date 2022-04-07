using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1Controls : MonoBehaviour
{
    //CJG Start
    //Set keys to move paddles
    public KeyCode paddleUp = KeyCode.W;
    public KeyCode paddleDown = KeyCode.S;

    //Set speed and screen limits for paddles
    public float paddleSpeed = 10.0f;
    public float screenLimit = 4.25f;

    private Rigidbody2D paddle1;

    // Start is called before the first frame update
    void Start()
    {
        paddle1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = paddle1.velocity;

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
        paddle1.velocity = vel;

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
    //CJG End
}
