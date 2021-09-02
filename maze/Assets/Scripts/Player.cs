using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    private bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
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

    public void KillPlayer()
    {
        dead = true;
    }
}
