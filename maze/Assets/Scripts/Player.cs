using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private CheckpointManager checkpointManager;
    public int coinCounter;
    public int deathCounter;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        coinCounter = 0;
        health = 100;
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Coin")) {
            this.coinCounter++;
        } else if(other.tag.Equals("cannonball")) {
            Cannonball cb = other.gameObject.GetComponent<Cannonball>();
            this.Damage(cb.damage);
        }

    }
    
    private void OnCollisionEnter(Collision other)
    {
        // if ball hits wall play sound - volume depending on impaact
        if (other.gameObject.CompareTag("wall"))
        {
            var volume = other.relativeVelocity.magnitude/50;
            volume = Mathf.Clamp(volume, 0, 1);
            Audiomanager.instance.Play("wallhit",volume);
        }
    }

    public void Damage(int damage) {
        this.health -= damage;
        if(this.health <= 0) {
            Death();
        }
    }

    private void Death() {
        this.transform.position = checkpointManager.GetRespawnTransform();
        this.health = 100;
        this.deathCounter++;
    }
}

