using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Laserdoor : MonoBehaviour
{
    [SerializeField] Player ball;
    [SerializeField] int coingoal;
    
    void Update()
    {
        if (ball.coinCounter == coingoal)
        {
            Turnoffinsec(1f);
        }
    }

    // activated laserdoor kills player
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player")){
            Audiomanager.instance.Play("zap");
            Destroy(other.gameObject);
        }
    }

    public void Turnoff()
    {
        //inactive = true;
        this.gameObject.SetActive(false);
        Audiomanager.instance.Play("shutdown");
    }
    
    public void Turnoffinsec(float delay)
    {
        StartCoroutine(DelayAction(delay));
    }
    
    IEnumerator DelayAction(float delay)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delay);
        Turnoff();

        //Do the action after the delay time has finished.
    }
    
}
