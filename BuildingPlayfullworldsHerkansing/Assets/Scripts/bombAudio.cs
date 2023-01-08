using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombAudio : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    public AudioSource source;
    public Explosion explosionScript;
    private int clipIndex = 0;
    private void Start()
    {
        explosionScript.exploded += changeAudiocClip;
    }

    public void changeAudiocClip()
    {
        if (clipIndex < audioClips.Count)
        {
            clipIndex += 1;
            source.clip = audioClips[clipIndex];
            source.Play();
        }else
        {
            source.Play();
        }
    }
}
