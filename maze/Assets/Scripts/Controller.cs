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
        float pitch = Input.GetAxis("Vertical");
        float roll = Input.GetAxis("Horizontal");
        this.transform.Rotate(roll/5, 0, pitch/5, Space.World);
    }
}