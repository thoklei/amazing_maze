using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoorBehavior : CheckpointBehaviour
{
    [SerializeField] private Laserdoor _laserdoor;
    public override void OnActivate()
    {
        Debug.Log("activate laserdoor to prevent backtracking");
        _laserdoor.gameObject.SetActive(true);
        _laserdoor.coingoal -= 1;
    }

    public override void OnDeactivate()
    {
        Debug.Log("nothing happens");
    }
}
