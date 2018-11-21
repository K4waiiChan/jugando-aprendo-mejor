using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer {
    public string Content { get; set; }
    public bool IsCorrect { get; set; }

    public Answer(string content, bool isCorrect) {
        this.Content = content;
        this.IsCorrect = isCorrect;
    }
}
