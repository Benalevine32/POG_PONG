using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1ScorePoints : MonoBehaviour
{
    public Text ScorePoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject displaything = GameObject.Find("SpeedTest");
        SpeedDisplay speedDis = displaything.GetComponent<SpeedDisplay>();


        ScorePoints.text = $"{speedDis.plyr1Score}\n" +
                           $"{speedDis.player1Points}";
    }
}
