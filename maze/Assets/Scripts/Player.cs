using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int coinCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Coin")) {
            this.coinCounter++;
            Debug.Log("Collected a coin!");
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
}
