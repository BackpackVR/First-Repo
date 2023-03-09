using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    public AudioMixerSnapshot clubMusicSnap;
    public AudioMixerSnapshot voiceOverSnap;


    public void LowerMusicLevel()
    {
        voiceOverSnap.TransitionTo(0.5f);
    }

    public void ResumeMusicLevel()
    {
        clubMusicSnap.TransitionTo(0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
