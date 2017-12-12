using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject panel;
    public GameObject startPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame(){

        if(panel.name == "Panel"){
            panel.SetActive(false);
            startPanel.SetActive(true);
        } else {
            startPanel.SetActive(false);
        }


    }
}

