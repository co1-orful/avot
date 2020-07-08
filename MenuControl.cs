using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void PlayPressed()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void SettingsPressed()
    {
    	  SceneManager.LoadScene("SettingsMenu", LoadSceneMode.Additive);
    }

    public void MainMenuPressed()
    {
          SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }

    public void UnloadMainMenu()
    {
        SceneManager.UnloadScene("MainMenu");
    }


    public void RestartPressed()
    {
        SceneManager.LoadScene("Game");
    }
}
