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
}
