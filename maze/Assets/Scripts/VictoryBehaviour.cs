using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryBehaviour : CheckpointBehaviour
{
    public override void OnActivate()
    {
        SceneManager.LoadScene("EndOfGameScene");    
    }

    public override void OnDeactivate()
    {
        // nothing to do here
    }
}
