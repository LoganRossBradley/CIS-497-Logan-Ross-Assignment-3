﻿//Logan Ross
//Assignment 3
//Desplays and updates the scoreboard

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        score = 0;

        textbox.text = "Score: 0";
    }

// Update is called once per frame
void Update()
    {
        textbox.text = "Score: " + score;
    }
}
