using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Static Instance
    private static AudioManager instance;
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned AudioManager", typeof(AudioManager)).GetComponent<AudioManager>();
                }
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    #endregion

    #region Fields
    public AudioSource sfxSource;
    public AudioSource LoopSource;
    #endregion

    private void Awake()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Music"));

        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioListener.pause = false;
        }
        else if (PlayerPrefs.GetInt("Sounds", 1) == 2)
        {
            AudioListener.pause = true;
        }
    }

    public void PauseMusic()
    {
        sfxSource.Pause();
        LoopSource.Pause();
    }
    public void UnPauseMusic()
    {
        sfxSource.UnPause();
        LoopSource.UnPause();
    }


    public void PlayMusic(AudioClip musicClip, float volume)
    {
        LoopSource.clip = musicClip;
        LoopSource.volume = volume;
        LoopSource.Play();
    }
    public void PlayMusicLoop(AudioClip musicClip, float volume)
    {
        LoopSource.clip = musicClip;
        LoopSource.volume = volume;
        LoopSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}