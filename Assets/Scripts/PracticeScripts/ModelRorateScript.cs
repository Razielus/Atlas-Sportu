using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRorateScript : MonoBehaviour
{
    public Transform player;
    public Transform player2;

    // Use this for initialization
    void Start()
    {

        


}

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale==1)
        {
            player.transform.Rotate(0, -10, 0, Space.Self);
            player2.transform.Rotate(0, 2, 0, Space.Self);
        }
    }
}
