using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    [SerializeField] private Player ball;
    [SerializeField] private GameLogic _gameLogic;
    [SerializeField] private Transform _ref; 

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

    // activated by checkpoint manager
    public void StartChasing() {
        chasing = true;
    }

    public void StopChasing() {
        chasing = false;
    }
    
    void FixedUpdate()
    {
        // patrol along waypoints, if close enough select next waypoint
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

    // look at waypoint, move forwards. always point head at ref object (up)
    void Patrol()
    {
        transform.LookAt(waypoints[waypointIdx].position, _ref.position);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    // look at player, move forward
    public void Chase()
    {
        transform.LookAt(ball.transform.position, _ref.position);
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
