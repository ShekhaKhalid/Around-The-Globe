using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationOfHands : MonoBehaviour
{
   

    public InputActionProperty PinchAnimation;
    public InputActionProperty GripAmination;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float triggerValue = PinchAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);


        float gripValue = GripAmination.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}


