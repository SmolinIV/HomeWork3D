using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChange : ConditionChanger
{
    [SerializeField] private Color _color;

    private SpriteRenderer _spriteRenderer;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(_color, _duration)
            .SetLoops(_repeatNumber, _loopType)
            .SetEase(Ease.Linear);
    }
}
