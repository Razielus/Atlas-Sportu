using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToPreviousMenuLoadSceneOnPress : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MenuPractice");
        }
    }
}
