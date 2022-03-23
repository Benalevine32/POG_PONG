using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour
{

    private Rigidbody2D ball;

    void StartingBallDirection()
    {
        //Pick random starting direction for when a new ball is put into play
        float rand = Random.Range(0, 1);

        if (rand < 0.5)
        {
            //Push Right
            ball.AddForce(new Vector2(200, -100));
        }
        else
        {
            //Push Left
            ball.AddForce(new Vector2(-200, -100));
        }
    }

    void ResetBall()
    {
        //Returns ball to center of screen
        ball.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void Restart()
    {
        //Resets ball and determines start direction again
        ResetBall();
        Invoke("StartingBallDirection", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = ball.velocity.x;
            vel.y = (ball.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            ball.velocity = vel;

        }

        if ((coll.collider.CompareTag("Left")) || (coll.collider.CompareTag("Right")))
        {
            //Deletes ball when it hits left or right wall, and creates new one
            Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
            Destroy(ball.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        ball = GetComponent<Rigidbody2D>();

        //Calls function after 3 seconds
        Invoke("StartingBallDirection", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
