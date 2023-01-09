using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingAudio : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    public AudioSource source;
    public HammerExplosion explosion;
    private int clipIndex = 0;
    

    void Start()
    {
        explosion.exploded += changeAudiocClip;
    }

    //idd dit is gewoon een copy van andere scripts, maar ik heb dit gewoon slecht geprogrammeerd. Niet alles hoeft mooi te zijn. Het moet wel werken.
    public void changeAudiocClip()
    {
        if (clipIndex + 1 < audioClips.Count)
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
