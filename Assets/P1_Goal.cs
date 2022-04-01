using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1_Goal : MonoBehaviour
{
    public Text P1_Score;
    public int P1Score ;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    public void Start() {

        P1Score = 0;
        P1_Score.text = P1Score.ToString();
        rb2d = GetComponent<Rigidbody2D>();

        /*    
            void OnCollisionEnter2D(Collision2D coll)
            {
                if (coll.collider.CompareTag("Right"))
                {
                    P1Score++;
                    P1_Score.text = P1Score.ToString();

                }
            }
         */
    }
        // Update is called once per frame
        void Update()
        {
            P1_Score.text = P1Score.ToString();
        }
    
}
