using UnityEngine;
using DG.Tweening;

public class Move : ConditionChanger
{
    [SerializeField] protected Vector3 _distance;

    private void Start()
    {
        transform.DOMove(_distance, _duration)
            .SetLoops(_repeatNumber, _loopType)
            .SetEase(Ease.Linear);
    }
}
