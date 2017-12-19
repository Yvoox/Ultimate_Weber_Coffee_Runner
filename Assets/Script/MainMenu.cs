using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string level;

	// Use this for initialization
	void Start () {
		
	}

    public void LaunchGame()
    {
        Application.LoadLevel(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
