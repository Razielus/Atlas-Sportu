using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationLaunch : MonoBehaviour {


    // Use this for initialization
    void Start () {

        GameObject varGameObject = GameObject.Find("StartTimer10s");

        varGameObject.SetActive(false);

        TriggeredExercise();
    }

    void TriggeredExercise ()
    {
        gameObject.GetComponent<Animator>().enabled = true;
    }

    void End () { 
}
	
	// Update is called once per frame
	void Update () {

	}
}
