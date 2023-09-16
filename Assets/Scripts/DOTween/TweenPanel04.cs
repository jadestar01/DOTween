using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenPanel04 : TweenPanel
{
    public RectTransform rect;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .AppendCallback(() => rect.localScale = new Vector3(0, 0, 0))
        .Append(rect.DOScale(new Vector3(1, 1, 1), 1f).SetRelative(true).SetEase(Ease.InQuad))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        rect.localScale = new Vector3(0, 0, 0);
    }
}
