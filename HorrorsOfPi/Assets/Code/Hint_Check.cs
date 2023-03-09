using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_Check : MonoBehaviour
{
    public bool HintOne;
    public bool HintTwo;
    public bool HintThree;
    public bool HintFour;
    public bool HintFive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hint One Status" + HintOne);
    }
}
