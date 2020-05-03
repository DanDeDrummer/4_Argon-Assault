using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
   [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;
   [Tooltip("In ms^-1")] [SerializeField] float xRange = 3.66f;
   [Tooltip("In ms^-1")] [SerializeField] float ySpeed = 40f;

    float yRangeMin = -1.78f;
    float yRangeMax = 1.78f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();

    }

    private void ProcessRotation()
    {
        transform.localRotation = Quaternion.Euler(0f,90f,0f);
    }

    private void ProcessTranslation()
    {
        //Horizontal Axis
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffest = xThrow * xSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffest;
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

        //Vertical Axis
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, yRangeMin, yRangeMax);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }
}
