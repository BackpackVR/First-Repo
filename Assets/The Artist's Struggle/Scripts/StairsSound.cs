using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundToPlay;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(soundToPlay);
        }
    }

}
