﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void PlayGame()
    {
#if UNITY_EDITOR
        Debug.Log("PlayGame function called");
#endif
        SceneManager.LoadScene("Game");

    }
}
