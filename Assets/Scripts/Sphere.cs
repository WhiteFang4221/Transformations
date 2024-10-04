using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loops;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_loops, _loopType);
    }
}
