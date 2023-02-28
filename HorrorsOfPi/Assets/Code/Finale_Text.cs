using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Finale_Text : MonoBehaviour
{
    public int limit;
    public TMP_InputField theInput;
    public GameObject[] Buttons;
    public GameObject clearButton;
    public GameObject enterButton;

    void Start()
    {
        theInput.characterLimit = limit;
    }
    public void One()
    {
        theInput.text = theInput.text + "1";
    }
    public void Two()
    {
        theInput.text = theInput.text + "2";
    }
    public void Three()
    {
        theInput.text = theInput.text + "3";
    }
    public void Four()
    {
        theInput.text = theInput.text + "4";
    }
    public void Five()
    {
        theInput.text = theInput.text + "5";
    }
    public void Six()
    {
        theInput.text = theInput.text + "6";
    }
    public void Seven()
    {
        theInput.text = theInput.text + "7";
    }
    public void Eight()
    {
        theInput.text = theInput.text + "8";
    }
    public void Nine()
    {
        theInput.text = theInput.text + "9";
    }
    public void Dot()
    {
        theInput.text = theInput.text + ".";
    }
    public void Clear()
    {
        theInput.text = null;
    }

    public void Check()
    {
        if (theInput.text == "3.141592653")
        {
            Debug.Log("Win");
        }
        else
        {
            Debug.Log("Fail");
        }
    }
}
