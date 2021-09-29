
using UnityEngine;

public abstract class CheckpointBehaviour
{
    protected CheckPoint checkPoint;

    abstract public void OnActivate();
    abstract public void OnDeactivate();

    abstract public void Init();

    public void SetCheckpoint(CheckPoint checkpoint) {
        this.checkPoint = checkpoint;
        Init();
    }
    
}
