using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Store : MonoBehaviour
{
    //CJG Start
    public Text StoreMenu;
    public GameObject Ball;
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

        GameObject paddle = GameObject.Find("paddle2");
        Paddle2Controls paddleX = paddle.GetComponent<Paddle2Controls>();

        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            if ((speedDis.player2Points) >= speedUpgradePrice)
            {
                speedDis.speed1 += 1;
                speedDis.player2Points -= speedUpgradePrice;
                speedUpgradePrice *= 2;
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            if ((speedDis.player2Points) >= ballIncreasePrice)
            {
                Instantiate(Ball, new Vector2(0, 0), Quaternion.identity);
                speedDis.player2Points -= ballIncreasePrice;
                ballIncreasePrice *= 2;
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            if ((speedDis.player2Points) >= paddleUpgradePrice)
            {
                paddleX.Grow();
                speedDis.player2Points -= paddleUpgradePrice;
                paddleUpgradePrice *= 2;
            }
        }


        //StoreMenu.text = "Paddle Size: " + paddleSize.ToString();
        StoreMenu.text = $"[8]Speed++:{speedUpgradePrice}\n" +
                         $"[9]Ball Count:{ballIncreasePrice}\n" +
                         $"[0]Paddle Size:{paddleUpgradePrice}";
    }
    //CJG End
}
