using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundToPlay;
    public string tagName;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagName))
        {
            audioSource.PlayOneShot(soundToPlay);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagName))
        {
            if (audioSource.isPlaying)
            {
                return;
            }
            else
            {
                audioSource.PlayOneShot(soundToPlay);
            }
           
        }
    }

}
