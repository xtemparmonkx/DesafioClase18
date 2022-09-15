using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Alarm : MonoBehaviour
{
    public GameObject alarmLight;
    public static event Action turnOnLights;
    private bool on = false;
     

    // Start is called before the first frame update
    void Start()
    {
        alarmLight.SetActive(false);
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        FloorTrigger.lightsTriggered += SetLightsOn;
    }
    private void SetLightsOn()
    {
        alarmLight.SetActive(true);
        on = true;
    }
    
}
