//Logan Ross
//Assignment 3
//Detects when food object collides with an animal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void Start()
    {
        //DisplayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreScript").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Animal"))
        DisplayScore.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
