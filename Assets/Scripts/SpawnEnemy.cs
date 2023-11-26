using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private List<Transform> _spawnPointsPositions;

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

            Enemy newEnemy = Instantiate(_enemy, _spawnPointsPositions[Random.Range(0,_spawnPointsPositions.Count)].transform.position, Quaternion.identity);
            newEnemy.SetDirection(Vector3.up);
        }
    }
}
