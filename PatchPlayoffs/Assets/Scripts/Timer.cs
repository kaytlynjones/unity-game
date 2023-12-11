using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    float t;
    public float timeLeft = 60f;
    string seconds;
    // public float startTime;
    public static bool TimesUp = false;


    // Start is called before the first frame update
    void Awake()
    {
        // startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // t = Time.time + startTime;
        // seconds = (t%60).ToString("f2");
        // timer.text = seconds + "s";

        // if(t % 60 > 59) {
        //     // t = 0;
        //     // startTime = 0;
        //     // startTime = Time.time;
        //     SceneManager.LoadScene("LoseScreen");
        // }

        t = timeLeft -= Time.deltaTime;
        seconds = (t%60).ToString("f2");
        timer.text = seconds + "s";
        if (timeLeft <= 0) {
            timeLeft = 0;
            timer.text = "0s";
            TimesUp = true;
        }
        if (TimesUp == true) {
            timeLeft = 60f;
            TimesUp = false;
            SceneManager.LoadScene("LoseScreen");
            Debug.Log(timeLeft);
        }
    }

    // public void setStartTime(float newTime) {
    //     startTime = newTime;
    // }
}
