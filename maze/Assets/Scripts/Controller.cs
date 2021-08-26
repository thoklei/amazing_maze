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
        
    }

    void FixedUpdate() {
        
        ControlRotation();

        // // rotates kinematic rigidbodys, but they rotate independently around their centers
        // // foreach(Rigidbody rb in this.GetComponentsInChildren<Rigidbody>()) {
        // //     Quaternion delta = Quaternion.Euler(roll/5, yaw/5, pitch/5);
        // //     rb.MoveRotation(rb.rotation * delta);
        // // }

        // // will rotate the parent as intended (ie rotates all children around center) but ball falls through
        // // 
        
        // Quaternion delta = Quaternion.Euler(roll, yaw, pitch);
        // Rigidbody rb = this.GetComponent<Rigidbody>();
        // rb.MoveRotation(rb.rotation * delta);
        // // Vector3 torque = transform.up * pitch * 1000f;
        // // rb.AddTorque(torque);
        // // Debug.Log("Torque: " + torque);
    }

    void ControlRotation() {
        float roll = Input.GetAxis("Roll");
        float pitch = Input.GetAxis("Pitch");
        float yaw = Input.GetAxis("Yaw"); 

        this.transform.Rotate(roll/5, yaw/5, pitch/5, Space.World);
    }
}