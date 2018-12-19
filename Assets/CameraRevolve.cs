using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRevolve : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
    }

     void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && (cam1.enabled == true))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && (cam2.enabled == true))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && (cam3.enabled == true))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && (cam4.enabled == true))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && (cam5.enabled == true))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
        }

    }
}