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

    private Coroutine shooting;

    public void StartShooting() {
        this.shooting = StartCoroutine(FirePeriodically());
    }

    public void StopShooting() {
        StopCoroutine(this.shooting);
    }

    protected IEnumerator FirePeriodically()
    {
        while(true) {
            yield return new WaitForSeconds(waitTime);
            SpawnBall();
        }
    }

    void SpawnBall() {
        Cannonball cb = Instantiate<Cannonball>(cannonball, this.transform.position, Quaternion.identity);
        cb.transform.SetParent(this.transform.parent.parent);
        cb.SetProperties(speed, damage);
        cb.SetPoints(this.gameObject, this.endpoint);
    }
}
