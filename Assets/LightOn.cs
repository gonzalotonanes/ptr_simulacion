using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public Light lightGreen;
    public Light lightRed;



    public Car CarStopped;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

        lightRed.enabled = !lightRed.enabled;
        //StartCoroutine(ExecuteAfterTime());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2);

        // Code to execute after the delay
        lightRed.enabled = !lightRed.enabled;
        CarStopped.speed = 0;
    }
}
