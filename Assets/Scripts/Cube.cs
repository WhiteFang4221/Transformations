using DG.Tweening;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationAngles;
    [SerializeField] private float _duration;         
    [SerializeField] private RotateMode _rotateMode;  
    [SerializeField] private LoopType _loopType;      
    [SerializeField] private int _loops;              

    private void Start()
    {
        transform.DORotate(_rotationAngles, _duration, _rotateMode)
            .SetLoops(_loops, _loopType)
            .SetEase(Ease.Linear);  
    }
}
