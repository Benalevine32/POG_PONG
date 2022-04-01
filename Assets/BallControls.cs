using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody2D ballRB2D;

    float speed = 25F;
    int direction = 1; 
    
    void StartingBallDirection()
    {
        //Pick random starting direction for when a new ball is put into play
        float rand = Random.Range(0, 1);

        if (rand < 0.5)
        {
            //Pushes ball Right
            ballRB2D.AddForce(new Vector2(200, -100));
        }
        else
        {
            //Pushes ball Left
            ballRB2D.AddForce(new Vector2(-200, -100));
        }
    }

    void ResetBall()
    {
        //Returns ball to center of screen
        ballRB2D.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void Restart()
    {
        //Resets ball / determines start direction again
        ResetBall();
        Invoke("StartingBallDirection", 1); //Invoke calls given function after given time in seconds
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider.CompareTag("Player") || coll.collider.CompareTag("Ball"))
        {
            Vector2 vel;

           if( ballRB2D.velocity.x > 0)
            {
                direction = 1; 

            }
            else
            {
                direction = -1; 

            }
            vel.x = speed * direction;
            vel.y = (ballRB2D.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3); /*When ball hits paddles, changes
                                                                                               * y direction to allow for hit
                                                                                               *placements */
            ballRB2D.velocity = vel;

        }

        if ((coll.collider.CompareTag("Left")) || (coll.collider.CompareTag("Right")))
        {
            //Deletes ball when it hits left or right wall, and creates new one
            Instantiate(ballRB2D, new Vector2(0, 0), Quaternion.identity);
            Destroy(ballRB2D.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
     
        //////////////////////////initialize speed 
        ///i want a speed variable stored somewhere else and visisble to player and interactible with player


        ballRB2D = GetComponent<Rigidbody2D>();

        //Calls function after 3 seconds
        Invoke("StartingBallDirection", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
