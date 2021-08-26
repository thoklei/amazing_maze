using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    void FixedUpdate() {
    
        ControlRotation();

    }

    void ControlRotation() {
        float roll = Input.GetAxis("Roll");
        float pitch = Input.GetAxis("Pitch");
        float yaw = Input.GetAxis("Yaw"); 

        float damp = 0.3f; // dampening factor to slow down movement enough to maintain proper collisions

        this.transform.Rotate(pitch*damp, yaw*damp, roll*damp, Space.World);
    }
}