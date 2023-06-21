using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Awake()
    {
        App.sceneLoader = this;
    }

    public void LoadScene(string sceneName, ICommand afterLoadingCommand)
    {
        StartCoroutine(LoadSceneAsync(sceneName, afterLoadingCommand));
    }

    public void UnloadScene(string sceneName)
    {
        StartCoroutine(UnloadSceneAsync(sceneName));
    }


    IEnumerator LoadSceneAsync(string sceneName, ICommand afterLoadingCommand)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        asyncLoad.allowSceneActivation = false;

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            if(asyncLoad.progress >= 0.9f)
                asyncLoad.allowSceneActivation = true;
            yield return null;  // wait for the next frame
        }
        // ...
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));

        afterLoadingCommand.Execute();
    }

    IEnumerator UnloadSceneAsync(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;  // wait for the next frame
        }
        // ...
    }
}
