using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTrigger : MonoBehaviour {



    public void RightTrig()
    {
        GameObject varGameObject = GameObject.Find("AnswerButtons");
        varGameObject.GetComponent<Right>().enabled = true;
    }


}
