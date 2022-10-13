using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    //this script controls the third person camera following the plane/switching between first/third person

    public GameObject Player_Plane;

    public GameObject Main_Camera;

    public GameObject FP_Location;

    public Vector3 Offset_Distance = new Vector3(0, 13, -16);

    public bool Camera_Toggle = true;

    public bool Angle_Switch;

    void Start()
    {
        Player_Plane = GameObject.Find("Plane");

        Main_Camera = GameObject.Find("Main Camera");

        FP_Location = GameObject.Find("FP_Camera");
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKey("f") == true)
        {
            Camera_Toggle = false;

            //return Camera_Toggle;
        }
        else if (Input.GetKey("t"))
        {
            Camera_Toggle = true;

            //return Camera_Toggle;

        }
        

        if(Camera_Toggle == true)
        {
            Main_Camera.transform.position = Player_Plane.transform.position + Offset_Distance;
        }
        else if(Camera_Toggle == false)
        {
            Main_Camera.transform.position = FP_Location.transform.position;
        }
        
        
    }

    

}
