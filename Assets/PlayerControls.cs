using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject Ball;

    public float speed1 = 10F;

    public int counter = -5;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ball Created");
        Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {

        
        if( counter < 6)
        {
            counter++;
            counter++;

        }
        else
        {
            counter = -5;

        }

        //press up arrow to increment speed by 1
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            speed1++; 
                
        }
        //press down aarow to decrement speed by 1; 
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            speed1--;

        }

        //Create new ball on keypress
        if (Input.GetKeyUp(KeyCode.T))
        {
            Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);
        }
    }
}
