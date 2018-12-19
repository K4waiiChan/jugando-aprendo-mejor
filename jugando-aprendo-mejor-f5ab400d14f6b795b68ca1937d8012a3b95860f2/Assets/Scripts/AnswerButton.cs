using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnswerButton : SceneSelector {
    public string next;
    public void ButtonWasSelected()
    {
        if (next == "")
        {
            this.GoToMenu();
        } else if( next == "Winner")
        {
            this.SendToScene(next);
        } else
        {
            this.SendToScene(PlayerPreferences.Instance.SelectedDificulty + next);
        }
            
    }
}
