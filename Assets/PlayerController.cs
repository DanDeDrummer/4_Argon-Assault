using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //TODO Extract Method
        //Horizontal Axis
        float horizontalThrow = Input.GetAxis("Horizontal");
        print(horizontalThrow);
        /*var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        //Vertical Axis
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, newYPos);*/
    }
}
