using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PlayAudio : MonoBehaviour {

    public GameObject audioSystem;

    public Text audioText;

    AudioSource audioClip;


	// Use this for initialization
	void Start () {
        audioClip = audioText.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showDetail(){
        if(audioClip.isPlaying){
            audioClip.Stop();
        }


        iTween.MoveTo(audioSystem,
                      iTween.Hash("position", new Vector3(audioSystem.transform.position.x, 0f, audioSystem.transform.position.z),
                                  "time", 1.5f, "easytype", "Linear", "oncomplete", "playClip", "oncompletetarget", this.gameObject));

    }

    private void playClip(){
        audioClip.Play();
    }

    public void closeAudio()
    {
        if (audioClip.isPlaying)
        {
            audioClip.Stop();
        }


        //iTween.MoveTo(VideoSytem,
        //  iTween.Hash("position", VideoSytem.transform.position,
        //"time", 1.5f, "easytype", "Linear", "oncomplete", "OnPlayerSound", "oncompletetarget", this.gameObject));

        iTween.MoveTo(audioSystem, iTween.Hash("position", new Vector3(audioSystem.transform.position.x, 3.87f, audioSystem .transform.position.z), "time", 0.5, "easetype", "linear"));

    }
}
