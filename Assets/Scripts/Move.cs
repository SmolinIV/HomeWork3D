using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] private float _distance = 3;
    [SerializeField, Min(0)] private float _duration = 5;
    [SerializeField, Min(-1)] private int _repeatNumber = -1;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMoveY(transform.position.y + _distance, _duration).SetLoops(_repeatNumber, _loopType);
    }
}
