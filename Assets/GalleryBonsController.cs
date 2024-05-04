using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryBonsController : MonoBehaviour
{
    public GameObject Bon;
    public GameObject button;
    public TextMeshProUGUI text;

    public Counting countObj;
    

    void Start()
    {

        if (PlayerPrefs.GetInt("Bone", 0) == 1)
        {

            Bon.SetActive(true);
            text.gameObject.SetActive(true);
            button.SetActive(false);
        }
        else
        {
            Bon.SetActive(false);
            text.gameObject.SetActive(false);
            button.SetActive(true);
        }


        PlayerPrefs.SetInt("Bone", 0);
        PlayerPrefs.Save();
    }

    public void OnButtonClick()
    {
        
        SceneManager.LoadScene("Egypt");
    }
}
