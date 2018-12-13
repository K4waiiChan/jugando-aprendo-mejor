using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPreferences {
    public static PlayerPreferences Instance { get; set; }
    public float SelectedDificulty { get; set; }
    public bool AudioMuted { get; set; }
    public float ActiveTime { get; set; }
    public DateTime InitialTime { get; set; }

    public static void SetNewInstance(float dificulty)
    {
        PlayerPreferences.Instance = new PlayerPreferences
        {
            AudioMuted = false,
            SelectedDificulty = dificulty,
            ActiveTime = 0,
            InitialTime = DateTime.Now
        };

    }

    public void ChangeMuteStatus(bool status) {
        this.AudioMuted = status;
    }
}
