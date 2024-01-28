using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    private bool isLightOn = false;
    public GameObject flashlight;

    public void SwitchOn()
    {
        isLightOn = !isLightOn; // Toggle the value of isLightOn

        if (isLightOn)
        {
            flashlight.SetActive(true);
        }
        else
        {
            flashlight.SetActive(false);
        }
    }
}

   

   

