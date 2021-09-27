using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The behaviour that (de)activates all cannons
public class CannonBehaviour : CheckpointBehaviour
{
    private List<Cannon> cannons;
    
    public override void Init() {
        cannons = new List<Cannon>();
        cannons.AddRange(this.checkPoint.gameObject.transform.parent.GetComponentsInChildren<Cannon>());
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
