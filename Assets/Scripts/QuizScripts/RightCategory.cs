using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightCategory : MonoBehaviour {

    public GameObject Miniright1;
    public GameObject Miniright2;
    public GameObject Miniright3;
    public GameObject Miniright4;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if(Miniright1.GetComponent<Image>().enabled == true && Miniright2.GetComponent<Image>().enabled == true && Miniright3.GetComponent<Image>().enabled == true && Miniright4.GetComponent<Image>().enabled == true)
        {

                     GetComponent<Image>().enabled = true;

                    
                
            
        }
	}
}
