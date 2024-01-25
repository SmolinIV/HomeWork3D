using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField, Min(0)] private float _duration;
    [SerializeField, Min(-1)] private int _repeatNumber;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_direction, _duration, _rotateMode).SetLoops(_repeatNumber, _loopType).SetEase(Ease.Linear);
    }
}
