using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeytoEnterMainMenu : MonoBehaviour {

    public GameObject Open;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Open.GetComponent<AudioSource>().Play();
            Application.LoadLevel("MainMenu");
            
        }
    }
}
