using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;

    [SerializeField]
    AudioClip sndOpen, sndDenied;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" && CanOpen)
        {
            GetComponent<Animator>().enabled = true;
            myAudioSource.PlayOneShot(sndOpen);
        }
        else
        {
            myAudioSource.PlayOneShot(sndDenied);
        }
    }
}
