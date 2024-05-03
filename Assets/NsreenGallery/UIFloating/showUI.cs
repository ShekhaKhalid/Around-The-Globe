using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour
{
    public GameObject WhaleUI;
    public GameObject RedSeaUI;
    public GameObject MammothUI;
    public GameObject HomininUI;
    public GameObject ArchaeoptreyxUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedSea"))
        {           
            RedSeaUI.SetActive(true);
           
        }
        else if (other.CompareTag("Whale"))
        {
            WhaleUI.SetActive(true);


        }
        else if (other.CompareTag("Mammoth"))
        {
            MammothUI.SetActive(true);


        }
        else if (other.CompareTag("Hominin"))
        {
            HomininUI.SetActive(true);


        }
        else if (other.CompareTag("Archaeoptreyx"))
        {
            ArchaeoptreyxUI.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RedSea"))
        {
            RedSeaUI.SetActive(false);

        }
        else if (other.CompareTag("Whale"))
        {
            WhaleUI.SetActive(false);


        }
        else if (other.CompareTag("Mammoth"))
        {
            MammothUI.SetActive(false);


        }
        else if (other.CompareTag("Hominin"))
        {
            HomininUI.SetActive(false);


        }
        else if (other.CompareTag("Archaeoptreyx"))
        {
            ArchaeoptreyxUI.SetActive(false);

        }
    }
}


