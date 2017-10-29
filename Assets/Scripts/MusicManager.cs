using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private int currentSceneIndexNumber;

    // Use this for initialization
    void Start () {
        SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () {
        int currentSceneIndexNumber = SceneManager.GetActiveScene();

        if(levelMusicChangeArray[1])
        {
            audio.Play();
        }
    }
}
