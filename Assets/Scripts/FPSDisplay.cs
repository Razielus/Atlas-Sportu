﻿    using UnityEngine;
    using UnityEngine.UI;
     
    public class FPSDisplay : MonoBehaviour
    {
         public int avgFrameRate;
         public Text display_Text;
         float current = 0;

    public void Update()
         {
             
             current = Time.frameCount / Time.time;
             avgFrameRate = (int) current;
             display_Text.text = avgFrameRate.ToString() + " FPS";
         }
    }