using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

    public Canvas PauseMenu;

	// Use this for initialization
	void Start () {
        PauseMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PauseMenu.enabled = true;
        }
	}

    public void Unpause()
    {
        Time.timeScale = 1;
        PauseMenu.enabled = false;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
