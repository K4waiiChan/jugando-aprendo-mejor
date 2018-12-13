using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {
    private bool _audioActive;
    public AudioSource AudioSource;
    void Start() {
        this.AudioSource = GetComponent<AudioSource>();
        this._audioActive = PlayerPreferences.Instance.AudioMuted;
    }

    void Update() {
        this.AudioSource.mute = this._audioActive;
    }

    public void ChangeMuteStatus() {
        this._audioActive = !this._audioActive;
        PlayerPreferences.Instance.ChangeMuteStatus(this._audioActive);
    }
}
