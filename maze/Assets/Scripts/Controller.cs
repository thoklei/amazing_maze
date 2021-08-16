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
        float pitch = -1 * Input.GetAxis("Vertical");
        float roll = -1 * Input.GetAxis("Horizontal");
        this.transform.Rotate(pitch, 0, roll, Space.Self);
    
    }
}