using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{

    public CheckpointManager manager;
    [SerializeField] private Image checkpointUI;
    
    private List<CheckpointBehaviour> behaviours;
    private bool activated;
    private bool ready = true; // whether this cp can be activated by rolling into it

    void Awake() {
        behaviours = new List<CheckpointBehaviour>();
        behaviours.AddRange(GetComponents<CheckpointBehaviour>());
        Debug.Log("found behaviors: " + behaviours.Count);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if( ready && !activated && other.CompareTag("Player") ){
            ready = false;
            this.manager.Activate(this);
        }
    }

    public void Activate() {
        activated = true;
        checkpointUI.color = Color.green; // change UI color

        foreach(CheckpointBehaviour behaviour in this.behaviours) {
            behaviour.OnActivate();
        }
    }

    public void Deactivate() {
        activated = false;

        foreach(CheckpointBehaviour behaviour in this.behaviours) {
            behaviour.OnDeactivate();
        }
    }
}
