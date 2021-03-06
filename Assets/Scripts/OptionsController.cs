﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = FindObjectOfType<MusicManager>();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
    }
	
	// Update is called once per frame
	void Update () {
        musicManager.SetVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("Start Menu");
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.2f;
        difficultySlider.value = 2f;
    }

}
