using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 2f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
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
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);        }
    }
}
