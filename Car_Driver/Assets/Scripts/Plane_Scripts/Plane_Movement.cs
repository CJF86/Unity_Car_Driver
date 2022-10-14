using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Movement : MonoBehaviour

    //This script controls the basic plane movement as well as plane rotation
{
    public GameObject Player_Plane;

    public Transform Plane_Propeller;

    public float Plane_Speed = 20f;

    public float Plane_Rotation = 10f;

    public float Plane_Elevation = 20;

    public float Throttle_Speed = 5.0f;

    private Vector3 True_Rotation = new Vector3(0, 0, 0);

    public float Prop_Speed = 50;

    public float Gravity_Speed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        Player_Plane = GameObject.Find("Plane");

        Plane_Propeller = Player_Plane.transform.Find("Propellor");

        //Plane_Elevation = transform.position.y;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Plane_Throttle();
        Propellor_Rotation();
        Gravity();
        Debug.Log(Plane_Speed);

        if (Input.GetKey("w") == true)
        {
            transform.Translate(Vector3.forward * Plane_Speed * Time.deltaTime);
            Debug.Log("hitting first loop");
        }

        if(Input.GetKey(KeyCode.Space)==true)
        {
            transform.Translate(Vector3.up * Plane_Elevation * Time.deltaTime);
            transform.Rotate(Vector3.right * -Plane_Rotation * Time.deltaTime);
            Debug.Log("Hitting elevation loop");
        }
        else if (Input.GetKey("s")==true)
        {
            transform.Translate(Vector3.up * -Plane_Rotation * Time.deltaTime);
            transform.Rotate(Vector3.right * Plane_Rotation * Time.deltaTime);

        }
       

        if (Input.GetKey("a") == true)
        {
            transform.Rotate(Vector3.forward * Plane_Rotation * Time.deltaTime);
        }

        if (Input.GetKey("d") == true)
        {
            transform.Rotate(Vector3.forward * -Plane_Rotation * Time.deltaTime);
        }

        

        
    }

    public float Plane_Throttle()
        //handles speed control for plane
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            Plane_Speed = Plane_Speed += Throttle_Speed * Time.deltaTime;

            return Plane_Speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            Plane_Speed = Plane_Speed -= Throttle_Speed * Time.deltaTime;

            return Plane_Speed;

        }
        else
        {
            return Plane_Speed;
        }
    }

    public void Propellor_Rotation()
        //handles the animation of the plane propellor
    {
        //Prop_Speed = Plane_Speed * 2;
        Plane_Propeller.transform.Rotate(Vector3.forward * Time.deltaTime * Prop_Speed);
        Debug.Log(Prop_Speed);
    }

    public void Gravity()
    {
        if (transform.position.y > 0)
        {
            transform.Translate(Vector3.up * -Gravity_Speed * Time.deltaTime);
        }
    }
}
