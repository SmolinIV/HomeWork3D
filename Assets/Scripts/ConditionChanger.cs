using DG.Tweening;
using UnityEngine;

public abstract class ConditionChanger : MonoBehaviour
{
    [SerializeField, Min(0)] protected float _duration;
    [SerializeField, Min(-1)] protected int _repeatNumber;
    [SerializeField] protected LoopType _loopType;
    
}
