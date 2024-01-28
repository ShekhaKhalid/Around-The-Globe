using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToDoCanvas : MonoBehaviour
{
    public TextMeshProUGUI[] texts;
    public Image[] images;
    public int i = 0;
   public void scratchItem()
    {
        texts[i].fontStyle |= FontStyles.Strikethrough;
        Color currentColor = images[i].color;
        currentColor.a = 0.4f;
        images[i].color = currentColor;
        i++;
    }
}
