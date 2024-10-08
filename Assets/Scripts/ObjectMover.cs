using DG.Tweening;
using UnityEngine;

public class ObjectMover : TweenableObject
{
    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        transform.DOMove(_targetPosition, Duration).SetLoops(Loops, LoopType);
    }
}
