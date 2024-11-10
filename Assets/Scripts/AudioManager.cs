using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public Sound[] sounds;

    private Sound currentBackgroundMusic;

    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);

        if(s == null)
        {
            Debug.LogError("Sound not found: " + sound);
            return;
        }
        if(s.source == null)
        {
            Debug.LogError("AudioSource is null for sound: " + sound);
            return;
        }
        s.source.Play();
    }

    public void PlayBackgroundMusic(string soundName)
    {
        if(currentBackgroundMusic != null && currentBackgroundMusic.source.isPlaying)
        {
            currentBackgroundMusic.source.Stop();
        }

        Sound s = Array.Find(sounds, item => item.name == soundName);
        if(s == null)
        {
            Debug.LogError("Background music not found: " + soundName);
            return;
        }
        if(s.source == null)
        {
            Debug.LogError("AudioSource is null for background music: " + soundName);
            return;
        }
        currentBackgroundMusic = s;
        s.source.Play();
    }

}

