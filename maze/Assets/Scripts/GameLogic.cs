using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] public CheckpointManager checkpointManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetActivePlayer() {
        return player;
    }

  
}
