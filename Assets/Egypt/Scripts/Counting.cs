using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counting : MonoBehaviour
{
    public int bones = 0;
    public Animator anim;
    public GameObject player;
    public GameObject newPos;
    public AudioSource talking;
    public Animator[] image;
    public int i;
    private bool isAudioPlaying = false;
    public GameObject canva;
    public void addOne()
    {
        bones++;
        if (bones == 2)
        {
            player.transform.position = newPos.transform.position;
            anim.SetBool("Talk", true);
            isAudioPlaying = true;
            talking.Play();
            canva.SetActive(true);
            StartCoroutine(Count1());
            
        }
    }
    private void Update()
    {
        if (isAudioPlaying && !talking.isPlaying)
        {
            isAudioPlaying = false;
            SceneManager.LoadScene("Gallery");
        }
    }
    private IEnumerator Count1()
    {
        yield return new WaitForSeconds(3);
       image[i++].SetBool("fade", true); 
       
        yield return null;
        yield return new WaitForSeconds(6);
        image[i++].SetBool("fade", true);

        yield return null;
        yield return new WaitForSeconds(9);
        image[i++].SetBool("fade", true);
    }
 
}


