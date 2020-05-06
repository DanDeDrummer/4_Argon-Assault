﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    bool firstLoad = true;

    private void Update()
    {
        //TODO check if splash screen
        if (Input.GetKey(KeyCode.Space) && firstLoad == true)
        {
            LoadFirstScene();
            firstLoad = false;
            print("Space!");
        }
    }


    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }


}
