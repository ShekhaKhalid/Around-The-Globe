using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    [SerializeField] AudioClip shovelclip;
    [SerializeField] AudioClip trowelclip; 
    [SerializeField] AudioClip brushclip;
    [SerializeField] AudioClip sieveclip;
    [SerializeField] AudioClip bucketclip;
    [SerializeField] AudioClip flashclip;
    [SerializeField] AudioClip spadclip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void playShovel()
    {
        audioSource.PlayOneShot(shovelclip);
    }

    public void playTrowel()
    {
        audioSource.PlayOneShot(trowelclip);
    }

    public void playBrush()
    {
        audioSource.PlayOneShot(brushclip);
    }

    public void playBucket()
    {
        audioSource.PlayOneShot(bucketclip);
    }

    public void playFlash()
    {
        audioSource.PlayOneShot(flashclip);
    }

    public void playSpade()
    {
        audioSource.PlayOneShot(spadclip);
    }

    public void playSeive()
    {
        audioSource.PlayOneShot(sieveclip);
    }
}
