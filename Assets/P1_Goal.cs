using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1_Goal : MonoBehaviour
{
    public static P1_Goal instance;
    public Text P1_Score;
    public int P1Score=0;
  


    private void Awake()
    {
        instance = this;
    }
    public void AddP1() 
    {
        P1Score++;
        P1_Score.text = P1Score.ToString();
    }
    

    // Start is called before the first frame update
    public void Start() 
    {

       
        
        
    }
        // Update is called once per frame
        void Update()
        {

        
    }
    
}
