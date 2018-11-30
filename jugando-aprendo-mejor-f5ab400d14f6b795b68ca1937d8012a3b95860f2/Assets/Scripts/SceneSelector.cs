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
        this.SendToScene("QuestionA");
    }

    public void GoToMenu()
    {
        this.SendToScene("Menu");
    }

    protected void SendToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
