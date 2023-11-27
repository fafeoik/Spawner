using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Transform _target;

    private Coroutine _enemyMoveCoroutine;

    private void Start()
    {
        _enemyMoveCoroutine = StartCoroutine(Move());
    }

    private void OnDestroy()
    {
        StopCoroutine(_enemyMoveCoroutine);
    }

    private IEnumerator Move()
    {
        bool isWorking = true;

        while (isWorking)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

            yield return null;
        }
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
