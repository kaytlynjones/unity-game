using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // private Timer timer;

    void Awake() {
        // timer = new Timer();
    }
    public void OnPlayButton()
    {
        // timer.setStartTime(Time.time);
        SceneManager.LoadScene("gameScene");
    }

    public void onQuitButton()
    {
        Application.Quit();
    }

    public void onBackButton()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void toWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void toLoseScreen()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
