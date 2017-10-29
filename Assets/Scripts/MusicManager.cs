using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource backgroundMusic;

    void Awake() {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load");
    }

    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        AudioClip splashScreenMusic = levelMusicChangeArray[0];
        backgroundMusic.clip = splashScreenMusic;
        backgroundMusic.loop = false;
        backgroundMusic.Play();
        Debug.Log("Now playing without loop: " + splashScreenMusic);
    }

    void OnLevelWasLoaded(int levelIndex)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[levelIndex];
        Debug.Log("Playing clip " + thisLevelMusic);

        if (thisLevelMusic)
        {
            backgroundMusic.clip = thisLevelMusic;
            backgroundMusic.loop = true;
            backgroundMusic.Play();
            Debug.Log("Now playing with loop: " + thisLevelMusic);
        }
    }
}