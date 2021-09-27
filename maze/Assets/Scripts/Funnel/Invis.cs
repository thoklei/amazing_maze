using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invis : MonoBehaviour
{
    // ball invisible when entering funnel
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().enabled = false;
    }
    
    
    // ball visible when leaving funnel
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Renderer>().enabled = true;
        }
    }

}
