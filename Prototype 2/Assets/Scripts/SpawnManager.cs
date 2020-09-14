using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPositionZ = 20;

    public HealthSystem HealthSystem;

    private void Start()
    {
        HealthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("spawnRandomAnimal", 2, 1.5f);
        StartCoroutine(SpawnRandomAnimalWithCoroutine());
    }

    IEnumerator SpawnRandomAnimalWithCoroutine()
    {
        //add 3 sec delay
        yield return new WaitForSeconds(3f);

        while(!HealthSystem.gameOver)
        {
            spawnRandomAnimal();

            float randomDelay = Random.Range(0.8f, 2.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //spawnRandomAnimal();
        }
    }

    void spawnRandomAnimal()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPositionZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPosition, prefabsToSpawn[prefabIndex].transform.rotation);

    }
}
