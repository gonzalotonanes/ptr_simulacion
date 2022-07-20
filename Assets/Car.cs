using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    /* public List<AxleInfo> axleInfos; // the information about each individual axle

     public float maxMotorTorque; // maximum torque the motor can apply to wheel
     public float maxSteeringAngle; // maximum steer angle the wheel can have
     public float motor;
     public float steering;
     */
    public bool choque = false;
    public bool choqueFin = false;
    public float speed =5f;
    

    // Start is called before the first frame update
    private Rigidbody driver;

    private void Start()
    {
        driver = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // motor = maxMotorTorque * Input.GetAxis("Vertical");
        
        // steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        if (!choque)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        
        switch (collision.gameObject.name)
        {
          
           case "Car1": choque = true; break;
           case "Car2": choque = true; break;
           case "Car3": choque = true; break;
           case "Car4": choque = true; break;
           case "Car5": choque = true; break;
           case "Car6": choque = true; break;
           
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        switch (collision.gameObject.name)
        {

            case "Car1": choqueFin = true; break;
            case "Car2": choqueFin = true; break;
            case "Car3": choqueFin = true; break;
            case "Car4": choqueFin = true; break;
            case "Car5": choqueFin = true; break;
            case "Car6": choqueFin = true; break;

        }
    }


}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}