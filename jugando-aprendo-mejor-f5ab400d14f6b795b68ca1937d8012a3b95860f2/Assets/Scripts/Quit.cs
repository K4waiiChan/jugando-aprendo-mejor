using UnityEngine;

public class Quit : MonoBehaviour {

    public void DoQuit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
