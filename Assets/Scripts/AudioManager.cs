using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.name = s.name;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();
    }

    public void PlayLoop(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.loop = true;
        s.source.Play();
    }

    public void StopLoop(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.loop = false;
        s.source.Stop();
    }
}
