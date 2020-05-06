using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        AddNonTriggerBoxCollider(); 
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider nonTriggerCollider = gameObject.AddComponent<BoxCollider>();
        nonTriggerCollider.isTrigger = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        print("It hit" + gameObject.name);
        Destroy(gameObject);
    }
}
