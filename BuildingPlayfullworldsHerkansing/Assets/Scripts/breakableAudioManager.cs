using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class breakableAudioManager : MonoBehaviour
{

    public BreakableObjectManager breakableManager;
    public List<AudioClip> audioClips = new List<AudioClip>();
    public AudioSource source;
    private int clipIndex = 0;
    void Start()
    {
        breakableManager.isDestroyed += changeAudiocClip;
    }

    public void changeAudiocClip()
    {
        if (clipIndex < audioClips.Count && source)
        {
            source.clip = audioClips[clipIndex];
            source.Play();
            clipIndex += 1;
        }
        else if (source)
        {
            source.Play();
        }
    }
}
