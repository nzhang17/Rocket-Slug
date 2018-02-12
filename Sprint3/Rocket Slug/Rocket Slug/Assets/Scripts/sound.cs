using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class sound : MonoBehaviour
{
    //static var used to control sound from other scripts
    public static bool PLAY = true;

    //stops gameplay music
    void stopMusic()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Pause();
    }

    //plays gameplay music
    void playMusic()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.UnPause();
    }

    //constantly checks to see if music needs to be paused
    private void Update()
    {
        if (PLAY)
        {
            playMusic();
        }
        else
        {
            stopMusic();
        }
    }
}