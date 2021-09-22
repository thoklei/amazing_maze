using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    //private Rigidbody rb;
    // Start is called before the first frame update

    //[SerializeField] private RigidIbody playerRB;

    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
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
        float roll = Input.GetAxis("Roll");   // a d
        float pitch = Input.GetAxis("Pitch"); // s w
        float yaw = Input.GetAxis("Yaw");  // q e

        float factor = 0.001F;

        Vector3 rotation = new Vector3(pitch *factor, yaw*factor, roll*factor);
        //transform.rotation = new Quaternion(pitch*factor,0, roll*factor,1) * transform.rotation;

        transform.RotateAround(new Vector3(0, 0, 0), rotation, 1);

        //rb.AddTorque(factor*pitch, factor*yaw, factor*roll, ForceMode.Acceleration);

        // add extra force to player
        //Vector3 playerVec = new Vector3(-1 * roll, yaw, pitch) * 20;
        //playerRB.AddForce(playerVec, ForceMode.Force);
        // Debug.DrawLine(playerRB.transform.position, playerRB.transform.position + playerVec, Color.green, 2, false);
    }


}