using DG.Tweening;
using UnityEngine;

public class ObjectRotator : TweenableObject
{
    [SerializeField] private Vector3 _rotationAngles;        
    [SerializeField] private RotateMode _rotateMode;               

    private void Start()
    {
        transform.DORotate(_rotationAngles, Duration, _rotateMode)
            .SetLoops(Loops, LoopType)
            .SetEase(Ease.Linear);  
    }
}
