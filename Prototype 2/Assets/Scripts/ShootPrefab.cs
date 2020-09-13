using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject PrefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PrefabToShoot, transform.position, PrefabToShoot.transform.rotation);
        }
    }
}
