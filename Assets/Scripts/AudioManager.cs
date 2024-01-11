using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static float soundVolume = 0.5f;

    [SerializeField]
    private AudioSource audioSource;
    private static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        instance = this;

    }
    public void updateVolume(float volume)
    {
        soundVolume = volume;
    }


    public static void PlayFX(AudioClip FX)
    {
        instance.GetComponent<AudioSource>().PlayOneShot(FX);
    }

    private void Update()
    {
        if (audioSource != null)
            audioSource.volume = soundVolume;
    }
}
