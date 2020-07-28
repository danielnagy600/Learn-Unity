using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAudio : MonoBehaviour
{
    private AudioSource ZombieVoice;

    public void Awake()
    {
        ZombieVoice = GetComponent<AudioSource>();
   
    }

    public void Death()
    {
        //Életereje lecsökken
        ZombieVoice.Stop();
    }
}
