using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item_code : MonoBehaviour
{

    public int spin;
    public TextMeshProUGUI CollectedAmount;

    // Start is called before the first frame update
    void Start()
    {
        CollectedAmount.text = ("Collected Numbers: " + Door_Unlock.amountNumber);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, spin * Time.deltaTime, 0f, Space.Self);
    }

    public void OnTriggerEnter(Collider player)
    {
        Destroy(gameObject);
        Debug.Log("Collected");
        Door_Unlock.amountNumber += 1;
        CollectedAmount.text = ("Collected Numbers: " + Door_Unlock.amountNumber);
    }
}
