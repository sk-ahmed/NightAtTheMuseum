using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public enum State {

	Idle,
	Focused,
	Clicked

}

public class WaypointBehaviour : MonoBehaviour
{


    protected State state = State.Idle;
    protected float scale = 1f;
    protected float animatedLerp = 1f;

    [SerializeField]
    protected float scaleIdleMin;
    [SerializeField]
    protected float scaleIdleMax;
    [SerializeField]
    protected float scaleAnimation;

    [SerializeField]
    protected float scaleFocusMin;
    [SerializeField]
    protected float scaleFocusMax;

    protected AudioSource playerAudio;

    protected void Start()
    {

        playerAudio = GetComponent<AudioSource>();
    }

    protected void Update()
    {

        switch (state)
        {

            case State.Idle:
                Idle();

                break;
            case State.Focused:
                Focus();

                break;
            default:
                break;
        }

        gameObject.transform.localScale = Vector3.one * scale;
        animatedLerp = Mathf.Abs(Mathf.Cos(Time.time * scaleAnimation));
    }

    protected void Idle()
    {

        scale = Mathf.Lerp(scaleIdleMin, scaleIdleMax, animatedLerp);

    }

    protected void Focus()
    {

        scale = Mathf.Lerp(scaleFocusMin, scaleFocusMax, animatedLerp);

    }

    public void Enter()
    {

        state = state == State.Idle ? State.Focused : state;
    }

    public void Exit()
    {

        state = State.Idle;
    }

    public void Click()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Video");

        foreach (GameObject obj in objs)
        {

            VideoPlayer video = obj.GetComponent<VideoPlayer> ();
            if (video.isPlaying)
            {
                video.Stop();
            }
        }

        GameObject[] audioClips = GameObject.FindGameObjectsWithTag("Audio");

        foreach (GameObject obj in audioClips)
        {

            AudioSource audioClip = obj.GetComponent<AudioSource>();
            if (audioClip.isPlaying)
            {
                audioClip.Stop();
            }
        }


        GameObject[] videoCanvases = GameObject.FindGameObjectsWithTag("VideoCanvas");

        foreach(GameObject obj in videoCanvases){
            if (obj.transform.position.y <= 0f){
                iTween.MoveTo(obj, iTween.Hash("position", new Vector3(obj.transform.position.x, 4.27f, obj.transform.position.z), "time", 0.5, "easetype", "linear"));    
            }
        }





        GameObject player = GameObject.FindGameObjectWithTag("Player");

        iTween.MoveTo (player, 
        iTween.Hash("position", gameObject.transform.position, 
        "time", 1.5f, "easytype", "Linear", "oncomplete", "OnPlayerSound", "oncompletetarget", this.gameObject));

    }


    public void OnPlayerSound()
    {
        playerAudio.Play();
    }

}