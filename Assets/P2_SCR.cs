using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMpro;

public class P2_SCR : MonoBehavior
{
    public TextMeshProUGUI P2_SCR;
    // Start is called before the first frame update
    void Start()
    {
        P2_SCR = FindObjectOfType<TextMeshProUGUI>;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
