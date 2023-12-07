using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float spawnTimeInterval;
    float spawnTime = 0.9f;

    // Update is called once per frame
    void Update()
    {
        spawnTimeInterval += Time.deltaTime;  
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTimeInterval > spawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnTimeInterval = 0;


        }



    }
}
