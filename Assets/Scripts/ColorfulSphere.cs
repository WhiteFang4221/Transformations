using DG.Tweening;
using UnityEngine;

public class ColorfulSphere : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loops;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, _duration)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);
    }
}
