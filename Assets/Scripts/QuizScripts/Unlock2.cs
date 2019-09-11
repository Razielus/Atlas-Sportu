using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock2 : MonoBehaviour {


    public GameObject Miniright1;
    public GameObject Miniright2;

    void Start()
    {

    }

    void Update()
    {
        if (Miniright1.GetComponent<Image>().enabled == true && Miniright2.GetComponent<Image>().enabled == true)
        {
            GetComponent<Button>().enabled = true;
            GetComponent<Image>().color = new Color(0.9987794f, 1, 0.8349056f);
        }
    }
}

