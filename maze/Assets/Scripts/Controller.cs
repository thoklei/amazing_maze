using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    void FixedUpdate() {
    
        Rotate();

    }

    void Rotate() {
        float roll = Input.GetAxis("Roll");
        float pitch = Input.GetAxis("Pitch");
        float yaw = Input.GetAxis("Yaw"); 

        float factor = 2;

        rb.AddTorque(factor*pitch, factor*yaw, factor*roll, ForceMode.Acceleration);
    }
}