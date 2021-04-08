using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    public void PlayAudio()
    {
        audioSource.Play();
    }
    // Update is called once per frame
    public void OffAudio()
    {
        audioSource.Stop();
    }
  
}
