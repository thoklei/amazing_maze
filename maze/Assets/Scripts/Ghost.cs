using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    [SerializeField] private Player ball;

    private int waypointIdx;
    private float dist;
    public bool chasing;
    
    // Start is called before the first frame update
    void Start()
    {
        waypointIdx = 0;
        chasing = false;
        transform.LookAt(waypoints[waypointIdx].position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIdx].position);
        if (!chasing)
        {
            if (dist < 0.1f)
            {
                IncreaseIdx();
            }

            Patrol();
        }
        else Chase();

    }

    void Patrol()
    {
        transform.LookAt(waypoints[waypointIdx].position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    public void Chase()
    {
        transform.LookAt(ball.transform.position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    
    // get next waypoint
    public void IncreaseIdx()
    {
        waypointIdx++;
        if (waypointIdx >= waypoints.Length)
        {
            waypointIdx = 0;
        }
        // look at new waypoint
        transform.LookAt(waypoints[waypointIdx].position);
    }
    
    
    // kill player
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            ball.Damage(150);
        }
    }
}
