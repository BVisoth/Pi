using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Code : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
