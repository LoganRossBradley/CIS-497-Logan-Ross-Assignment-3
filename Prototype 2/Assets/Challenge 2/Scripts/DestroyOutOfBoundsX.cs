//Logan Ross
//Assignment 3
//Destroys objects that travel off screen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -22;
    private float bottomLimit = -1;

    private HealthSystemX HealthSystemXScript;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < bottomLimit)
        {
            HealthSystemXScript.health--;
            Destroy(gameObject);
        }

    }
}
