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

        float factor = 1F;
        Vector3 rotation = new Vector3(pitch *factor,0, roll*factor);
        //float x = 
        //Quaternion normalized = new Quaternion();

        //transform.RotateAround(transform.localPosition, rotation, 1);
        //transform.Rotate(pitch, 0, roll, Space.Self);

        //rb.AddTorque(factor*pitch, factor*yaw, factor*roll, ForceMode.Acceleration);

        // add extra force to player
        //Vector3 playerVec = new Vector3(-1 * roll, yaw, pitch) * 20;
        //playerRB.AddForce(playerVec, ForceMode.Force);
        // Debug.DrawLine(playerRB.transform.position, playerRB.transform.position + playerVec, Color.green, 2, false);

        var angles = transform.eulerAngles;
        float rotX = angles.x;
        float rotY = angles.y;
        float rotZ = angles.z;

        Quaternion oldRotation = Quaternion.Euler(rotX, 0, rotZ);
        Quaternion newRotation = Quaternion.Euler(pitch * factor, 0, roll * factor);
        Quaternion combinedRotation = oldRotation * newRotation;

        transform.rotation = Quaternion.RotateTowards(oldRotation, combinedRotation , 0.1f);
        //transform.rotation = new Quaternion(x, 0, z, 1);

    }


}