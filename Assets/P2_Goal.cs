using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2_Goal : MonoBehaviour
{
    public Text P2_Score;
   public static int P2Score = 0;
    GameObject theBall;
    // Start is called before the first frame update
    void Start()
    {
        P2_Score.text = P2Score.ToString();
    }
    public static void ScoreP2(string WallID)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
 



}


