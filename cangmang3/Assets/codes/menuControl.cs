using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public GameObject howtoPlay;
    public GameObject audioOptions;
    public GameObject levels;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
            howtoPlay.SetActive(true);
        
    }
    public void back()
    {
            howtoPlay.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void audioOpt()
    {
        audioOptions.SetActive(true);
    }
    public void backAuido()
    {
        audioOptions.SetActive(false);
    }

    public void backMenu()
    {
        audioOptions.SetActive(false);
    }

    public void levelOpt()
    {
        levels.SetActive(true);
    }
    public void levelOff()
    {
        levels.SetActive(false);
    }

    public void backLevelMenu()
    {
        levels.SetActive(false);
    }




}
