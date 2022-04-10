using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControls : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody2D ballRB2D;
   

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

        if (coll.collider.CompareTag("Player1") || coll.collider.CompareTag("Player 2"))
        {
            Vector2 vel;
            vel.x = ballRB2D.velocity.x;
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
            
            if ((coll.collider.CompareTag("Left")))
            {
                Debug.Log("YO");
                P2_Goal.instance.AddP2();
            }
            if ((coll.collider.CompareTag("Right")))
            {
                Debug.Log("YO");
                P1_Goal.instance.AddP1();
            }
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ballRB2D = GetComponent<Rigidbody2D>();

        //Calls function after 3 seconds
        Invoke("StartingBallDirection", 3);
       
    }

    // Update is called once per frame
    void Update()
    {


    }
}


//P2Score++;
//P2_Score.text = P2Score.ToString();