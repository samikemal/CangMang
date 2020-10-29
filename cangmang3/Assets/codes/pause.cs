using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausemenu;
    bool pauseEnable;
    public void Pause()
    {
        if (pauseEnable)
        {
            pauseEnable = false;
            Time.timeScale = 1;
            AudioListener.pause = false;
            pausemenu.SetActive(false);

        }
        else
        {
            pauseEnable = true;//oyunu durdurur
            Time.timeScale = 0;
            AudioListener.pause = true;
            pausemenu.SetActive(true);//paneli görünür yapar
        }
    }

    public void tekrar()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void levelMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
