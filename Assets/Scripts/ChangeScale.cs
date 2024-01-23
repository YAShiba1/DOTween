using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private float _scaleValue;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;


    private void Start()
    {
        transform.DOScale(_scaleValue, _duration).SetLoops(-1, _loopType).SetEase(Ease.Linear);
    }
}
