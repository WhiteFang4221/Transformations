using DG.Tweening;
using UnityEngine;

public class ObjectScaler : TweenableObject
{
    [SerializeField] private Vector3 _targetScale;

    private void Start()
    {
        transform.DOScale(_targetScale, Duration)
            .SetLoops(Loops, LoopType)
            .SetEase(Ease.Linear);
    }
}
