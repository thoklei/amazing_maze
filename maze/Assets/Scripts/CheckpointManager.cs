using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private CheckPoint checkpoint1;
    [SerializeField] private CheckPoint checkpoint2;
    [SerializeField] private CheckPoint checkpoint3;
    [SerializeField] private CheckPoint checkpoint4;
    [SerializeField] private CheckPoint checkpoint5;
    [SerializeField] private CheckPoint checkpoint6;

    private List<CheckPoint> _checkpoints;
    private CheckPoint _latestCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        _checkpoints = new List<CheckPoint>()
        {
            checkpoint1,
            checkpoint2,
            checkpoint3,
            checkpoint4,
            checkpoint5,
            checkpoint6,
        };
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: change this into an event based system
        foreach (var checkpoint in _checkpoints)
        {
            if (checkpoint.activated)
            {
                _latestCheckpoint = checkpoint;
            }
        }
    }

    public Transform GetRespawnTransform()
    {
        return _latestCheckpoint.transform;
    }
}
