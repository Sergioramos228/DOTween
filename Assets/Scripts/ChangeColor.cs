using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private void Start()
    {
        TryGetComponent(out _spriteRenderer);
        _spriteRenderer.DOColor(Color.red, 0.5f).SetLoops(-1, LoopType.Yoyo);
        _spriteRenderer.DOFade(0, 2).SetLoops(-1, LoopType.Yoyo);
    }
}
