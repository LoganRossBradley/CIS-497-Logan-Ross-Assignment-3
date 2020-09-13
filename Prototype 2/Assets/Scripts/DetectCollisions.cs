using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider Animal)
    {
        Debug.Log("Hit!");

        Destroy(Animal.gameObject);
        Destroy(gameObject);
    }
}
