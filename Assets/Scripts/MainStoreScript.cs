using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainStoreScript : MonoBehaviour
{
    public Text StoreMenu;
    float speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject displaything = GameObject.Find("SpeedTest");
        SpeedDisplay speedDis = displaything.GetComponent<SpeedDisplay>();

        speed = speedDis.speed1;
        speed = speed - 6;


        StoreMenu.text = $"Item Shop\n" +
                         $"#\n" +
                         $"\n" +
                         $"$\n" +
                         $"speed: {speed}";
    }
}
