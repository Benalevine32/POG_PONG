using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance;
    int P1Score;
    int P2Score;
    public Text P1_Score;
    public Text P2_Score;


    public void PTS1() 
    {
        P1Score = P1Score + 25;
        P1_Score.text = P1_Score.ToString();
    }
    public void PTS2()
    {
        P2Score = P2Score + 25;
        P2_Score.text = P2_Score.ToString();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
