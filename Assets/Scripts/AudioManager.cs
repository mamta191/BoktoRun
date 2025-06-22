using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;


    public AudioClip jumpSound;
    public AudioClip deadSound;
    public AudioClip scoreSound;
    public AudioClip buttonSound;


    public AudioSource eventSound;
    public AudioSource bgSound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }


    public void PlaySound(AudioClip sound)
    {
        eventSound.PlayOneShot(sound);
    }


    public void ButtonSound()
    {
        PlaySound(buttonSound);
    }

    public void JumpSound()
    {
        PlaySound(jumpSound);
    }

    public void DeadSound()
    {
        PlaySound(deadSound);
    }

    public void ScoreSound()
    {
        PlaySound(scoreSound);
    }

}
