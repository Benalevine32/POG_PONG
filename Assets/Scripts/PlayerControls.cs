
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public GameObject Ball;


  

    // Start is called before the first frame update
    void Start()
    {
        //CJG Start
        Debug.Log("Ball Created");
        Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);

        //CJG End

    }

    // Update is called once per frame
    void Update()
    {

        //CJG Start

        //Create new ball on keypress
        if (Input.GetKeyUp(KeyCode.T))
        {
            Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);
        }

        //CJG End
    }
}
