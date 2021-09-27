using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameMenu : MonoBehaviour
{

    public void BackToMainMenu()
    {
        // AudioManager.instance.Stop("victory");
        SceneManager.LoadScene("MainMenu");
    }
}
