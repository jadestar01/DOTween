using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenPanel03 : TweenPanel
{
    public RectTransform rect;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .AppendCallback(() => rect.localRotation = Quaternion.Euler(0, 0, 0))
        .Append(rect.DORotate(new Vector3(0, 0, 360), 4f).SetRelative(true))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        rect.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
