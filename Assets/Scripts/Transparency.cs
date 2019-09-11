using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transparency : MonoBehaviour {

    public float alphalevel = .3f ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().color = new Color (0.3f, 0.3f, 0.3f, alphalevel);
	}
}
