using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSpaceToPause : MonoBehaviour {

    public bool pause = false;
    public GameObject PauseObj;
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pause = !pause;
        }

        if (pause)
        {

            PauseObj.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!pause)
        {
            Time.timeScale = 1;
            PauseObj.SetActive(false);
        }
    }
}
