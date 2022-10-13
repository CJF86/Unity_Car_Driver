using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Camera : MonoBehaviour
{
    //This script handles the position of the game object that is tied to the first person camera

    public GameObject Player_Vehicle;

    public GameObject Camera_Pos;

    public Vector3 Camera_Location = new Vector3(0, 2.5f, 1.5f);
    
    void Start()
    {
        //Finds gameobject of the player and the game object of the first person camera container

        Player_Vehicle = GameObject.Find("Vehicle_Truck");

        Camera_Pos = GameObject.Find("FP_Camera");
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera_Pos.transform.position = Player_Vehicle.transform.position + Camera_Location;
        
    }
}
