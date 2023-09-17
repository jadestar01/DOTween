using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TweenPanel08 : TweenPanel
{
    public RectTransform rect;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(rect.DOAnchorPos(new Vector3(0, 0, 0), 1f).SetEase(Ease.OutBounce))
        .AppendInterval(1f)
        .Append(rect.DOAnchorPos(new Vector3(0, 700, 0), 1f).SetEase(Ease.InBounce))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        rect.DOAnchorPos(new Vector3(0, 700, 0), 0f);
    }
}
