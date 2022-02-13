using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float x;
    public float y;
    
    void Start() {
        x=0f;
        y=0f;
    }

    void Update()
    {   
        
        if (Input.GetKey("a"))
        {
            x = x - 5f;
        }

        if (Input.GetKey("d"))
        {
            x = x + 5f;
        }

        x = x*0.8f;
        gameObject.transform.Translate(x*Time.deltaTime,0,0);

        if (Input.GetKey("w") /*&& Sensor.colisiona*/)
        {
            gameObject.transform.Translate(0,10*Time.deltaTime,0);
        }
    }
}
