using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GhostBoss : MonoBehaviour
{
    public int speed;

    private int health = 100;

    [SerializeField] private Player ball;
    [SerializeField] private GameLogic _gameLogic;
    [SerializeField] private Transform _ref;

    [SerializeField] private Laserdoor door1;
    [SerializeField] private Laserdoor door2;

    private int waypointIdx;
    private float dist;
    public float playerdist;
    public bool hunting;
    
    private Component[] _cannons;

    // Start is called before the first frame update
    void Start()
    {
        hunting = false;
        // get all cannonscripts
        _cannons = this.GetComponents(typeof(Cannon));
        
    }

    // activated by checkpoint manager
    public void StartHunting()
    {
        foreach (Cannon cannon in _cannons) {
            cannon.StartShooting();
        }
        hunting = true;
    }

    public void StopHunting()
    {
        foreach (Cannon cannon in _cannons) {
            cannon.StopShooting();
        }
        hunting = false;
    }
    
    
    void FixedUpdate()
    {
        if (hunting)
        {
            Hunt();
        }
    }
    

    public void Hunt()
    {
        // look at player, head always points towards ref object (up)
        transform.LookAt(ball.transform.position, _ref.position);
        // move towards player, but keep distance
        if(Vector3.Distance(this.transform.position ,ball.transform.position)>playerdist)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    

    // kill player on collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            ball.Damage(150);
        }

        if(other.tag.Equals("explosion")) {
            this.Damage(20);
        }
    }

    private void Damage(int dmg) {
        this.health -= dmg;
        Debug.Log("Got hit: " + health);
        if(this.health <= 0) {
            this.Death();
        }
    }

    private void Death() {
        Debug.Log("ded");
        StopHunting();
        door1.Turnoff();
        door2.Turnoff();
        Destroy(this.gameObject);

    }
}