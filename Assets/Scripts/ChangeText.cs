using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private float _delay = 2f;

    private void Start()
    {
        _text.DOText("Hello", _duration).OnComplete(StartNextAnimation);
    }

    private void StartNextAnimation()
    {
        _text.DOText(" World", _duration).SetRelative().SetDelay(_delay).OnComplete(StartFinalAnimation);
    }

    private void StartFinalAnimation()
    {
        _text.DOText("I see you", _duration, true, ScrambleMode.All).SetDelay(_delay);
    }
}
