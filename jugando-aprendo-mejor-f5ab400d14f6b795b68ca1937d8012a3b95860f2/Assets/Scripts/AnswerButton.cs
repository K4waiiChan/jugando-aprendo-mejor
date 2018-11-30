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
        }
        {
            this.SendToScene(next);

        }
    }
}
