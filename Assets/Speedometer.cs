using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public GameObject player;
    public TMP_Text textInstance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textInstance.text = "Speed: " + MathF.Round(player.GetComponent<Rigidbody>().velocity.magnitude * 3.6f) + " KM/H";

    }
}
