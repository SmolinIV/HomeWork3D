using DG.Tweening;
using UnityEngine;

public class ScaleChange : ConditionChanger
{
    [SerializeField] protected Vector3 _endScale;

    private void Start()
    {
        transform.DOScale(_endScale, _duration).
            SetLoops(_repeatNumber, _loopType)
            .SetEase(Ease.Linear);
    }
}
