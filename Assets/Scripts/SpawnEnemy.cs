using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPointsPositions;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        float waitSecondsAmount = 2.0f;

        var waitForSeconds = new WaitForSeconds(waitSecondsAmount);

        while (true)
        {
            yield return waitForSeconds;

            SpawnPoint spawnPoint = _spawnPointsPositions[Random.Range(0, _spawnPointsPositions.Count)];

            Enemy newEnemy = Instantiate(spawnPoint.Enemy, spawnPoint.transform.position, Quaternion.identity);
            newEnemy.SetTarget(spawnPoint.Target);
        }
    }
}
