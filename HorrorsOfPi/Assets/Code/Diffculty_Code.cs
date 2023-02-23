using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diffculty_Code : MonoBehaviour
{
    public float easyValue;
    public float normalValue;
    public float hardValue;

    public void EasyMode()
    {
        Enemy.agentSpeed = easyValue;
        SceneManager.LoadScene("Game");
    }

    public void NormalMode()
    {
        Enemy.agentSpeed = normalValue;
        SceneManager.LoadScene("Game");
    }

    public void HardMode()
    {
        Enemy.agentSpeed = hardValue;
        SceneManager.LoadScene("Game");
    }
}
