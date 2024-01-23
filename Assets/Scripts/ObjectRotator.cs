using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _rotationAmount;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _rotationAmount, 0), _duration, RotateMode.FastBeyond360)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
