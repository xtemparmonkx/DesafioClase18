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
    // Start is called before the first frame update
    void Start()
    {
        //alarmSound.Play(false);
        sound = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        FloorTrigger.soundTriggered += SetSoundOn;
    }
    private void SetSoundOn()
    {
        alarmSound.Play();
        sound = true;
    }
}
