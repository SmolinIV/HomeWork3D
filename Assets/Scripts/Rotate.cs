using UnityEngine;
using DG.Tweening;

public class Rotate : ConditionChanger
{
    [SerializeField] protected Vector3 _direction;
    [SerializeField] protected RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_direction, _duration, _rotateMode)
            .SetLoops(_repeatNumber, _loopType)
            .SetEase(Ease.Linear);
    }
}
