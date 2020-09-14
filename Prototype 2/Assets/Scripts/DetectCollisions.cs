//Logan Ross
//Assignment 3
//Detects when food object collides with an animal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore DisplayScoreScript;

    private void Start()
    {
        //DisplayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreScript").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider Animal)
    {
        DisplayScoreScript.score++;
        Destroy(Animal.gameObject);
        Destroy(gameObject);
    }
}
