using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Shrink : MonoBehaviour
{
    private Vector3 shrinkSize = new Vector3(0f, -0.05f, 0f);

    public void shrink() //cb
    {
        transform.player2Paddle += shrinkSize; // shrinks your opponents paddle
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha4)) // Shrinks the opponets paddle - CB
        {
            if ((speedDis.player1Points) >= paddleUpgradePrice)
            {
                paddleX.shrink();
                speedDis.player1Points -= paddleUpgradePrice;
                paddleUpgradePrice *= 2;
            }
        }

    }
}
