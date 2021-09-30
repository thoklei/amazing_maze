using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosslevelBehaviour : CheckpointBehaviour
{
    [SerializeField] private Player player;

    public override void OnActivate()
    {
        Debug.Log("activating boss level");
        player.Arm();
    }

    public override void OnDeactivate()
    {

    }

}
