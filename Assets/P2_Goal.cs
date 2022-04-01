using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2_Goal : MonoBehaviour
{
    public Text P2_Score;
    public int P2Score;
    public GameObject ball;


    void OnCollisionEnter2D(Collision2D ball)
    {
        if (ball.collider.CompareTag("Left"))
        {
            P2Score++;
            P2_Score.text = P2Score.ToString();

        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        P2Score = 0;
        P2_Score.text = P2Score.ToString();
      


    }

        // Update is called once per frame
       void Update()
        {
            P2_Score.text = P2Score.ToString();

        }
    
}






/*
void OnCollisionEnter2D(Collision2D coll)
{
    if (coll.collider.CompareTag("Left"))
    {
        P2Score++;
        P2_Score.text = P2Score.ToString();

    }
}
*/
