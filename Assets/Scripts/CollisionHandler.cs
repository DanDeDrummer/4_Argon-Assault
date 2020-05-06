using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    string otherCollider;
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    private void OnTriggerEnter(Collider other)
    {
        otherCollider = other.name;
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {       
        print("Player Dying from" + otherCollider);
        SendMessage("OnPlayerDeath");//PlayerController Script
        deathFX.SetActive(true);
        sceneLoader.CallReloadScene();
    }

    
}
