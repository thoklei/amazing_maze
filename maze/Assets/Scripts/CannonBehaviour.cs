using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The behaviour that (de)activates all cannons
public class CannonBehaviour : CheckpointBehaviour
{

    [SerializeField] private GameObject wall; // the wall to which this CannonBehaviour is attached
    private List<Cannon> cannons;
    
    void Start() {
        cannons = new List<Cannon>();
        cannons.AddRange(wall.GetComponentsInChildren<Cannon>());
    }
    public override void OnActivate()
    {
        foreach(Cannon cannon in cannons){
            cannon.StartShooting();
        }
    }

    public override void OnDeactivate()
    {
        foreach(Cannon cannon in cannons) {
            cannon.StopShooting();
        }
    }
}
