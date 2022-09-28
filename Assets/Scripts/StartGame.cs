using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public Canvas _canvas;

	// Use this for initialization
	void Awake () {
        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void PlayGame()
    {
        Time.timeScale = 1;
        _canvas.enabled = false;
    }
}
