//Logan Ross
//Assignment 3
//Tracks if the game has ended as well as reseting the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public HealthSystem2 healthSystemScrypt;
    public static bool gameOver;
    public Text txtGameOver;

    // Start is called before the first frame update
    void Start()
    {
        healthSystemScrypt = GameObject.FindGameObjectWithTag("HealthSystem2").GetComponent<HealthSystem2>();
        gameOver = false;
        txtGameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(healthSystemScrypt.health <= 0)
        {
            gameOver = true;

            txtGameOver.text = "Game Over \nPress R to restart";
        }

        if(Input.GetKeyDown(KeyCode.R) && gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
