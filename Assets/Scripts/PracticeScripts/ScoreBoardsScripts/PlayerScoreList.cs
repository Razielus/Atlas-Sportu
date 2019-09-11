using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScoreList : MonoBehaviour {

	public GameObject playerScoreEntryPrefab;

	PointScript scoreManager;

	int lastChangeCounter;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindObjectOfType<PointScript>();

		lastChangeCounter = scoreManager.GetChangeCounter();
	}
	
	// Update is called once per frame
	void Update () {
		if(scoreManager == null) {
			Debug.LogError("You forgot to add the score manager component to a game object!");
			return;
		}

		if(scoreManager.GetChangeCounter() == lastChangeCounter) {
			// No change since last update!
			return;
		}

		lastChangeCounter = scoreManager.GetChangeCounter();

		while(this.transform.childCount > 0) {
			Transform c = this.transform.GetChild(0);
			c.SetParent(null); 
			Destroy (c.gameObject);
		}

		string[] names = scoreManager.GetPlayerNames("Points");
		
		foreach(string name in names) {
			GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);

            if(Application.isEditor)
            {   go.transform.localScale += new Vector3(-0.67f, -0.67f, -0.67f);
                go.transform.SetParent(this.transform);
                go.transform.Find("Username").GetComponent<Text>().text = name;
                go.transform.Find("Points").GetComponent<Text>().text = scoreManager.GetScore(name, "Points").ToString();
            }
            else
            {   
                go.transform.localScale += new Vector3(-0.18f, -0.18f, -0.18f);
                go.transform.SetParent(this.transform);
                go.transform.Find("Username").GetComponent<Text>().text = name;
                go.transform.Find("Points").GetComponent<Text>().text = scoreManager.GetScore(name, "Points").ToString();
            }


		}
	}
}
