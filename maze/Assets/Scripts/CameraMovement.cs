using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] GameObject player;

    Vector3 diffVec;

    // Start is called before the first frame update
    void Start()
    {
        diffVec = new Vector3(50, 30, 0);
        this.transform.rotation = Quaternion.Euler(25,-85,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + diffVec;
    }
}
