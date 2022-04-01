using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BallControls : MonoBehaviour
{


    public float speed = 0F; //im just trying to find speed and return it

    public TextMeshProUGUI Text;


    public float speedConst = 25F; //the speed i want to set bal to on all colls

    private Rigidbody2D rb2d;

   

    public float additive = 1F;  //multiplicative is too chaotic and builds too quickly
    public float direction = 1F; // dont touch this it just does the stuff 
    public float multiplicative = 1F; //multiplies forces on collisions 
    void StartingBallDirection()
    {
        //Pick random starting direction for when a new ball is put into play
        float rand = Random.Range(0, 1);

        if (rand < 0.5)
        {
            //Push Right
            rb2d.AddForce(new Vector2(200, -100));
        }
        else
        {
            //Push Left
            rb2d.AddForce(new Vector2(-200, -100));
        }
    }

    void ResetBall()
    {
        //Returns ball to center of screen
        rb2d.velocity = Vector2.zero;
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



           
                if (rb2d.velocity.x > 0)
                { direction = 1; }   //zach's experiment
                else
                { direction = -1; }
       


            Vector2 vel;
            vel.x = speedConst * direction;
                //((rb2d.velocity.x) + (additive * direction)) * multiplicative;

            
                if (rb2d.velocity.y > 0)
                { direction = 1; }   //zach's experiment
                else
                { direction = -1; }



            vel.y = ((rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3));
                //+ (additive * direction)) * multiplicative;
            rb2d.velocity = vel;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

        //Calls function after 3 seconds
        Invoke("StartingBallDirection", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
        speed = Mathf.Sqrt(Mathf.Pow(rb2d.velocity.x, 2) + Mathf.Pow(rb2d.velocity.y, 2));

        Debug.Log(speed.ToString());
    
        
      // Text = speed.ToString;

    }
}
