using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadingFirst : MonoBehaviour
{
    public int sceneID;
    public Text progressText;

    void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad()
    {
    	   yield return new WaitForSeconds(2);
         AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);

         while (!operation.isDone)
         {
            float progress = operation.progress / 0.9F;
            progressText.text = string.Format("{0:0}%", progress * 100);
            yield return null;
         }
         
    }

}
