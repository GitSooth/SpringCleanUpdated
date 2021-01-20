using System;
using UnityEngine.Audio;
using UnityEngine;

[Serializable]
public class Sound
{
    public AudioClip clip;

    public string name;

    [Range(0, 1)]
    public float volume;
    [Range(.1f, 2)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
