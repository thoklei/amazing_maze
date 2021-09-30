using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GhostBoss : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    [SerializeField] private Player ball;
    [SerializeField] private GameLogic _gameLogic;
    [SerializeField] private Transform _ref;

    private int waypointIdx;
    private float dist;
    private float playerdist;
    
    public bool chasing;
    private Vector3 referenceVec;
    private Component[] _cannons;

    // Start is called before the first frame update
    void Start()
    {
        _cannons = this.GetComponents(typeof(Cannon));
        waypointIdx = 0;
        chasing = false;
        transform.LookAt(waypoints[waypointIdx].position);
    }

    public void StartChasing()
    {
        chasing = true;
    }

    public void StopChasing()
    {
        chasing = false;
    }


    private void Update()
    {
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
        else Hunt();

    }

    void Patrol()
    {
        //look at next waypoint
        transform.LookAt(waypoints[waypointIdx].position, _ref.position);
        // move towards waypoint
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // disable cannons
        foreach (Cannon cannon in _cannons)
            cannon.enabled = false;
    }

    public void Hunt()
    {
        Attack();
        // look at player
        transform.LookAt(ball.transform.position, _ref.position);
        // move towards player, but keep distance
        if(Vector3.Distance(this.transform.position ,ball.transform.position)>playerdist)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Attack()
    {
        // arm cannons
        foreach (Cannon cannon in _cannons)
            cannon.enabled = true;
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
        if (other.tag.Equals("Player"))
        {
            ball.Damage(150);
        }
    }
}