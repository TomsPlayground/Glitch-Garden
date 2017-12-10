﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float timer;

    void Start()
    {
        if (timer <= 0)
        {
            Debug.Log("Level auto load disabled, use a positive number in seconds");
        }
        else
        {
            Invoke("LoadNextLevel", timer);
        }
    }

    public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
