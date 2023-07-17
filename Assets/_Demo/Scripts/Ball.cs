using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _doorCollider;


    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {

        Debug.Log("FixedUpdate");
    }

    private void Start()
    {
        _rigidbody.AddForce(Vector3.forward * _force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider == _doorCollider)
        {
            Debug.Log("Collided with door");
        }
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
