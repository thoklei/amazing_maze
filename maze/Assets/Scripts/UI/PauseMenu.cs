using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameLogic _gameLogic;
    public void Quit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        // _gameLogic.Unfreeze();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void BackToMainMenu()
    {
        // AudioManager.instance.StopAll();
        SceneManager.LoadScene("MainMenu");
    }
}
