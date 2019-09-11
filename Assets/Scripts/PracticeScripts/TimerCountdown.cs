using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{

    float CurrentTime = 0f;
    float StartingTime = 10f;
    public bool wasTimerFinished = false;

    [SerializeField] Text TimerCountdownText;

    // Use this for initialization
    void Start()
    {
        CurrentTime = StartingTime;
    }

    void Repeater()
    {

        CurrentTime = 10;
        GameObject avarGameObject = GameObject.Find("BotPrefabSwap");
        avarGameObject.GetComponent<BotPrefabSwap>().enabled = true;
        GetComponent<TimerCountdown>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        CurrentTime -= 1 * Time.deltaTime;
        TimerCountdownText.text = CurrentTime.ToString("0");

        TimerCountdownText.color = Color.yellow;

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;

        }

        if (CurrentTime == 0)
        {
            GameObject SoundGame = GameObject.Find("ButtonGongSound");
            SoundGame.GetComponent<AudioSource>().Play(0);
            wasTimerFinished = true;
            Repeater();
        }

        Debug.Log(CurrentTime);


    }
}
