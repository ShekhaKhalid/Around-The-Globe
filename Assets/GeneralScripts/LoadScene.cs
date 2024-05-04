using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private GameObject egyptBone;
    [SerializeField] private GameObject nameGameObject;

    public GameObject Bon;

    void Start()
    {

        //if (PlayerPrefs.GetInt("Bon", 0) == 1)
        //{

        //    Bon.SetActive(true);
        //}
        //else
        //{
        //    Bon.SetActive(false);
        //}
    }
    public void loadGallery()
    {
        SceneManager.LoadScene("newGallery");
    }

    public void loadEgypt()
    {
        SceneManager.LoadScene("Egypt");
        //egyptBone.SetActive(true);
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

    public void ShowName()
    {
        nameGameObject.SetActive(true);

    }
}
