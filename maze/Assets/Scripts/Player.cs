using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int coinCounter;

    public int health;
    
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = 0;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Coin")) {
            this.coinCounter++;
            Debug.Log("Collected a coin!");
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
            Debug.Log(volume);
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
        Debug.Log("Wasted.");
        // entry point for end-game logic for Chris
    }


}
