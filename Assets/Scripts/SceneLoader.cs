using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    private void Update()
    {
        //TODO check if splash screen
        if (Input.GetKey(KeyCode.Space) && currentSceneIndex == 0)
        {
            LoadFirstScene();
            print("Space!");
        }
    }


    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    public void CallReloadScene()
    {
        StartCoroutine(ReloadScene()); 
    }

    IEnumerator ReloadScene()
    {
       yield return new WaitForSeconds(1f);
       SceneManager.LoadScene(1);
    }


}
