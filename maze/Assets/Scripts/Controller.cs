using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 rotationVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = -1 * Input.GetAxis("Vertical");
        float roll = -1 * Input.GetAxis("Horizontal");
        rotationVector = new Vector3(pitch,0f,roll);
        this.transform.RotateAround(transform.parent.position, rotationVector,0.1f);
    
    }
}