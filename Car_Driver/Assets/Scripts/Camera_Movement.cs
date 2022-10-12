using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    //public GameObject Camera;

    public GameObject Player_Vehicle;

    public GameObject Alternate_Camera;

    public Vector3 Camera_Offset = new Vector3(0f, 4f, -6f);

    public bool Camera_Switch = true;

    
    // Start is called before the first frame update
    void Start()
    {
        //Camera = GameObject.Find("Main Camera");

        Player_Vehicle = GameObject.Find("Vehicle_Truck");

        Alternate_Camera = GameObject.Find("FP_Camera");
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Handles camera switch trigger
        if (Input.GetKey("f"))
        {
            Camera_Switch = false;
        }
        else if (Input.GetKey("t"))
        {
            Camera_Switch = true;
        }

        //handles camera position based on camera switch value
        if (Camera_Switch == true)
        {
            transform.position = Player_Vehicle.transform.position + Camera_Offset;
        }
        else if(Camera_Switch == false)
        {
            transform.position = Alternate_Camera.transform.position;
        }

        

        


    }

    
}
