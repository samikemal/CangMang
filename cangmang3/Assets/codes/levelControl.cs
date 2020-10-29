using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControl : MonoBehaviour
{
    public GameObject comimgsoon;
    public void levelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void levelTwo()
    {
        comimgsoon.SetActive(true);
    }

    public void backLevelTwo()
    {
        comimgsoon.SetActive(false);
    }
}
