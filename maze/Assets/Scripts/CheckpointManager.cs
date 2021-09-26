using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public CheckPoint[] checkpoints;
    private CheckPoint _latestCheckpoint;

    // Update is called once per frame
    void Update()
    {
        // TODO: change this into an event based system
        foreach (var checkpoint in checkpoints)
        {
            if (checkpoint.activated)
            {
                _latestCheckpoint = checkpoint;
                
            }
        }
    }

    public Vector3 GetRespawnTransform()
    {
        return _latestCheckpoint.transform.position;
    }
}
