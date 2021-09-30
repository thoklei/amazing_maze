
using UnityEngine;

public abstract class CheckpointBehaviour : MonoBehaviour
{
    protected CheckPoint checkPoint;

    abstract public void OnActivate();
    abstract public void OnDeactivate();

    void Awake() {
        this.checkPoint = this.GetComponent<CheckPoint>();
    }

    // abstract public void Init();

    // public void SetCheckpoint(CheckPoint checkpoint) {
    //     this.checkPoint = checkpoint;
    //     Init();
    // }
    
}
