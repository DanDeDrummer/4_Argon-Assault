using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    string otherCollider;

    private void OnTriggerEnter(Collider other)
    {
        otherCollider = other.name;
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {       
        print("Player Dying from" + otherCollider);
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadScene",2f);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(1);
        print("Reloaded Scene");
    }
}
