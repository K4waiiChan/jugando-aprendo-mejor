using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    public Text TimerText;
    public float RemainingTime { get; set; }
    void Start()
    {
        this.RemainingTime = PlayerPreferences.Instance.SelectedDificulty;
        this.TimerText.text = this.RemainingTime.ToString("f0");
    }

    // Update is called once per frame
    void Update()
    {
        this.RemainingTime -= Time.deltaTime;
        this.TimerText.text = this.RemainingTime.ToString("f0");
        this.Lose();
    }

    private void Lose() {
        if (this.RemainingTime <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
