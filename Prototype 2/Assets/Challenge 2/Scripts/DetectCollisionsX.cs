using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore DisplayScoreScript;


    private void OnTriggerEnter(Collider other)
    {
        DisplayScoreScript.score++;
        Destroy(gameObject);
    }
}
