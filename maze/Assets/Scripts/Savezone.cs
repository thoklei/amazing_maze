using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savezone : MonoBehaviour
{
    [SerializeField] Ghost ghost;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            ghost.chasing = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            ghost.chasing = true;
            Audiomanager.instance.Play("ghost");
        }
    }
}