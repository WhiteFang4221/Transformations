using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : TweenableObject
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("����� �����", Duration));
        sequence.Append(_text.DOText(_text.text + " � �����������", Duration));
        sequence.Append(_text.DOText("������ ��������", Duration, scrambleMode: ScrambleMode.All));

        sequence.SetLoops(Loops, LoopType);
    }
}
