using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class AlarmSound : MonoBehaviour
{
    
    public AudioSource alarmSound;
    public static event Action turnOnSound;
    private bool sound = false;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        FloorTrigger.soundTriggered += SetSoundOn;
        sound = true;
    }

    private void OnDisable()
    {
        FloorTrigger.soundTriggered -= SetSoundOn;
        sound = false;
    }
    private void SetSoundOn()
    {
        alarmSound.Play();
        sound = true;
    }
}
