using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameMenu : MonoBehaviour
{
    void Start()
    { 
        Audiomanager.instance.Play("victory",.5f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BackToMainMenu()
    {
        Audiomanager.instance.Stop("victory");
        SceneManager.LoadScene("MainMenu");
    }
}
