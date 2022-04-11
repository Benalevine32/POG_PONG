using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autopaddle : MonoBehaviour
{


    //ZEV Start

    //this code is cannibalized code from cole, but im chillin (mine now \_(:D)_/ )

    //Set speed and screen limits for auto paddles
    public float paddleSpeed = 5f;
    public float screenLimit = 4f;
    public bool trueness = false; 

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






        if (pos.y > screenLimit)
        {
            trueness = false;


        }
        
        
        if (pos.y < -screenLimit)
        {
            trueness = true; 
        }

        auto.velocity = vel;




        if (trueness == false)
        {
            vel.y = -paddleSpeed;


        }
        else if (trueness == true)
        {
            vel.y = paddleSpeed;
        }

        auto.velocity = vel;








    }
    //ZEV End
}
