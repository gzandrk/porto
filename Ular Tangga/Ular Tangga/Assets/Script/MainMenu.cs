﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneLoad.Load(SceneLoad.Scene.PickPlayer1);
    }
    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}
