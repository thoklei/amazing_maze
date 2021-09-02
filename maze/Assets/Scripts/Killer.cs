using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Sphere hit barrier!");
        GameObject.Find("Sphere").GetComponent<Player>().KillPlayer();
    }
}
