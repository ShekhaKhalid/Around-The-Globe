using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InputName : MonoBehaviour
{
    public static InputName inputName;
    public TMP_InputField playerNameInput;
    public string playerName;

    private void Awake()
    {
        if (inputName == null)
        {
            inputName = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }



    }
    public void StartGame()
    {
         playerName = playerNameInput.text;
        
       
        PlayerPrefs.SetString("PlayerName", playerName);

        SceneManager.LoadSceneAsync("Gallery");
    }
}

