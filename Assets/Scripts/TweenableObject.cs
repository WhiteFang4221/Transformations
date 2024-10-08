using DG.Tweening;
using UnityEngine;

public abstract class TweenableObject : MonoBehaviour
{
    [field: SerializeField]
    public float Duration { get; private set; }
    [field: SerializeField]
    public LoopType LoopType { get; private set; }
    [field: SerializeField]
    public int Loops { get; private set; }
}
