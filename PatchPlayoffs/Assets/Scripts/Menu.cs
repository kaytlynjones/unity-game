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

    public void onBackButton()
    {
        SceneManager.LoadScene("StartScreen");
    }
<<<<<<< HEAD

    public void toWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void toLoseScreen()
    {
        SceneManager.LoadScene("LoseScreen");
=======
    public void onControlsButton()
    {
        SceneManager.LoadScene("ControlsScreen");
    }
=======
>>>>>>> parent of 656cf17 (added access to controls scene)
}
