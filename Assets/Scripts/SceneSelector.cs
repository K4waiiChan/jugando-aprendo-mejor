using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelector : MonoBehaviour {

    public void GoToRules()
    {
        this.SendToScene("Rules");
    }
    public void GoToLevels()
    {
        this.SendToScene("Levels");
    }

    public void GoToGame()
    {
        this.SendToScene("Game");
    }

    public void GoToMenu()
    {
        this.SendToScene("Menu");
    }

    private void SendToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
