using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Store : MonoBehaviour
{
    //CJG Start
    public Text StoreMenu;
    int player2Score = 0;
    int size = 0;
    int bsize = 0;
    int speed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //StoreMenu.text = "Paddle Size: " + paddleSize.ToString();
        StoreMenu.text = $"Paddle Size:{size}\n" +
                         $"Ball Size:{bsize}\n" +
                         $"Speed: {speed}";
    }
    //CJG End
}
