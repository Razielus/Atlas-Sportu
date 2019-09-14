using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPrefabSwap : MonoBehaviour {

    public GameObject PrePrefab;
    public GameObject ActionPrefab;
    public GameObject StartTimer;
    public GameObject PointsScript;
    float time = 8f;



    // Use this for initialization
    void Start() {

            Run();
            Cursor.visible = false;
     
    }

    private void OnDisable()
    {
        Cursor.visible = true;
    }

    void Run()
    {
        PrePrefab.SetActive(false);
        ActionPrefab.SetActive(true);
        ActionPrefab.GetComponent<AnimationLaunch>().enabled = true;
        StartCoroutine(Swap());
        PointsScript.GetComponent<PointScript>().enabled = true;
    }

    void End()
    {
        StartTimer.SetActive(true);
        PointsScript.GetComponent<PointScript>().enabled = false;
      //  StartTimer.GetComponent<TimerCountdown>().enabled = true;
        GetComponent<BotPrefabSwap>().enabled = false;
       
    }

    IEnumerator Swap()
    {
        
        yield return new WaitForSeconds(time);
        PrePrefab.SetActive(true);
        ActionPrefab.SetActive(false);
        ActionPrefab.GetComponent<AnimationLaunch>().enabled = false;
        ActionPrefab.GetComponent<Animator>().enabled = false;
        End();
    }

	// Update is called once per frame
	void Update () {




    }
}
