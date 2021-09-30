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
    public float playerdist;
    public bool hunting;
    
    private Vector3 referenceVec;
    private Component[] _cannons;

    // Start is called before the first frame update
    void Start()
    {
        hunting = false;
        // get all cannonscripts
        _cannons = this.GetComponents(typeof(Cannon));
        
    }

    public void StartHunting()
    {
        foreach (Cannon cannon in _cannons)
            cannon.StartShooting();
            hunting = true;
    }

    public void StopHunting()
    {
        foreach (Cannon cannon in _cannons)
            cannon.StopShooting();
            hunting = false;
    }
    

    // 
    void FixedUpdate()
    {
        if (hunting)
        {
            Hunt();
        }
    }
    

    public void Hunt()
    {
        // look at player
        transform.LookAt(ball.transform.position, _ref.position);
        // move towards player, but keep distance
        if(Vector3.Distance(this.transform.position ,ball.transform.position)>playerdist)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
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