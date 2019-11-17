using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = audioClip;
        musicSource.Play();
    }
}
