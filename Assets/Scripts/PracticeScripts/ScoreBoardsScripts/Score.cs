using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    ScoreManager scoreManager;

    void Main()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }
    // Update is called once per frame
    void Update () {


        scoreText.text = scoreManager.ToString();

	}
}
