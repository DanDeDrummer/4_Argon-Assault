using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
   [Header("General")]
   [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;
   [Tooltip("In m")] [SerializeField] float xRange = 3.66f;
   [Tooltip("In ms^-1")] [SerializeField] float ySpeed = 40f;
   [SerializeField] float yRangeMin = -1.78f;
   [SerializeField] float yRangeMax = 1.78f;
  

   [Header("Screen-position Based")]
   [SerializeField] float positionPitchFactor = -5f;
   [SerializeField] float positionYawFactor = 5f;

   [Header("Control Throw Based")]
   [SerializeField] float controlPitchFactor = -20f;
   [SerializeField] float controlRollFactor = -20f;

    [Header("Guns")]
    [SerializeField] GameObject Gun1;
    [SerializeField] GameObject Gun2;
    [SerializeField] GameObject Gun3;
    [SerializeField] GameObject Gun4;
    float xThrow, yThrow;
   bool isControlEnabled = true;




    // Update is called once per frame
    void Update()
    {
        if (isControlEnabled)
        {
            ProcessTranslation();
            ProcessRotation();
        }

    }

    void OnPlayerDeath()//called by styrring reference
    {
        isControlEnabled = false;
        //TODO Move to fire button
        Gun1.SetActive(false);
        Gun2.SetActive(false);
        Gun3.SetActive(false);
        Gun4.SetActive(false);
    }

    private void ProcessRotation()
    {
        float pitch = (transform.localPosition.y * positionPitchFactor) + (yThrow * controlPitchFactor);
        float yaw = transform.localPosition.x * positionYawFactor;
        float roll = (xThrow * controlRollFactor);
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void ProcessTranslation()
    {
        //Horizontal Axis
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffest = xThrow * xSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffest;
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

        //Vertical Axis
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, yRangeMin, yRangeMax);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }
}
