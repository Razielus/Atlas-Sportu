using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSToMuteSound : MonoBehaviour
{

    public GameObject SoundPanel;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SoundPanel.SetActive(!SoundPanel.activeSelf);
        }
    }
}
