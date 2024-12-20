using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.Events;

public class FMOD_StingerEnd : MonoBehaviour
{
    public FMOD_MusicPlayer musicPlayer;
    public EventReference musicStinger;
    public UnityEvent triggerText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            musicPlayer.StopMusic();
            RuntimeManager.PlayOneShot(musicStinger);
            triggerText.Invoke();
            
        }
    }
}
