using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    Rigidbody rd;

    public bool colision = false;
    public bool aplicoFuerza = false;
    public Car car;
    // Start is called before the first frame update
    void Start()
    {

        rd = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        colision = car.choque;

        if (colision && !car.choqueFin)
        {
            aplicoFuerza = true;
            rd.AddForce(Vector3.back * 10);
        }
    }

}
