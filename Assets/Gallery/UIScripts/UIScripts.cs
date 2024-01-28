using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    public GameObject Canvas;
    bool isClicked = false;

    void Start()
    {
        Canvas.SetActive(isClicked);
    }

    public void OnButtonClick()
    {
        // Toggle the value of isClicked
        isClicked = !isClicked;

        // Set the Canvas active state based on the new value of isClicked
        Canvas.SetActive(isClicked);
    }
}
