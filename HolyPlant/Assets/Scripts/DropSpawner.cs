using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawner : MonoBehaviour
{

    [SerializeField]
    private Drop dropPrefab;

    [SerializeField]
    private float spawnMostLeft, spawnMostRight, spawnHeight;

    [SerializeField]
    private List<FallingObjectData> possibleDrops;


    [SerializeField]
    private float spawnPerSec, increasePerSecond;

    private float adjustedSpawnRate, spawnCounter;

    [SerializeField]
    private FallingObjectData dropData;



    private void Awake()
    {
        adjustedSpawnRate = spawnPerSec;
        spawnCounter = 0f;
    }



    private void SpawnDrop()
    {
        FallingObjectData data = possibleDrops[Random.Range(0, possibleDrops.Count)];


        Drop newDrop = Instantiate(dropPrefab);
        float xPosition = Random.Range(spawnMostLeft, spawnMostRight);
        newDrop.transform.position = new Vector3(xPosition, spawnHeight, 0f);
        newDrop.Initialize(data);

    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpawnDrop();

        spawnCounter -= Time.deltaTime;

        if(spawnCounter <0f)
        {
            SpawnDrop();
            spawnCounter = 1f / adjustedSpawnRate;
        }

    }

}
