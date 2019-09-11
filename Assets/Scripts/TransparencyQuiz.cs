using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparencyQuiz : MonoBehaviour {

    public float alphalevel = .7f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().color = new Color(0.9987794f, 1.0f, 0.8349056f, alphalevel);
    }
}
