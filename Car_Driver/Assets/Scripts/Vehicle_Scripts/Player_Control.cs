using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float Car_Speed = 20f;

    public float Turn_Speed = 10f;

    public float Speed_Increase = 5f;

    //public float Horizontal_Input;

    //public bool Camera_Switch = true;

    //This script controls the player movement

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal_Input = Input.GetAxis("Horizontal");

        Speed_Control();

        if (Input.GetKey("w") == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Car_Speed);

        }
        else if (Input.GetKey("s") == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Car_Speed);
        }

        if (Input.GetKey("d") == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Turn_Speed);
        }
        else if (Input.GetKey("a") == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -Turn_Speed);
        }




    }

    float Speed_Control()
    {
        //supposed to control speed but does not work correctly

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            Car_Speed += Speed_Increase * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            Car_Speed -= Speed_Increase * Time.deltaTime;
        }


        return Car_Speed;
    }
}
