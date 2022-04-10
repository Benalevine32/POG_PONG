using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2_Goal : MonoBehaviour
{
    public static P2_Goal instance;
    public Text P2_Score;
    public int P2Score=0;
   
    public void AddP2()
    {
        P2Score++;
        P2_Score.text = P2Score.ToString();
    }
    private void Awake()
    {
        instance = this;
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
