using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{

    public Color targetColor = Color.white;
    public float transitionDuration = 2f;

    private Material material;
    private Color startColor;
    private bool isTransitioning = false;
    public bool isClean = false;
    private void Start()
    {
        // Get the Mesh Renderer component and the material
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;
        startColor = material.color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Brush" && !isClean)
        {

            StartCoroutine(TransitionColor());
        }
    }


    private System.Collections.IEnumerator TransitionColor()
    {
        isTransitioning = true;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            // Calculate the current color based on the elapsed time and transition duration
            float t = elapsedTime / transitionDuration;
            Color currentColor = Color.Lerp(startColor, targetColor, t);

            // Apply the current color to the material
            material.color = currentColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final color is set exactly to the target color
        material.color = targetColor;

        isTransitioning = false;
        isClean = true;
    }
}
