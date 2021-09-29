using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MusicBehavior : CheckpointBehaviour
{
    private string song;
    public MusicBehavior(string songname)
    {
        song = songname;
    }

    
    
    public override void Init() {
        Debug.Log("Running Init");

    }


    public override void OnActivate()
    {
        Debug.Log("play new level music");
        Audiomanager.instance.Play(song,.2f);
        
    }

    public override void OnDeactivate()
    {
        Debug.Log("stop new level music");
        Audiomanager.instance.Stop(song);
    }
}
