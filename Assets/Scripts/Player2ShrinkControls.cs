using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2ShrinkControls : MonoBehaviour
{
    private Vector3 shrinkSize = new Vector3(0f, -0.05f, 0f);

    public void shrink() //cb
    {
        transform.player1Paddle += shrinkSize; // shrinks your opponents paddle player 1
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha7)) // Shrinks the opponets paddle - CB
        {
            if ((speedDis.player2Points) >= paddleUpgradePrice)
            {
                paddleX.shrink();
                speedDis.player2Points -= paddleUpgradePrice;
                paddleUpgradePrice *= 2;
            }
        }

    }
}