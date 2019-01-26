using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnLocation;
    public Transform spawnLocation2;

    public void Start()
    {
        StartCoroutine(BeginStage());
    }

    public IEnumerator BeginStage()
    {
        GameObject one = Instantiate(enemyPrefab);
        one.transform.position = spawnLocation.position;
        yield return null;
        yield return new WaitUntil(() => one == null);
        GameObject two = Instantiate(enemyPrefab);
        two.transform.position = spawnLocation2.position;
        yield return null;
    }
}
