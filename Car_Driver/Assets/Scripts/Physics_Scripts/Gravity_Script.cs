using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Script : MonoBehaviour
    //handles basic gravity
{
    public float Gravity_Speed = 0.5f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.y > 0)
        {
            transform.Translate(Vector3.up * -Gravity_Speed * Time.deltaTime);
        }
        
    }
}
