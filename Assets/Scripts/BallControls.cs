using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody2D ballRB2D;

     
    

    //zev start
    float speed = 7F;
    int direction = 1;

    public int counter = -3;

    //zev end

    //CJG Start
    void StartingBallDirection()
    {
        //Pick random starting direction for when a new ball is put into play
       // float rand = Random.Range(0, 1);

        //zev added counter
        if (counter < 0)
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


        //zev added counter
        transform.position = new Vector2(0, counter);





    }

    void Restart()
    {
        //Resets ball / determines start direction again
        ResetBall();
        Invoke("StartingBallDirection", 1); //Invoke calls given function after given time in seconds
    }
    //CJG End
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider.CompareTag("Player") )
        {
            Vector2 vel;
            //zev start
           if( ballRB2D.velocity.x > 0)
            {
                direction = 1; 

            }
            else
            {
                direction = -1; 

            }
          //zev added const speed and direction
            vel.x = speed * direction;
            vel.y = (ballRB2D.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3); /*When ball hits paddles, changes
                                                                                               * y direction to allow for hit
                                                                                               *placements */
            ballRB2D.velocity = vel;

        }
        //zev start
        if ( coll.collider.CompareTag("Ball")) //half speed ball collision
        {
            Vector2 vel;

            if (ballRB2D.velocity.x > 0)
            {
                direction = 1;

            }
            else
            {
                direction = -1;

            }
            vel.x = speed/2 * direction;
            vel.y = (ballRB2D.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3); /*When ball hits paddles, changes
                  //zev end                                                                             * y direction to allow for hit
                                                                                               *placements */
            ballRB2D.velocity = vel;

        }

        if ((coll.collider.CompareTag("Left")) || (coll.collider.CompareTag("Right")))
        {
            //Deletes ball when it hits left or right wall, and creates new one
            GameObject displaything = GameObject.Find("SpeedTest");
            SpeedDisplay speedDis = displaything.GetComponent<SpeedDisplay>();


            if ((coll.collider.CompareTag("Left")))
            {
                //player 2 gains 2 points
                
                speedDis.plyr2Score++;
                speedDis.plyr2Score++;

                    
            }

            if ((coll.collider.CompareTag("Right")))
            {
                speedDis.plyr1Score++;
                speedDis.plyr1Score++;


                //player 1 gains 2 points


            }


            //would be cool if balls didnt spawn on top of eachother
            //have a counter running in another script that goes up on each frame and resets at 3 to -3
            //when ball is reset, convert that counter to vector

            //zev start
            ResetBall();
            Invoke("StartingBallDirection", 1);             //no logner destroys ball at all.... we can keep track of speed easier
            //zev end 

            //Instantiate(ballRB2D, new Vector2(0, counter), Quaternion.identity);
            // Destroy(ballRB2D.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        //Ball.Color nuts = Color.black; 



        SpriteRenderer Ball_SpriteRenderer;







        GameObject displaything = GameObject.Find("SpeedTest");


        SpeedDisplay speedDis = displaything.GetComponent<SpeedDisplay>();

        speed = speedDis.speed1;




        Ball_SpriteRenderer = GetComponent<SpriteRenderer>();

        //Ball_SpriteRenderer.color = Color.HSVToRGB(1F,  ((speed/30) - (10 / 30)), 1F); //HSV Color
        Color ballColor = new Color(1, (1 - ((speed - 10) / 30)), (1 - ((speed - 10) / 30)), 1f); //RGB Color
        Ball_SpriteRenderer.color = ballColor;


        //zev is trying so hard to yoink that variable but unity is uncooperative 




        //speed = 


        //i want the speed from player controls......
        // speed = 



        //////////////////////////initialize speed 
        ///i want a speed variable stored somewhere else and visisble to player and interactible with player


        ballRB2D = GetComponent<Rigidbody2D>();

        //Calls function after 3 seconds
        Invoke("StartingBallDirection", 3);
    }

    // Update is called once per frame
    void Update()
    {

        //zev added this beautiful piece of code
        if (counter < 3)
        {
            counter++;
            counter++;

        }
        else
        {
            counter = -3;

        }

    }
}
