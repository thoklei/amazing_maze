using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserdoor : MonoBehaviour
{
    private bool inactive;

    // Start is called before the first frame update
    void Start()
    {
        inactive = false;
    }
    

    // activated laserdoor kills player
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player")){
            Audiomanager.instance.Play("zap");
            Destroy(other.gameObject);
        }
    }

    public void turnoff()
    {
        //inactive = true;
        this.gameObject.SetActive(false);

    }
    
}
