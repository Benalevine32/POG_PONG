using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    // Start is called before the first frame update
   
    //ZEV Start


    public float speed1 = 7F;

    public int numSpeedIncreases = 1;

    public int plyr1Score = 0;
    public int player1Points = 0;
    public int plyr2Score = 0;
    public int player2Points = 0;


    void Start()
    {



        
    }

    // Update is called once per frame
    void Update()
    {


        //press up arrow to increment speed by 1
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            speed1++;

            Debug.Log("speed is " + speed1.ToString());

        }
        //press down aarow to decrement speed by 1; 
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            speed1--;


            Debug.Log("speed is " + speed1.ToString());

        }




        //ZEV End
    }
}
