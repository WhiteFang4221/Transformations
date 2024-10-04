using DG.Tweening;
using UnityEngine;

public class SuperCube : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loops;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);
        transform.DORotate(_targetRotation, _duration, RotateMode.FastBeyond360)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);
        transform.DOScale(_targetScale, _duration)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);
    }
}
