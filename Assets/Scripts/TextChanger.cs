using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private int _loops;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("����� �����", _duration));
        sequence.Append(_text.DOText(_text.text + " � �����������", _duration));
        sequence.Append(_text.DOText("������ ��������", _duration, scrambleMode: ScrambleMode.All));

        sequence.SetLoops(_loops, _loopType);
    }
}
