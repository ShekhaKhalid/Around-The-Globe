using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class GalleryBonsController : MonoBehaviour
{
    public GameObject Bon;
    public GameObject button;
    public TextMeshProUGUI text;

    void Start()
    {
   
        if (PlayerPrefs.GetInt("Bon", 0) == 1)
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
    }

    public void OnButtonClick()
    {
        // ·«  ‰”Ì‰  €Ì—Ì‰Â ·«”„ ”Ì‰ «·œÌ“— 
        SceneManager.LoadScene("Shope");
    }
}
