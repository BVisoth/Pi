using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_code : MonoBehaviour
{

    public int spin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, spin * Time.deltaTime, Space.Self);


    }
}
