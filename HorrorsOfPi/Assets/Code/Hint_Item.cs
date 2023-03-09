using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_Item : MonoBehaviour
{

    public GameObject[] Hints;
    Hint_Check Check;

    // Start is called before the first frame update
    void Start()
    {
        Check.HintOne = false;
        Check.HintTwo = false;
        Check.HintThree = false;
        Check.HintFour = false;
        Check.HintFive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
