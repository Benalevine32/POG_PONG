using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject ball;

     
        

// Start is called before the first frame update
void Start()
    {
        Debug.Log("Ball Created");
        Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //Create new ball on keypress
        if (Input.GetKeyUp(KeyCode.T))
        {
            Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
        }
    }
}