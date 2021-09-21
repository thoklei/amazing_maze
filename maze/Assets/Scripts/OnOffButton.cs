using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffButton : MonoBehaviour
{

    [SerializeField] private Laserdoor door;

    [SerializeField] private GameObject partner;

    // when ball touches button, deactivate door and this button, activte other button
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            door.turnoff();
            this.gameObject.SetActive(false);
            partner.gameObject.SetActive(true);
            Audiomanager.instance.Play("button");
        }
    }
}
