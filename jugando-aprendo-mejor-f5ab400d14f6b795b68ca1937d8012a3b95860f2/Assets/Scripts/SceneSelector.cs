using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelector : MonoBehaviour {
    public float level;

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
        PlayerPreferences.SetNewInstance(this.level);
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
