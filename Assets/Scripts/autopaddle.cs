using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autopaddle : MonoBehaviour
{


    //Set speed and screen limits for paddles
    
    public float screenLimit = 4f;

    private Rigidbody2D auto;   // thisssisisisisTHISSIS





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        var pos = transform.position;



        





        if (pos.y == 4F)// auto moves up?
        {

                while (pos.y != -4f)
                {

                pos.y = pos.y - 0.1f;



            }


        }
        else if (pos.y == -4f)
        {
            while (pos.y != 4f)
            {

                 pos.y = pos.y + 0.1f;

    
            }
        }
       
        





    }


}
