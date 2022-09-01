using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    public Camera cameraThree;

    private void Start()
    {
        cameraOne.enabled = true;
    }

    private void switchCamera(int cameraNumber)
    {
        switch (cameraNumber)
        {
            case 1:
                if (cameraOne.enabled == false)
                {
                    cameraTwo.enabled = false;
                    cameraThree.enabled = false;
                    cameraOne.enabled = true;
                }
                break;
            case 2:
                if (cameraTwo.enabled == false)
                {
                    cameraTwo.enabled = true;
                    cameraThree.enabled = false;
                    cameraOne.enabled = false;
                }
                break;
            case 3:
                if (cameraThree.enabled == false)
                {
                    cameraTwo.enabled = false;
                    cameraThree.enabled = true;
                    cameraOne.enabled = false;
                }
                break;
        }
    }
}
