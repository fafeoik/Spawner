using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;

    private int _currentPointIndex = 0;
    private int _speed = 3;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPointIndex].position, _speed * Time.deltaTime);

        if(transform.position == _points[_currentPointIndex].position)
        {
            ChangeCurrentPoint();
        }
    }

    public void ChangeCurrentPoint()
    {
        _currentPointIndex++;

        _currentPointIndex = _currentPointIndex % _points.Count;
    }
}
