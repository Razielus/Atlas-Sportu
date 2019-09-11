using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongTrigger : MonoBehaviour
{


    public void WrongTrig()
    {
        GameObject varGameObject = GameObject.Find("AnswerButtons");
        varGameObject.GetComponent<Wrong>().enabled = true;

    }

}
