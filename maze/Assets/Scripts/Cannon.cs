using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField] GameObject cannonball;

    int waitTime = 5; // seconds in between shots

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
        GameObject cb = Instantiate(cannonball, this.transform.position, Quaternion.identity);
        cb.transform.SetParent(this.transform);
    }
}
