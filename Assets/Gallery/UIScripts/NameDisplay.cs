using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;


    public void Awake()
    {
        playerNameText.text = InputName.inputName.playerName;
    }

}


