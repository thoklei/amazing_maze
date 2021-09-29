using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public CheckPoint[] checkpoints;
    private CheckPoint _latestCheckpoint;

    void Start() {

        // connect all checkpoints to this manager
        foreach(CheckPoint checkPoint in checkpoints) {
            checkPoint.manager = this;
        }

        // add behaviours to their respective checkpoints
        checkpoints[0].AddBehaviour(new MusicBehavior("song0"));
        
        checkpoints[1].AddBehaviour(new MusicBehavior("song1"));
        
        checkpoints[2].AddBehaviour(new MusicBehavior("song2"));
        checkpoints[2].AddBehaviour(new CannonBehaviour());
        
        checkpoints[3].AddBehaviour(new MusicBehavior("song3"));
        
        checkpoints[4].AddBehaviour(new MusicBehavior("song4"));
        checkpoints[4].AddBehaviour(new GhostBehaviour());
        
        checkpoints[5].AddBehaviour(new MusicBehavior("song5"));
        
        checkpoints[6].AddBehaviour(new MusicBehavior("victory"));

        _latestCheckpoint = checkpoints[0]; // init latest checkpoint
        Activate(_latestCheckpoint);
    }

    void Update() {
        
    }

    public void Activate(CheckPoint checkPoint) {
        _latestCheckpoint.Deactivate();
        _latestCheckpoint = checkPoint;
        _latestCheckpoint.Activate();
    }

    public Vector3 GetRespawnTransform() {
        return _latestCheckpoint.transform.position;
    }


}
