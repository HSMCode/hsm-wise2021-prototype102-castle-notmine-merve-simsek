using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    public GameObject targetPrefab;
    public float respawnTime;
    public float y;

    void Start()
    {
        StartCoroutine(targetWave());
    }

    private void spawnTarget()
    {
        y = respawnTime = Random.Range(-0.3f, 4f);

        GameObject targetClone = Instantiate(targetPrefab) as GameObject;
        targetClone.transform.position = new Vector3(10f, y, 0f);
    }

    IEnumerator targetWave()
    {
        while (true)
        {
            respawnTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(respawnTime);
            spawnTarget();
        }
    }
}
