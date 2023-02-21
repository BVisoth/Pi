using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cam : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    void Start()
    {
        Debug.Log("Player_Move Script has Started");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
