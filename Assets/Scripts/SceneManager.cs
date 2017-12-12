using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SceneManager : MonoBehaviour {

    public GameObject videoPlayer;
    private VideoPlayer screenVideoPlayer;

	// Use this for initialization
	void Start () {
        screenVideoPlayer = videoPlayer.GetComponent<VideoPlayer>();

        screenVideoPlayer.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
