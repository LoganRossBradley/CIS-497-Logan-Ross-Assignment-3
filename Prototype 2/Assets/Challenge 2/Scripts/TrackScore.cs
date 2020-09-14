using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour
{
    public Text textbox; 

    public int score = 0;

    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
