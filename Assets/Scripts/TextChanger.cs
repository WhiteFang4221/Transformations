using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : TweenableObject
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Ќовый текст", Duration));
        sequence.Append(_text.DOText(_text.text + " с добавлением", Duration));
        sequence.Append(_text.DOText("Ёффект перебора", Duration, scrambleMode: ScrambleMode.All));

        sequence.SetLoops(Loops, LoopType);
    }
}
