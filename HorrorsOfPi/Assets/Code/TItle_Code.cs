using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TItle_Code : MonoBehaviour
{
    public void TitleStart()
    {
        SceneManager.LoadScene("Difficulty");
    }

    public void BeGone()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("Title");
    }
}
