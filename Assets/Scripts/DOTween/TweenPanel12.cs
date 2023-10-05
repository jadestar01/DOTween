using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenPanel12 : TweenPanel
{
    public RectTransform rect1;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(rect1.DOShakePosition(3, 100, 10, 90))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        rect1.DOAnchorPos(Vector3.zero, 0);
    }
}
