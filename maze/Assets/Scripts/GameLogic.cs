using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    [SerializeField] Player player;
    [SerializeField] public CheckpointManager checkpointManager;
    [SerializeField] private PauseMenu pauseMenu;

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
        // Escape opens the pausedMenu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        // reset to last checkpoint 
        if(Input.GetKeyDown(KeyCode.K)) {player.Damage(100);}
    }

    public Player GetActivePlayer() {
        return player;
    }

  
}
