using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Right : MonoBehaviour {

    public GameObject RightA;
    public GameObject RightAnswer;
    public GameObject Wronganswer1;
    public GameObject Wronganswer2;
    public GameObject Wronganswer3;
    float time = 3f;
    public GameObject MiniRight;

    // Use this for initialization
    void Start () {



    }

    void Enabled()
    {
        RightA.GetComponent<Image>().enabled = true;
        MiniRight.GetComponent<Image>().enabled = true;
        Wronganswer1.GetComponent<TransparencyQuiz>().enabled = true;
        Wronganswer2.GetComponent<TransparencyQuiz>().enabled = true;
        Wronganswer3.GetComponent<TransparencyQuiz>().enabled = true;
        StartCoroutine(Time());
    }

    IEnumerator Time()
    { yield return new WaitForSeconds(time);
        RightA.GetComponent<Image>().enabled = true;
        Wronganswer1.GetComponent<TransparencyQuiz>().enabled = false;
        Wronganswer2.GetComponent<TransparencyQuiz>().enabled = false;
        Wronganswer3.GetComponent<TransparencyQuiz>().enabled = false;
        
    }

    // Update is called once per frame
    void Update () {
        Enabled();
	}
}
