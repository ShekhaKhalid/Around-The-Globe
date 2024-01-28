using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private GameObject egyptBone;
    public void loadGallery()
    {
        SceneManager.LoadScene("Gallery");
    }

    public void loadEgypt()
    {
        SceneManager.LoadScene("Egypt");
        egyptBone.SetActive(true);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
