using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimGifScript : MonoBehaviour {
    public GameObject Frame1;
    public GameObject Frame2;
    public GameObject Frame3;
    public GameObject Frame4;
    public GameObject Frame5;
    public GameObject Frame6;
    public GameObject Frame7;
    public GameObject Frame8;
    public GameObject Frame9;

    private float time = 1;


    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Frame1.GetComponent<Image>().enabled = false;
        Frame2.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame2.GetComponent<Image>().enabled = false;
        Frame3.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame3.GetComponent<Image>().enabled = false;
        Frame4.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame4.GetComponent<Image>().enabled = false;
        Frame5.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame5.GetComponent<Image>().enabled = false;
        Frame6.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame6.GetComponent<Image>().enabled = false;
        Frame7.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame7.GetComponent<Image>().enabled = false;
        Frame8.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame8.GetComponent<Image>().enabled = false;
        Frame9.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame9.GetComponent<Image>().enabled = false;
        Frame1.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame1.GetComponent<Image>().enabled = false;
        Frame2.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame2.GetComponent<Image>().enabled = false;
        Frame3.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame3.GetComponent<Image>().enabled = false;
        Frame4.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame4.GetComponent<Image>().enabled = false;
        Frame5.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame5.GetComponent<Image>().enabled = false;
        Frame6.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame6.GetComponent<Image>().enabled = false;
        Frame7.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame7.GetComponent<Image>().enabled = false;
        Frame8.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame8.GetComponent<Image>().enabled = false;
        Frame9.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(time);
        Frame9.GetComponent<Image>().enabled = false;
        Frame1.GetComponent<Image>().enabled = true;
    }


	
	// Update is called once per frame
	void Update () {
    }
}
