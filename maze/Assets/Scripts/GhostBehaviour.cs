using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The behaviour that (de)activates the ghost
public class GhostBehaviour : CheckpointBehaviour
{

    private Ghost ghost;
    
    public override void Init() {
        Debug.Log("Running Init");
        ghost = this.checkPoint.gameObject.transform.parent.GetComponentInChildren<Ghost>();
    }
    public override void OnActivate()
    {
        Debug.Log("Activating Ghost");
        ghost.StartChasing();
    }

    public override void OnDeactivate()
    {
        Debug.Log("Deactivating Ghost");
        ghost.StopChasing();
    }
}
