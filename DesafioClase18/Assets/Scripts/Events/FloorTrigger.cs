using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorTrigger : MonoBehaviour
{
    public UnityEvent OnFloorTrigger;
    public static event UnityAction FloorTriggered;
    public static void OnFloorTriggered() => FloorTriggered?.Invoke();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER INGRESANDO EN EL AREA");
            FloorTriggered?.Invoke();
        }
    }
    
    
}
