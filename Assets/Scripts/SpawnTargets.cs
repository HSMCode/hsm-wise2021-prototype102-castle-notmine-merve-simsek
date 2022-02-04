using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnTargets : MonoBehaviour
{
    public GameObject targetPrefab;
    public float respawnTime;
    public float y;
    private float minYRange;
    private float maxYRange;
    private float minRespawnTime;
    private float maxRespawnTime;

    private float timer;

    void Start()
    {
        StartCoroutine(targetWave());
        minYRange = -0.3f;
        maxYRange = 4f;

        minRespawnTime = 1f;
        maxRespawnTime = 3f;

        timer = 0f;
    }

    private void spawnTarget()
    {
        y = Random.Range(minYRange, maxYRange);

        GameObject targetClone = Instantiate(targetPrefab) as GameObject;
        targetClone.transform.position = new Vector3(10f, y, 0f);
        
    }

    IEnumerator targetWave()
    {
        while (true)
        {
            respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
            yield return new WaitForSeconds(respawnTime);
            spawnTarget();
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 25)
        {
            minRespawnTime = 0.5f;
            maxRespawnTime = 2f;
            Debug.Log("faster");
        }
        
        if (timer > 50f)
        {
            minRespawnTime = 0.25f;
            maxRespawnTime = 1.5f;
            Debug.Log("fasterfaster");
        }
    }
}
