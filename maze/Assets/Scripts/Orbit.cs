using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    private Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = this.transform.parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(ball.position, ball.up, 100*Time.deltaTime);
    }
}
