using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SphereColorSelection : MonoBehaviour
{
    [SerializeField] private Material sphereMaterial;

    public void SelectColorSphere(String color)
    {
        Color selectedColor = GetColorFromString(color);

        // change the actual color of the material that is loaded at a later point
        sphereMaterial.SetColor("_Color", selectedColor);
    }

    private Color GetColorFromString(String colorString)
    {
        var colorSplit = colorString.Split(' ');
        var selectedColor = new Color();
        selectedColor.r = Int32.Parse(colorSplit[0])/255;
        selectedColor.g = Int32.Parse(colorSplit[1])/255;
        selectedColor.b = Int32.Parse(colorSplit[2])/255;
        selectedColor.a = 1f;

        return selectedColor;
    }
    
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
