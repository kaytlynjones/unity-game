using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void onQuitButton()
    {
        Application.Quit();
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void onControlsButton()
    {
        SceneManager.LoadScene("Controls");
    }
}
