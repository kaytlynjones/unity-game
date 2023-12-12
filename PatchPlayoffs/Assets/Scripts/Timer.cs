using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    float t;
    public float timeLeft = 120f;
    string seconds;
    string minutes;
    public static bool TimesUp = false;
    // Update is called once per frame
    void Update()
    {
        t = timeLeft -= Time.deltaTime;
        minutes = (Math.Floor(t/60)).ToString("f2").Substring(0,1);
        seconds = (t%60).ToString("f2");
        timer.text = minutes + ":" + seconds;
        if (timeLeft <= 0) {
            timeLeft = 0;
            timer.text = "0s";
            TimesUp = true;
        }
        if (TimesUp == true) {
            timeLeft = 120f;
            TimesUp = false;
            SceneManager.LoadScene("LoseScreen");
            Debug.Log(timeLeft);
        }
    }
}
