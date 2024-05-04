using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectsManager : MonoBehaviour
{
    public Counting c;
    public GameObject verbreta;

    private bool shouldShowBone = false;

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        // Hide the "verbreta" object initially
        verbreta.SetActive(false);
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the target scene has been loaded
        if (scene.name == "Egypt")
        {
            shouldShowBone = true;
            UpdateObjectVisibility();
        }
    }

    private void UpdateObjectVisibility()
    {
        verbreta.SetActive(shouldShowBone && c.showBone);
    }

   
}