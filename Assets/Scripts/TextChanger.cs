using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private float _delay = 2f;
    private string _textString;

    private void Start()
    {
        _textString = "Hello";
        _text.DOText(_textString, _duration).OnComplete(StartNextAnimation);
    }

    private void StartNextAnimation()
    {
        _textString = " World";
        _text.DOText(_textString, _duration).SetRelative().SetDelay(_delay).OnComplete(StartFinalAnimation);
    }

    private void StartFinalAnimation()
    {
        _textString = "I see you";
        _text.DOText(_textString, _duration, true, ScrambleMode.All).SetDelay(_delay);
    }
}
