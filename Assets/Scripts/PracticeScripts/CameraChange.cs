using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour {

    public GameObject CameraBack;
    public GameObject CameraHead;
    public GameObject SoundPanel;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SoundPanel.SetActive(!SoundPanel.activeSelf);
            if(CameraBack.GetComponent<Camera>().enabled == true)
            { CameraBack.GetComponent<Camera>().enabled = false;
                CameraHead.GetComponent<Camera>().enabled = true;
            }
            else
            { CameraBack.GetComponent<Camera>().enabled = true; }
        }

        }
    }
