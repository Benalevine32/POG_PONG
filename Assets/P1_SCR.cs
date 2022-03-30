using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMpro;

public class P1_SCR : MonoBehaviour
{
    public TextMeshProUGUI P1_SCR;
    // Start is called before the first frame update
    void Start()
    {
        P1_SCR = FindObjectOfType<TextMeshProUGUI>;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
