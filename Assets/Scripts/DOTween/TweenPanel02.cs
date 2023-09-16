using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class TweenPanel02 : TweenPanel
{
    public RectTransform rect;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(rect.DOAnchorPos(new Vector2(300, 300), 3f).SetRelative(true))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        rect.localPosition = Vector2.zero;
    }
}
