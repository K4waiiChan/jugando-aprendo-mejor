using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {

    public string Content { get; set; }
    public ArrayList Answers { get; set; }

    public Question(string content, ArrayList answers) {
        this.Content = content;
        this.Answers = answers;
    }
}
