using System;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator _doorAnimator;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        _doorAnimator.SetTrigger("Open");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
