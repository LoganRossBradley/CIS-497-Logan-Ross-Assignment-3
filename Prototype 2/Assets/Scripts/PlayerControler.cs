//Logan Ross
//Assignment 3
//Controls player movement left and right. Also keeps player in bounds

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        //get Horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //transform Horizontally with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player inbounds
        if(transform.position.x < -14)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > 14)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
