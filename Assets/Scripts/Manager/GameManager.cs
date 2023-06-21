using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        App.gameManager = this;
        App.sceneLoader.LoadScene("UIScene", new ShowScreenCommand<MenuScreen>());
    }

    public void StartGame()
    {
        App.sceneLoader.LoadScene("InGameScene", new SetupLevelCommand());
    }

    public void ReturnToMenu()
    {
        App.sceneLoader.UnloadScene("InGameScene");
        App.screenManager.Show<MenuScreen>();
    }
}
