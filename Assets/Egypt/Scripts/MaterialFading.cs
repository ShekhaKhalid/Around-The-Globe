using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFading : MonoBehaviour
{
  
    public Renderer meshRenderer; // Reference to the Mesh Renderer component

    public int materialIndexA = 0; // Index of Material A in the materials array
    public int materialIndexB = 1; // Index of Material B in the materials array

    public float startAlphaA = 1f; // Initial alpha value for Material A
    public float endAlphaA = 0f; // Final alpha value for Material A

    public float startAlphaB = 0f; // Initial alpha value for Material B
    public float endAlphaB = 1f; // Final alpha value for Material B

    public float fadeDuration = 2f; // Duration of the fading effect

    private MaterialPropertyBlock materialProperties; // Material property block to modify material properties

    private bool isFading; // Flag to indicate if the fading effect is currently active
    private float startTime; // Time when the fading effect starts

    private void Start()
    {
        materialProperties = new MaterialPropertyBlock();
        isFading = false;
        StartFading();
    }

    private void Update()
    {
        if (isFading)
        {
            float t = Mathf.Clamp01((Time.time - startTime) / fadeDuration); // Calculate interpolation factor based on time
           
            // Update alpha values for Material A and Material B
            float currentAlphaA = Mathf.Lerp(startAlphaA, endAlphaA, t);
            SetMaterialAlpha(materialIndexA, currentAlphaA);

            float currentAlphaB = Mathf.Lerp(startAlphaB, endAlphaB, t);
            SetMaterialAlpha(materialIndexB, currentAlphaB);
        }
    }

    private void SetMaterialAlpha(int materialIndex, float alpha)
    {
        // Get the current color of the material
        Color color = meshRenderer.sharedMaterials[materialIndex].color;

        // Set the alpha value of the color
        color.a = alpha;

        // Apply the modified color to the material property block
        materialProperties.SetColor("tt", color);

        // Apply the material property block to the Mesh Renderer
        meshRenderer.SetPropertyBlock(materialProperties, materialIndex);

        meshRenderer.SetPropertyBlock(materialProperties);
    }

    public void StartFading()
    {
        if (!isFading)
        {
            startTime = Time.time;
            isFading = true;
        }
    }

    public void StopFading()
    {
        isFading = false;
    }
}


