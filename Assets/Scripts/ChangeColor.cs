using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _spriteRenderer.DOColor(_targetColor, _duration).SetLoops(-1, _loopType).SetEase(Ease.Linear);
    }
}
