using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    public HealthSystem healthSystemScrypt;

    private void Start()
    {
        healthSystemScrypt = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            healthSystemScrypt.TakeDamage();
            Destroy(gameObject);
        }
    }
}
