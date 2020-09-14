using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int dogCooldown = 0;
    public int dogCooldownTime = 50;

    // Update is called once per frame
    void Update()
    {
        if(dogCooldown > 0)
        {
            dogCooldown--;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogCooldown == 0)
        {
            dogCooldown = dogCooldownTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
