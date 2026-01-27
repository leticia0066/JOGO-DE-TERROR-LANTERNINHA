using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [System.Serializable]
    public class Sound
    {
        public string id;
        public AudioClip clip;
        public bool loop;
        [Range(0f,1f)] public float volume = 1f;
    }

    public List<Sound> musics;
    public List<Sound> sfx;

    AudioSource musicSource;
    AudioSource sfxSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            musicSource = gameObject.AddComponent<AudioSource>();
            sfxSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(string id)
    {
        Sound s = musics.Find(x => x.id == id);
        if (s == null) return;

        musicSource.clip = s.clip;
        musicSource.loop = s.loop;
        musicSource.volume = s.volume;
        musicSource.Play();
    }

    public void PlaySFX(string id)
    {
        Sound s = sfx.Find(x => x.id == id);
        if (s == null) return;

        sfxSource.PlayOneShot(s.clip, s.volume);
    }
}
