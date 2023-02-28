using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Unlock : MonoBehaviour
{
    public static int amountNumber;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        amountNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Amount Collected: " + amountNumber);

        if(amountNumber == 10)
        {
            Destroy(door);
            Debug.Log("Door is unlocked");
        }
    }
}
