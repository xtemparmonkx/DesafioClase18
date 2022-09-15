using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorTrigger : MonoBehaviour
{
    public UnityEvent OnFloorTrigger;
    public UnityEvent OnlightsTrigger;
    public UnityEvent OnsoundTrigger;
    public static event UnityAction FloorTriggered;
    public static event UnityAction lightsTriggered;
    public static event UnityAction soundTriggered;

    public static void OnFloorTriggered() => FloorTriggered?.Invoke();
    public static void OnFloorTriggeredLights() => lightsTriggered?.Invoke();
    public static void OnFloorTriggeredSound() => soundTriggered?.Invoke();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER PISANDO TRAMPA");
            FloorTriggered?.Invoke();
            lightsTriggered?.Invoke();
            soundTriggered?.Invoke();
        }
    }
    
    
}
