using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Store : MonoBehaviour
{
    //CJG Start
    public Text StoreMenu;
    int player1Score = 0;
    int speedUpgrade = 0;
    int ballUpgrade = 0;
    int paddleUpgrade = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //StoreMenu.text = "Paddle Size: " + paddleSize.ToString();
        StoreMenu.text = $"[1]Speed++:{speedUpgrade}\n" +
                         $"[2]Ball Count:{ballUpgrade}\n" +
                         $"[3]Ball Speed:{paddleUpgrade}";
    }
    //CJG End
}
