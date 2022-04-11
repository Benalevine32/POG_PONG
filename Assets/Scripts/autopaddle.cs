using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autopaddle : MonoBehaviour
{


    //ZEV Start

    //Set speed and screen limits for paddles
    public float paddleSpeed = 5f;
    public float screenLimit = 4f;

    private Rigidbody2D auto;


    
    // Start is called before the first frame update
    void Start()
    {
        auto = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = auto.velocity;

        var pos = transform.position;



       







        if (pos.y < 0)//Keeps paddle from traveling offscreen
        {
            vel.y = -paddleSpeed;


        }
        else if (pos.y == -screenLimit)
        {
            vel.y = paddleSpeed;
        }

        auto.velocity = vel;









        /*
        if (pos.y > screenLimit)//Keeps paddle from traveling offscreen
        {
            pos.y = screenLimit;
        }
        else if (pos.y < -screenLimit)
        {
            pos.y = -screenLimit;
        }
        transform.position = pos;

        */
    }
    //ZEV End
}
