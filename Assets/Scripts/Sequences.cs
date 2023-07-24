using UnityEngine;
using DG.Tweening;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveY(3, 4).SetRelative());
        sequence.Insert(0, transform.DORotate(new Vector3(60, 15, 0), 2));
        sequence.Append(transform.DOMoveX(3, 4).SetRelative());
        sequence.Insert(4, transform.DORotate(new Vector3(0, 40, 15), 2));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
