using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class typer : MonoBehaviour
{

    TMP_Text _tmpProText;
    string writer;
    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.1f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;
    public GameObject buttonToactivate;
    // Start is called before the first frame update
    void Start()
    {
        _tmpProText = GetComponent<TMP_Text>()!;

        if (_tmpProText != null)
        {
            writer = _tmpProText.text;
            _tmpProText.text = "";

            StartCoroutine(TypeWriterTMP());
            
        }


        IEnumerator TypeWriterTMP()
        {
            _tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

            yield return new WaitForSeconds(delayBeforeStart);

            foreach (char c in writer)
            {
                if (_tmpProText.text.Length > 0)
                {
                    _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
                }
                _tmpProText.text += c;
                _tmpProText.text += leadingChar;
                yield return new WaitForSeconds(timeBtwChars);
            }
            buttonToactivate.SetActive(true);

            if (leadingChar != "")
            {
                _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
            }
        }
    }

   
}