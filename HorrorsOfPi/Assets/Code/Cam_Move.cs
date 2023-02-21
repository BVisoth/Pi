using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Move : MonoBehaviour
{

    public Transform cameraPosition;

    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
