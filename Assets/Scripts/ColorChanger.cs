using DG.Tweening;
using UnityEngine;

public class ColorChanger : TweenableObject
{
    [SerializeField] private Color _targetColor;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, Duration)
            .SetLoops(Loops, LoopType)
            .SetEase(Ease.Linear);
    }
}
