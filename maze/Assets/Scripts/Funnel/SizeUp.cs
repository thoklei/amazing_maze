using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.localScale = new Vector3(2f, 2f, 2f);
        }
    }
}