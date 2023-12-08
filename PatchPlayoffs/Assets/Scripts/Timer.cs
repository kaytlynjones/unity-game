using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    float startTime;
    float t;
    string seconds;
    bool replay;

    // Start is called before the first frame update
    void Start()
    {
        replay = false;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // if (replay) {
        //     startTime = Time.time;
        //     replay = false;
        // } 
        t = Time.time + startTime;
        seconds = (t%60).ToString("f2");
        timer.text = seconds;

        if(t % 60 > 59) {
            // t = 0;
            // startTime = 0;
            // startTime = Time.time;
            SceneManager.LoadScene("LoseScreen");
            replay = true;
        }
    }
}
