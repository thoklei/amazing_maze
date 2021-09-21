using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int coinCounter;
    [SerializeField] private Transform respawnPoint;
    private bool dead = false;


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
