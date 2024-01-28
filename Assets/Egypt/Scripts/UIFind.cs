using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class UIFind : MonoBehaviour
{
    private XRIDefaultInputActions input = null;
    public GameObject canvas;
    private bool canvasOn = false;
    // Start is called before the first frame update
    void Awake()
    {
        input = new XRIDefaultInputActions();

    }

    private void OnDisable()
    {
        input.Disable();
        input.XRILeftHandInteraction.ToDoUI.performed -= GhostingPreformed;
        input.XRILeftHandInteraction.ToDoUI.canceled -= GhostingPreformed;


    }

    private void OnEnable()
    {
        input.Enable();
        input.XRILeftHandInteraction.ToDoUI.performed += GhostingPreformed;
        input.XRILeftHandInteraction.ToDoUI.canceled += GhostingPreformed;
    }

    private void GhostingPreformed(InputAction.CallbackContext context)
    {
        canvasOn = !canvasOn;
        if (canvasOn) {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
       

    }

    private void GhostingCancelled(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
       // canvas.SetActive(false);
    }

}
