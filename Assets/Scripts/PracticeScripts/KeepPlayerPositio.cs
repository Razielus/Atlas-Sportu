using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeepPlayerPositio : MonoBehaviour {
	
	private Vector3 originalPos;
	// Use this for initialization
	void Start () {
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			transform.position = originalPos;
		}
	}
}
