using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wrong : MonoBehaviour {

    float time = 3f;
    public GameObject WrongA;

    // Use this for initialization
    void Start () {
      
    }

    IEnumerator Time()
    { yield return new WaitForSeconds(time);
       Disable();
    }

    void Enable()
    {
        WrongA.GetComponent<Image>().enabled = true;
    }

    void Disable()
    {
        WrongA.GetComponent<Image>().enabled = false;
        GetComponent<Wrong>().enabled = false;
    }

    // Update is called once per frame
    void Update () {
        Enable();
        StartCoroutine(Time());
    }
}
