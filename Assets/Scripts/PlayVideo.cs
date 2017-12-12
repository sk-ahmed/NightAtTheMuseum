using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

    public GameObject VideoSytem;
    public GameObject VideoScreen;
    private VideoPlayer screenVideoPlayer;

    // Use this for initialization
	void Start () {
        screenVideoPlayer = VideoScreen.GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void PlaySelectedVideo(){
        if (screenVideoPlayer.isPlaying)
        {
            screenVideoPlayer.Stop();
        }


        iTween.MoveTo(VideoSytem,
                      iTween.Hash("position", new Vector3(VideoSytem.transform.position.x, 0f, VideoSytem.transform.position.z),
                                  "time", 1.5f, "easytype", "Linear", "oncomplete", "OnPlayVideo", "oncompletetarget", this.gameObject));

        //iTween.MoveTo(VideoScreen,
                      //iTween.Hash("position", new Vector3(VideoScreen.transform.position.x, -0.4f, VideoScreen.transform.position.z),
                                  //"time", 1.5f, "easytype", "Linear"));

        //iTween.MoveTo(VideoSytem, iTween.Hash("position", new Vector3(VideoSytem.transform.position.x, 3.87f, VideoSytem.transform.position.z), "time", 0.5, "easetype", "linear"));

    }

    private void OnPlayVideo()
    {
        screenVideoPlayer.Play();
    }
}
