using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {
        _slider.DOValue(1, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
