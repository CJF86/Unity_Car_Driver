using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Follow : MonoBehaviour
{
    //this script handles the offset distance of the first person camera in relation to the plane

    public GameObject Player_Plane;

    public GameObject FP_Location;

    public Vector3 FP_Offset = new Vector3(0, 2, 2);

    // Start is called before the first frame update
    void Start()
    {
        Player_Plane = GameObject.Find("Plane");

        FP_Location = GameObject.Find("FP_Camera");

    }

    // Update is called once per frame
    void LateUpdate()
    {
        FP_Location.transform.position = Player_Plane.transform.position + FP_Offset;

    }
}
