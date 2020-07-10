using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public int sceneID;
    public void PlayPressed()
    {
        StartCoroutine(Load(3));
    }

    public void SettingsPressed()
    {
    	  SceneManager.LoadScene("SettingsMenu", LoadSceneMode.Additive);
    }

    public void MainMenuPressed()
    {
          StartCoroutine(Load(1));
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }

    public void RestartPressed()
    {
        StartCoroutine(Load(3));
    }

    IEnumerator Load(int sceneID)
    {
         yield return new WaitForSeconds(3);
         SceneManager.LoadSceneAsync(sceneID);
    }
}
