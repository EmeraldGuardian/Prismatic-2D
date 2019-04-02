﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioObject : MonoBehaviour
{

    // Audio clip variable
    public AudioClip MusicClip;

    // the component that Unity uses to play your clip
    public AudioSource MusicSource;

    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
                    
    }
}
