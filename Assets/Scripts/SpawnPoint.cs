using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private Transform _target;

    public void SpawnEnemy()
    {
        EnemyMover newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        newEnemy.SetTarget(_target);
    }
}
