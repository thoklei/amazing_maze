using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] Cannonball cannonball;
    [SerializeField] GameObject endpoint;

    [SerializeField] float waitTime = 5.0f; // seconds in between shots
    [SerializeField] float speed = 0.01f;
    [SerializeField] int damage = 25;

    private Coroutine shooting;

    private List<Cannonball> projectiles; // list of currently active cannonballs

    void Start() {
        projectiles = new List<Cannonball>();
    }

    public void StartShooting() {
        Debug.Log("Cannon started shooting");
        this.shooting = StartCoroutine(FirePeriodically());
    }

    public void StopShooting() {
        StopCoroutine(this.shooting);
        Debug.Log("Stoppoing");
        foreach(Cannonball cb in this.projectiles) {
            Debug.Log("Cannonball: " + cb);
            if(cb != null) {
                Debug.Log("not null, deleting");
                Destroy(cb.gameObject);
            }
        }
        this.projectiles.Clear();
    }

    protected IEnumerator FirePeriodically()
    {
        while(true) {
            yield return new WaitForSeconds(waitTime);
            SpawnBall();
        }
    }

    void SpawnBall() {
        Audiomanager.instance.Play("cannon_shot");
        Cannonball cb = Instantiate<Cannonball>(cannonball, this.transform.position, Quaternion.identity);
        cb.transform.SetParent(this.transform.parent.parent);
        cb.SetProperties(speed, damage);
        cb.SetPoints(this.gameObject, this.endpoint);
        this.projectiles.Add(cb);
    }
}
