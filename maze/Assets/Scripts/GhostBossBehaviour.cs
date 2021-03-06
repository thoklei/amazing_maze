using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The behaviour that (de)activates the ghost
public class GhostBossBehaviour : CheckpointBehaviour
{

    //TODO make serializable field when checkopointfixed
    [SerializeField] private GhostBoss boss;

    [SerializeField] private Player player;
    

    public override void OnActivate()
    {
        Debug.Log("Activating GhostBoss");
        boss.StartHunting();
        player.Arm();

    }

    public override void OnDeactivate()
    {
        Debug.Log("Deactivating GhostBoss");
        //boss.StopHunting();
    }
}