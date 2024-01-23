using DG.Tweening;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_position, _duration);
    }
}
