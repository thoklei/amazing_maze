using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField] Cannonball cannonball;
    [SerializeField] GameObject endpoint;

    [SerializeField] float waitTime = 5.0f; // seconds in between shots

    [SerializeField] float speed = 0.01f;
    [SerializeField] int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My position: " + transform.position);
        StartCoroutine(FirePeriodically());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected IEnumerator FirePeriodically()
    {
        Debug.Log("Firing...");
        while(true) {
            yield return new WaitForSeconds(waitTime);
            Debug.Log("spawning...");
            SpawnBall();
        }
    }

    void SpawnBall() {
        Debug.Log("Spawning Cannon Ball!");
        Cannonball cb = Instantiate<Cannonball>(cannonball, this.transform.position, Quaternion.identity);
        cb.transform.SetParent(this.transform.parent.parent);
        cb.SetProperties(speed, damage);
        cb.SetPoints(this.gameObject, this.endpoint);
    }
}
