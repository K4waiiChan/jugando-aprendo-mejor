using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

    public Text Text;
    public TimeSpan FinalTime { get; set; }
    void Start () {
        this.FinalTime = DateTime.Now - PlayerPreferences.Instance.InitialTime;
        this.Text.text = "Tu tiempo es de " + this.FinalTime.Minutes.ToString() + " minutos con " + this.FinalTime.Seconds.ToString() + " segundos";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
