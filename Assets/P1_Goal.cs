using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1_Goal : MonoBehaviour
{
    public Text P1_Score;
    int P1Score=2;

    // Start is called before the first frame update
    void Start()
    {
        P1_Score.text = P1Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
