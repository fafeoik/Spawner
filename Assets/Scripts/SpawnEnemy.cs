using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPointsPositions;

    private Coroutine _spawnCoroutine;

    private void Start()
    {
        _spawnCoroutine = StartCoroutine(Spawn());
    }

    private void OnDestroy()
    {
        StopCoroutine(_spawnCoroutine);
    }

    private IEnumerator Spawn()
    {
        float waitSecondsAmount = 2.0f;

        var waitForSeconds = new WaitForSeconds(waitSecondsAmount);

        while (true)
        {
            yield return waitForSeconds;

            SpawnPoint spawnPoint = _spawnPointsPositions[Random.Range(0, _spawnPointsPositions.Count)];

            spawnPoint.SpawnEnemy();
        }
    }
}
