using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private List<Transform> _spawnPointsPositions;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        while (true)
        {
            yield return waitForSeconds;

            Enemy newEnemy = Instantiate(enemy, _spawnPointsPositions[Random.Range(0,_spawnPointsPositions.Count)].transform.position, Quaternion.identity);
            newEnemy.SetDirection(Vector3.up);
        }
    }
}
