using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void BackToMainMenu()
    {
        Audiomanager.instance.StopAll();
        SceneManager.LoadScene("MainMenu");
    }
}
