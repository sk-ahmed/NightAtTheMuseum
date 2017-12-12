using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CloseVideo : MonoBehaviour {

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

    public void closeVideo(){
        if(screenVideoPlayer.isPlaying){
            screenVideoPlayer.Stop();
        }

        //iTween.MoveTo(VideoSytem,
                    //  iTween.Hash("position", VideoSytem.transform.position,
                    //"time", 1.5f, "easytype", "Linear", "oncomplete", "OnPlayerSound", "oncompletetarget", this.gameObject));

        iTween.MoveTo(VideoSytem, iTween.Hash("position", new Vector3(VideoSytem.transform.position.x, 3.87f, VideoSytem.transform.position.z), "time", 0.5, "easetype", "linear"));

    }
}
