using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    [SerializeField] Player player;
    [SerializeField] public CheckpointManager checkpointManager;

    // Start is called before the first frame update
    void Start()
    {
        // Disable mousecursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO Change to get to main menu
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        // reset to last checkpoint 
        if(Input.GetKeyDown(KeyCode.K)) {player.Damage(100);}
    }

    public Player GetActivePlayer() {
        return player;
    }

  
}
