using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 3).From().SetDelay(3).SetLoops(5, LoopType.Yoyo);
    }
}
