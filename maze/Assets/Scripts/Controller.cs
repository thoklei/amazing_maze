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
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("rotating");
            this.transform.Rotate(0, 0, 2, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("rotating");
            this.transform.Rotate(0, 0, -2, Space.Self);
        }
        
    }
}