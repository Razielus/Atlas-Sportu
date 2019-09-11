using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTabToOpenScoreBoard : MonoBehaviour {

    public GameObject ScoreboardPanel;
    AudioSource audioData;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
        ScoreboardPanel.SetActive(!ScoreboardPanel.activeSelf);
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        }
    }
}
