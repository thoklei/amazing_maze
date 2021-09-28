using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public Transform cam;

    public float force = 10f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    private Rigidbody playerRB;
    private Vector3 offset;

    private void Start()
    {
        playerRB = this.GetComponent<Rigidbody>();
        offset = new Vector3(0f, .5f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get Input and calc movement direction 
        float horizontal = -Input.GetAxisRaw("Roll");
        float vertical = Input.GetAxisRaw("Pitch");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        // move Character 
        if (direction.magnitude >= 0.1f)
        {
            // face character into direction of movement - smoothly
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            // move in direction
            playerRB.AddForceAtPosition(new Vector3(cam.right.x, 0, cam.right.z).normalized * horizontal*force,this.transform.position + offset);
            playerRB.AddForceAtPosition(new Vector3(cam.forward.x, 0, cam.forward.z).normalized * vertical*force, this.transform.position + offset);
            
           
        }
    }
}
