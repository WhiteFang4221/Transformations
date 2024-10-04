using DG.Tweening;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loops;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);
    }
}
