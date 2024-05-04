using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

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

    public bool showBone = false;
    public event System.Action OnShowBoneChanged;


    void Start()
    {

        PlayerPrefs.SetInt("Bone", 1);
        PlayerPrefs.Save();
    }

        public void addOne()
    {
        bones++;
        if (bones == 2)
        {
            player.transform.position = newPos.transform.position;
            anim.SetBool("Talk", true);
            isAudioPlaying = true;
            talking.Play();
            PlayerPrefs.SetInt("Bon", 1);
            PlayerPrefs.Save();
            StartCoroutine(Count1());
            
        }
    }
    private void Update()
    {
        if (isAudioPlaying && !talking.isPlaying)
        {
            isAudioPlaying = false;

            //OnShowBoneChanged();

            showBone = true;
            OnShowBoneChanged?.Invoke();
            SceneManager.LoadScene("newGallery");
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


