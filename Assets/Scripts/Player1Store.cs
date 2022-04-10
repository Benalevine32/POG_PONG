using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Store : MonoBehaviour
{
    //CJG Start
    public GameObject Ball;
    public Text StoreMenu;
    int speedUpgrade = 0;
    int ballUpgrade = 0;
    int paddleUpgrade = 0;
    int speedUpgradePrice = 250;
    int ballIncreasePrice = 250;
    int paddleUpgradePrice = 250;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject displaything = GameObject.Find("SpeedTest");
        SpeedDisplay speedDis = displaything.GetComponent<SpeedDisplay>();

        GameObject paddle = GameObject.Find("paddle1");
        Paddle1Controls paddleX = paddle.GetComponent<Paddle1Controls>();

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if ((speedDis.player1Points) >= speedUpgradePrice)
            {
                speedDis.speed1 += 1;
                speedDis.player1Points -= speedUpgradePrice;
                speedUpgradePrice *= 2;
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            if ((speedDis.player1Points) >= ballIncreasePrice)
            {
                Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);
                speedDis.player1Points -= ballIncreasePrice;
                ballIncreasePrice *= 2;
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            if ((speedDis.player1Points) >= paddleUpgradePrice)
            {
                paddleX.Grow();
                speedDis.player1Points -= paddleUpgradePrice;
                paddleUpgradePrice *= 2;
            }
        }


        //StoreMenu.text = "Paddle Size: " + paddleSize.ToString();
        StoreMenu.text = $"[1]Speed++:{speedUpgradePrice}\n" +
                         $"[2]Ball Count:{ballIncreasePrice}\n" +
                         $"[3]PaddleSize:{paddleUpgradePrice}";
    }
    //CJG End
}
