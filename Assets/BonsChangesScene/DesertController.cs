using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DesertController : MonoBehaviour
{
    void Start()
    {

        PlayerPrefs.SetInt("Bon", 1);
        PlayerPrefs.Save(); 

        StartCoroutine(BackToHomeAfterDelay());
    }

    IEnumerator BackToHomeAfterDelay()
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("newGallery");
    }
}
