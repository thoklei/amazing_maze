using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    { 
        Audiomanager.instance.Play("mainmenu",.5f);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
