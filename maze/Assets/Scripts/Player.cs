using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    private bool dead = false;
    private int coinCounter;
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if dead and ifso transform player to respawnpoint
       if(dead)
        {
            this.transform.position = respawnPoint.transform.position;
            dead = false;
        }
    }

    public void KillPlayer(){
        dead = true;
    }
    public void ChangeRespawnPoint(Transform NewPoint){
        this.respawnPoint = NewPoint.transform;
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Coin")) {
            this.coinCounter++;
            Debug.Log("Collected a coin!");
        }
    }
}
