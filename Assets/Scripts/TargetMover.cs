using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;

    [SerializeField] private int _speed;

    private int _currentPointIndex = 0;

    private Coroutine _targetMoveCoroutine;

    private void Start()
    {
        _targetMoveCoroutine = StartCoroutine(Move());
    }

    private void OnDestroy()
    {
        StopCoroutine(_targetMoveCoroutine);
    }

    private IEnumerator Move()
    {
        bool isWorking = true;

        while (isWorking)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[_currentPointIndex].position, _speed * Time.deltaTime);

            if (transform.position == _points[_currentPointIndex].position)
            {
                ChangeCurrentPoint();
            }

            yield return null;
        }
    }

    public void ChangeCurrentPoint()
    {
        _currentPointIndex++;

        _currentPointIndex = _currentPointIndex % _points.Count;
    }
}
